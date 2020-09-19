using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class HallController : Controller
    {
        private IHallService _hallService;

        public HallController(IHallService hallService)
        {
            _hallService = hallService;
        }

        public IActionResult Index()
        {
            var model = new HallListViewModel()
            {
                
                Halls = _hallService.GetAll()
                
            };
            return View(model);
        }
    }
}
