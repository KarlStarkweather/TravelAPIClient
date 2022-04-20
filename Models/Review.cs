using System.ComponentModel.DataAnnotations;

namespace TravelAPIClient.Models
{
    public class Review
    {
        public int ReviewID {get; set; }
        [Required]
        public int DestinationID {get; set; }
        [Required]
        [Range(0,5)]
        public int Rating {get; set; }
        [Required]
        public string Description {get; set; }
    }
    
}