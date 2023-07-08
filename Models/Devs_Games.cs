namespace E_Commerce.Models
{
    public class Devs_Games
    {
        public int gameId { get; set; }
        public GameModel game { get; set; }

        public int devId { get; set; }
        public DeveloperModel dev { get; set; }


    }
}
