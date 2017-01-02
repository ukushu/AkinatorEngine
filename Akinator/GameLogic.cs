using System;
using System.Collections.Generic;
using System.Linq;
using AkinatorEngine.FuzzyLogic;
using AkinatorEngine.Model;

namespace AkinatorEngine
{
    public class GameLogic
    {
        public ApriorAnswerPossibilityType ApriorAnswerPossibilityType = ApriorAnswerPossibilityType.Intelligent;

        public Dictionary<Question, Reaction> QuestionAndReactionHistory = new Dictionary<Question, Reaction>();

        public List<Question> Questions = new List<Question>();
        public List<Answer> Answers = new List<Answer>();

        private int ReactionQuantity { get { return Enum.GetNames(typeof(Reaction)).Length; } }

        //TODO: 
        private int CountOfGames { get { return 1; } }
        
        private float ApriorPossibilityOfAnswer(Answer answer)
        {
            if (ApriorAnswerPossibilityType == ApriorAnswerPossibilityType.Standard)
            {
                return 1.0f / Answers.Count;
            }
            else if (ApriorAnswerPossibilityType == ApriorAnswerPossibilityType.Intelligent)
            {
                return (float)answer.CountOfGamesWhenWasAsTarget / CountOfGames;
            }

            return 0;
        }

        /// <summary>
        /// pBAi
        /// </summary>
        private float PossibilityOfQuestionsAndReactionsRelativelyPossibleAnswer(Answer answer)
        {
            if (QuestionAndReactionHistory.Count == 0)
            {
                return ApriorPossibilityOfAnswer(answer);
            }

            List<float> Bj = new List<float>();
            foreach (var pair in QuestionAndReactionHistory)
            {
                var tmp = PossibilityOfExactReactionOnQuestionRelativelyAnswer(pair.Key, pair.Value, answer);
                Bj.Add(tmp);
            }

            float rez = 1;

            foreach (var b in Bj)
            {
                rez *= b;
            }

            return rez;
        }

        /// <summary>
        /// pBjAi
        /// </summary>
        private float PossibilityOfExactReactionOnQuestionRelativelyAnswer(Question question, Reaction reaction, Answer answer)
        {
            float pBjAi;

            var countOfExactReactionForThisQWhenThinkAboutAnswer = question.ReactionCountWhenThinkAboutAnswer(answer,reaction);
            var countOfQuestionAskedWhenThinkAboutAnswer = question.TimesAskedWhenThinkAbout(answer);

            if (countOfExactReactionForThisQWhenThinkAboutAnswer == 0)
            {
                countOfExactReactionForThisQWhenThinkAboutAnswer = 1;

                //ReactionQuantity == Qj

                pBjAi = Helper.Bayes(1, countOfExactReactionForThisQWhenThinkAboutAnswer, ReactionQuantity);
            }
            else
            {
                pBjAi = Helper.Bayes(1, countOfExactReactionForThisQWhenThinkAboutAnswer, countOfQuestionAskedWhenThinkAboutAnswer);
            }

            return pBjAi;
        }

        /// <summary>
        /// pAiB
        /// розраховується індивідуально для кожної відповідіі
        /// </summary>
        private float PossibilityOfAnswer(Answer answer)
        {
            var pBAi = PossibilityOfQuestionsAndReactionsRelativelyPossibleAnswer(answer);

            List<float> Bj = new List<float>();
            foreach (var pair in QuestionAndReactionHistory)
            {
                var tmp = PossibilityOfExactReactionOnQuestionRelativelyAnswer(pair.Key, pair.Value, answer);
                Bj.Add(tmp);
            }

            var B = Fuzz.And(Bj.ToArray());

            var rez = Helper.Bayes(1, pBAi, B);

            return rez;
        }

        private void CalcAnswersPossibilityAndSortByIt()
        {
            foreach (var answ in Answers)
            {
                answ.Possibility = PossibilityOfAnswer(answ);
            }

            Answers = Answers.OrderByDescending(o => o.Possibility).ToList();
        }

        private void CalcQuestionIsNextPossibility()
        {
            var answerWithMaxPoss = Answers[0];
            
            foreach (var q in Questions)
            {
                float maxChangeOfPossibility = 0;

                foreach (Reaction react in Enum.GetValues(typeof(Reaction)))
                {
                    maxChangeOfPossibility += PossibilityOfExactReactionOnQuestionRelativelyAnswer(q, react,
                        answerWithMaxPoss);
                }
                
                q.PossibilityOfThisIsNext = maxChangeOfPossibility + answerWithMaxPoss.Possibility;
            }

            Questions = Questions.OrderByDescending(o => o.PossibilityOfThisIsNext).ToList();
        }

        public void CalcPossibilities()
        {
            CalcAnswersPossibilityAndSortByIt();
            CalcQuestionIsNextPossibility();
        }
    }
}
