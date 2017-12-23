using System.ComponentModel.DataAnnotations;

namespace FantasyNBA.Models
{
    public class PlayerDTO
    {
        
        public int InternalId { get; set; }
        public string PlayerApiID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string BirthDate { get; set; }
        public string Age { get; set; }
        public string BirthCity { get; set; }
        public string BirthCountry { get; set; }
        public string IsRookie { get; set; }
        public string officialImageSrc { get; set; }
        public int? TeamId { get; set; }
    }
}