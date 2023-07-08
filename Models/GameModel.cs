using E_Commerce.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public class GameModel
    {
        [Key]
        public int gameId { get; set; }
        public string? gameName { get; set; }
        public string? releaseDate { get; set; }
        public string? profilePicURL { get; set; }

        public GameCategory gameCategory { get; set; }

        public List<Devs_Games> devs_games { get; set; }

        //Platform of a game
        [ForeignKey("platformId")]
        public int platformId { get; set; }
        
        public PlatformModel platform { get; set; }
    }
}
