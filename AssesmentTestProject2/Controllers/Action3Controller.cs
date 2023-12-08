using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AssesmentTestProject2.Controllers
{
    public class Action3Controller : Controller
    {
        public IActionResult TakeAction3(int id, int test, TestViewModel testViewModel)
        {
            return Json(new { message = "OK" });
        }
    }

    public class TestViewModel
    {

    }
}
