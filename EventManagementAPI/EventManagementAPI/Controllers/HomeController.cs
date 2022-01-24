using EventManagementAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementAPI.Controllers
{
    public class HomeController : Controller
    {
       
            public ActionResult Index()
            {
                User obj = new User();
                return View(obj);
            }

    }
}
