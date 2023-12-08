using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AssesmentTestProject2.Controllers
{
    public class Action2Controller : Controller
    {
        public IActionResult TakeAction2(int id, int test, string test2)
        {
            return Json(new { message = "OK" });
        }
    }
}
