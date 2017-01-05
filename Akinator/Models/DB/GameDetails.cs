namespace AkinatorEngine.Models.DB
{
    [PetaPoco.TableName("gameDetails")]
    [PetaPoco.PrimaryKey("id")]
    public class GameDetails
    {
        public int id { get; set; }
        public int game_id { get; set; }
        public int question_id { get; set; }
        public int reaction_id { get; set; }
    }
}
