using Microsoft.AspNetCore.Mvc;

namespace AssesmentTestProject2.Controllers
{
    public class Action1Controller : Controller
    {
        public IActionResult TakeAction1(int id, int test)
        {
            return Json(new { message = "OK" });
        }
    }
}
