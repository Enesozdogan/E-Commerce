using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class DeveloperModel
    {
        [Key]
        public int DevId { get; set; }
        public string? DevName { get; set; }
        public string? profilePicURL { get; set; }
        public string? bio { get; set; }

        //Relationships
        public List<Devs_Games> devs_games { get; set; }


    }
}
