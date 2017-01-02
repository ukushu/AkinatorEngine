namespace AkinatorEngine.Models.DB
{
    [PetaPoco.TableName("gameReactHistory")]
    [PetaPoco.PrimaryKey("game_react_history_id")]
    public class GameReactHistory
    {
        public long game_react_history_id { get; set; }
        public long question_id { get; set; }
        public long reaction_id { get; set; }
    }
}
