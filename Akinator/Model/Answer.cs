namespace AkinatorEngine.Model
{
    public class Answer
    {
        public int Id;

        public string Text = string.Empty;

        /// <summary>
        /// Enropee
        /// </summary>
        public float Possibility = 0.001f;

        public int CountOfGamesWhenWasAsTarget = 1;
    }
}
