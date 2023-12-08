using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AssesmentTestProject2.Controllers
{
    public class Action8Controller : Controller
    {
        public IActionResult TakeAction8(int id)
        {
            return Json(new { message = "OK" });
        }
    }
}
