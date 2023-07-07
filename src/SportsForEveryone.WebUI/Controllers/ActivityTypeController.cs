using Microsoft.AspNetCore.Mvc;
using SportsForEveryone.Application.DTOs;
using SportsForEveryone.Application.Interfaces;
using SportsForEveryone.WebUI.Models;

namespace SportsForEveryone.WebUI.Controllers
{
    public class ActivityTypeController : Controller
    {
        public readonly IActivityTypeService _activityTypeService; 

        public ActivityTypeController(IActivityTypeService activityTypeService)
        {
            _activityTypeService = activityTypeService;
        }

        public IActionResult Index()
        {
            var act = GetAll();
            var list = new List<ActivityTypeViewModel>();
            foreach (var item in act)
            {
                list.Add(new ActivityTypeViewModel { 
                    Id =  item.ActivityTypeId,
                    Name = item.Name
                });
            }            
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind("ActivityTypeName")] ActivityTypeViewModel activityTypeViewModel)
        {
            _activityTypeService.Create(new ActivityTypeCreationDTO { Name = activityTypeViewModel.Name });
            return RedirectToAction("Index");
        }

        public List<ActivityTypeDTO> GetAll()
        {
            var list = _activityTypeService.GetAll();
            return list;
        }
    }
}
