using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace WebApplication1.Controllers
{
    public class GoldController : Controller
    {
        public IActionResult List()
        {
            /*ContentResult c=new ContentResult();
            c.ContentType = "text.html";
            c.Content = "<h1>hello</h1>";
            return c;
            */

            return View();
        }
    }
}
