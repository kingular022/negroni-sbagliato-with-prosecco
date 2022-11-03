using _20._10.Serwisy.lab4;
using Microsoft.AspNetCore.Mvc;

namespace _20._10.Controllers.lab4
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LanguageController : ControllerBase
    {
        [HttpGet]
        public string GetLang()
        {
            var lang = new Polish("pl");
            return lang.getLanguageName();
        }
    }
}
