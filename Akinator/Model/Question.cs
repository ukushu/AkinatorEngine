namespace AkinatorEngine.Model
{
    public class Question
    {
        public int Id;

        public string Text = string.Empty;

        /// <summary>
        /// Enropee
        /// </summary>
        public float PossibilityOfThisIsNext = 0.001f;
        
        public int TimesAskedWhenThinkAbout(Db db, Answer answer)
        {
            return db.QuestionAskedWhenThinkAboutAnswer(this, answer);
        }
        
        public int ReactionCountWhenThinkAboutAnswer(Db db, Answer answer, Reaction reaction)
        {
            return db.QuestionReactionCountWhenThinkAboutAnswer(this,reaction, answer);
        }

        public bool HiddenFromUi = false;

        public bool ShownOnlyForDoctors = false; 
    }
}
