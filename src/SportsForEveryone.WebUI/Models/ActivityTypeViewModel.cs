using System.ComponentModel.DataAnnotations;

namespace SportsForEveryone.WebUI.Models
{
    public class ActivityTypeViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
