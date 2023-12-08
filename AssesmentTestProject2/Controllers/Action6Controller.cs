using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AssesmentTestProject2.Controllers
{
    public class Action6Controller : Controller
    {
        public IActionResult TakeAction6(int id, int test)
        {
            return Json(new { message = "OK" });
        }
    }
}
