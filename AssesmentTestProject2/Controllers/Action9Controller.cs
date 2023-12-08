using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AssesmentTestProject2.Controllers
{
    public class Action9Controller : Controller
    {
        public IActionResult TakeAction9(int id)
        {
            return Json(new { message = "OK" });
        }
    }
}
