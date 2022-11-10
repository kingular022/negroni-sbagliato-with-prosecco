using _20._10.Serwisy.lab5;
using Microsoft.AspNetCore.Mvc;

namespace _20._10.Controllers.lab5
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SomeController : Controller
    {
        [HttpGet]
      public string CallMethod()
        {
            var someInstance = new SomeClass();
            return someInstance.Print(null);
        }
    }
}
