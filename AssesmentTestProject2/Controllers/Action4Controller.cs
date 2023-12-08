using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AssesmentTestProject2.Controllers
{
    public class Action4Controller : Controller
    {
        public IActionResult TakeAction4(int id, int test2222)
        {
            return Json(new { message = "OK" });
        }
    }
}
