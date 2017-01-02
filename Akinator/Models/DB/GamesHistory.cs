namespace AkinatorEngine.Models.DB
{
    [PetaPoco.TableName("gamesHistory")]
    [PetaPoco.PrimaryKey("game_id")]
    public class GamesHistory
    {
        public long game_id { get; set; }
        public long user_id { get; set; }
        public long answer_id { get; set; }
        public long game_react_hitory_id { get; set; }
        public bool approved_by_moderator { get; set; }
    }
}
