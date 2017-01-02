namespace AkinatorEngine.Models.DB
{
    [PetaPoco.TableName("questions")]
    [PetaPoco.PrimaryKey("question_id")]
    public class Question
    {
        public long question_id { get; set; }
        public string text { get; set; }
        public bool hidden_from_ui { get; set; }
        public bool shown_only_for_doctors { get; set; }
    }
}
