using Microsoft.AspNetCore.Mvc;
using SportsForEveryone.Application.DTOs;
using SportsForEveryone.Application.Interfaces;
using SportsForEveryone.WebUI.Models;

namespace SportsForEveryone.WebUI.Controllers
{
    public class ClubController : Controller
    {
        private readonly IClubService _clubService;

        public ClubController(IClubService clubService)
        {
            _clubService = clubService;
        }

        public IActionResult Index()
        {
            var clubs = _clubService.GetAll();
            var clubsModel = new List<ClubViewModel>();
            foreach (var club in clubs)
            {
                clubsModel.Add(new ClubViewModel
                {
                    Name = club.Name,
                    Address = club.Address,
                    ClubId = club.ClubId,
                    Picture = Url.Content(club.Picture),
                    WebSite = club.WebSite,
                });
            }
            return View(clubsModel);
        }



        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([FromForm] ClubCreationViewModel clubViewModel) 
        {
            _clubService.CreateClub(new ClubCreationDTO
            {
                Name = clubViewModel.Name,
                Address = clubViewModel.Address,
                Picture = clubViewModel.Picture,
                WebSite = clubViewModel.WebSite,
            });
            return RedirectToAction("Index");
        } 
    }
}
