using AkinatorEngine.FuzzyLogic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FuzzyLogic
{
    public class GameLogic
    {
        public ApriorPossibilityType ApriorPossibilityType = ApriorPossibilityType.Intelligent;

        public Dictionary<string, Reaction> QuestionAndReactionHistory = new Dictionary<string, Reaction>();

        private int ReactionQuantity { get { return Enum.GetNames(typeof(Reaction)).Length; } }

        //TODO: 
        private int CountOfGamesWhenAnswerIs(string answer) { return 1; }
        
        //TODO: 
        private int CountOfGames { get { return 1; } }
        
        ///TODO:
        private int CountOfExactReactionForThisQWhenThinkAboutAnswer(string question, Reaction reaction)
        {
            return 1;
        }

        ///TODO:
        private int CountOfQuestionAskedWhenThinkAboutAnswer(string q, string answer)
        {
            return 1;
        }

        private int CountOfAnswers { get { return 1; } }

        public int QuestionsAskedCounter { get { return QuestionAndReactionHistory.Count; } }

        private float ApriorPossibilityOfAnswer(string answer)
        {
            if (ApriorPossibilityType == ApriorPossibilityType.Standard)
            {
                return 1.0f / CountOfAnswers;
            }
            else if (ApriorPossibilityType == ApriorPossibilityType.Intelligent)
            {
                return (float)CountOfGamesWhenAnswerIs(answer) / CountOfGames;
            }

            return 0;
        }

        /// <summary>
        /// pBAi
        /// </summary>
        private float PossibilityOfQuestionsAndReactionsRelativelyPossibleAnswer(string answer)
        {
            if (QuestionsAskedCounter == 0)
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
        private float PossibilityOfExactReactionOnQuestionRelativelyAnswer(string question, Reaction reaction, string answer)
        {
            float pBjAi;

            var countOfExactReactionForThisQWhenThinkAboutAnswer = CountOfExactReactionForThisQWhenThinkAboutAnswer(question, reaction);
            var countOfQuestionAskedWhenThinkAboutAnswer = CountOfQuestionAskedWhenThinkAboutAnswer(question, answer);

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
        public float PossibilityOfAnswer(string answer)
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
    }
}
