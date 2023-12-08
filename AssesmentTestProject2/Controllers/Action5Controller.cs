using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AssesmentTestProject2.Controllers
{
    public class Action5Controller : Controller
    {
        public IActionResult TakeAction5(int id)
        {
            return Json(new { message = "OK" });
        }
    }
}
