namespace AkinatorEngine.Models.DB
{
    [PetaPoco.TableName("gameHistory")]
    [PetaPoco.PrimaryKey("game_id")]
    public class GameHistory
    {
        public int game_id { get; set; }
        public int user_id { get; set; }
        public int answer_id { get; set; }
        public bool approved_by_moderator { get; set; }
    }
}
