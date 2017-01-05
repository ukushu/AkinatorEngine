namespace AkinatorEngine.Models.DB
{
    [PetaPoco.TableName("users")]
    [PetaPoco.PrimaryKey("user_id")]
    public class User
    {
        public int user_id { get; set; }
        public bool is_doctor { get; set; }
        public string login { get; set; }
    }
}
