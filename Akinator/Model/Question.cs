namespace AkinatorEngine.Model
{
    public class Question
    {
        public string Text = string.Empty;

        /// <summary>
        /// Enropee
        /// </summary>
        public float PossibilityOfThisIsNext = 0.001f;

        //TODO
        public int TimesAskedWhenThinkAbout(Answer answer)
        {
            return 1;
        }

        ///TODO:
        public int ReactionCountWhenThinkAboutAnswer(Answer answer, Reaction reaction)
        {
            return 1;
        }

        public bool HiddenFromUi = false;

        public bool ShownOnlyForDoctors = false; 
    }
}
