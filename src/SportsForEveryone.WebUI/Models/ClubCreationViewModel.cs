namespace SportsForEveryone.WebUI.Models
{
    public class ClubCreationViewModel
    {
        public int ClubId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string WebSite { get; set; }
        public IFormFile Picture { get; set; }
    }
}
