using _20._10.Serwisy.lab3;
using Microsoft.AspNetCore.Mvc;

namespace _20._10.Controllers.lab3
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class RectangleController : ControllerBase
    {
        [HttpGet]
        public int GetArea()
        {
            var rec = new Rectangle(23, 23);
            return rec.GetArea(2);
        }

        [HttpGet]
        public int GetSumArea() 
        {
            var rec = new Rectangle(4, 4); 
            var rec2 = new Rectangle(3, 3);
            var result = rec + rec2;
            return result.GetArea();
        }
        /*
        public int GetArea(int x)
        {
            var rec = new Rectangle(x, 23);
            return rec.GetArea(x);
        }
        */
    }
}
