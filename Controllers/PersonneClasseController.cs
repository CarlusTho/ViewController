using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VueController.Models;
using VueController.Services;

namespace VueController.Controllers
{
    [Route("[Controller]/")]
    public class PersonneClasseController : Controller
    {
        public ClasseService ClasseService;
        public PersonneClasseController(ClasseService service)
        {
            ClasseService = service;
        }
        public IActionResult Index()
        {
            return View(ClasseService.Personnes);
        }
    }
}
