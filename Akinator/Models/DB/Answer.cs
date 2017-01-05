namespace AkinatorEngine.Models.DB
{
    [PetaPoco.TableName("answers")]
    [PetaPoco.PrimaryKey("answer_id")]
    public class Answer
    {
        public int answer_id { get; set; }
        public string text { get; set; }
    }
}
