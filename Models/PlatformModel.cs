using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class PlatformModel
    {
        [Key]
        public int platformId { get; set; }
        public string? platformName { get; set; }
        public string? logoImgURL { get; set; }

        public List<GameModel> games { get; set; }

    }
}
