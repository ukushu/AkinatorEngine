using System;
using System.Collections.Generic;
using System.Linq;
using AkinatorEngine.FuzzyLogic;
using AkinatorEngine.Model;

namespace AkinatorEngine
{
    public class GameLogic
    {
        private Db Db = new Db();
        public DbQuestionsEditor Questions;
        public DbAnswerEditor Answers;

        public ApriorAnswerPossibilityType ApriorAnswerPossibilityType = ApriorAnswerPossibilityType.Intelligent;

        public Dictionary<Question, Reaction> QuestionAndReactionHistory = new Dictionary<Question, Reaction>();

        public List<Question> QuestionsAll;
        public List<Answer> AnswersAll;

        public List<Question> QuestionsNotAsked
        {
            get
            {
                var ids = QuestionAndReactionHistory.Keys.ToList().Select(i => i.Id).ToList();

                var exceptItems = QuestionsAll.Where(b => ids.Contains(b.Id)).ToList();

                return QuestionsAll.Except(exceptItems).ToList();
            }
        }

        public void AnswerOnQuestion(Question q, Reaction react)
        {
            QuestionAndReactionHistory.Add(q, react);
        }

        public GameLogic()
        {
            Questions = new DbQuestionsEditor(Db);

            UpdateQandA();
        }

        public void UpdateQandA()
        {
            QuestionsAll = Db.QuestionsGetAll();
            AnswersAll = Db.AnswersGetAll();
            CalcPossibilities();
        }

        private int ReactionQuantity { get { return Enum.GetNames(typeof(Reaction)).Length; } }

        public void CalcPossibilities()
        {
            CalcAnswersPossibilityAndSortByIt();
            CalcQuestionIsNextPossibility();
        }

        //WORKING GOOD!
        private void CalcAnswersPossibilityAndSortByIt()
        {
            foreach (var answ in AnswersAll)
            {
                answ.Possibility = CalcCurrAnswerPossibility(answ);
            }

            AnswersAll = AnswersAll.OrderByDescending(o => o.Possibility).ToList();
        }

        /// <summary>
        /// pAiB  розраховується індивідуально для кожної відповідіі - може щось не так
        /// </summary>
        private float CalcCurrAnswerPossibility(Answer answer)
        {
            if (QuestionAndReactionHistory.Count == 0)
            {
                return CalcApriorAnswerPossibility(answer);
            }

            List<float> Bj = new List<float>();
            foreach (var pair in QuestionAndReactionHistory)
            {
                var react = pair.Value;
                var question = pair.Key;

                var rezPossibil = ExactReactionOnQuestionRelativelyAnswerPossibility(react, question, answer);

                Bj.Add(rezPossibil);
            }

            var rez = Fuzz.Or(Bj.ToArray());

            return rez;
        }

        private float CalcApriorAnswerPossibility(Answer answer)
        {
            if (ApriorAnswerPossibilityType == ApriorAnswerPossibilityType.Standard)
            {
                return 1.0f / AnswersAll.Count;
            }
            else if (ApriorAnswerPossibilityType == ApriorAnswerPossibilityType.Intelligent)
            {
                var gamesCount = Db.CountOfGames();

                if (gamesCount == 0)
                    return 1;

                return (float)answer.CountOfGamesWhenWasAsTarget / gamesCount;
            }

            return 0;
        }

        // pBjAi - WORKING GOOD!
        private float ExactReactionOnQuestionRelativelyAnswerPossibility(Reaction reaction, Question question, Answer answer)
        {
            float pBjAi;

            var countOfExactReactionForThisQWhenThinkAboutAnswer = question.ReactionCountWhenThinkAboutAnswer(Db, answer, reaction);

            var countOfQuestionAskedWhenThinkAboutAnswer = question.TimesAskedWhenThinkAbout(Db, answer);

            if (countOfExactReactionForThisQWhenThinkAboutAnswer == 0)
            {
                //ReactionQuantity == Qj
                pBjAi = Helper.Bayes(1, 1, ReactionQuantity);
            }
            else
            {
                pBjAi = Helper.Bayes(1, countOfExactReactionForThisQWhenThinkAboutAnswer, countOfQuestionAskedWhenThinkAboutAnswer);
            }

            return pBjAi;
        }

        private void CalcQuestionIsNextPossibility()
        {
            if (QuestionsNotAsked.Count == 0 || AnswersAll.Count == 0)
                return;

            var answersWithMaxPoss = AnswersAll.Where(a => a.Possibility == AnswersAll[0].Possibility).ToList()[0]; ;

            foreach (var q in QuestionsNotAsked)
            {
                float maxChangeOfPossibility = 0;

                List<float> diffPosForReactions = new List<float>();

                foreach (Reaction react in Enum.GetValues(typeof(Reaction)))
                {
                    var tmp = ExactReactionOnQuestionRelativelyAnswerPossibility(react, q, answersWithMaxPoss);

                    diffPosForReactions.Add(tmp);
                }

                q.PossibilityOfThisIsNext = Fuzz.Or(diffPosForReactions.ToArray());
            }

            QuestionsAll = QuestionsAll.OrderByDescending(o => o.PossibilityOfThisIsNext).ToList();
        }

        public void ForceGameFinishWithAnswer(Answer ans)
        {
            var currUsr = Db.GetFirstUser();

            Db.GameAdd(currUsr, ans, QuestionAndReactionHistory);

            ForceNewGame();
        }


        public void ForceNewGame()
        {
            QuestionAndReactionHistory.Clear();
            CalcPossibilities();
        }
    }
}
