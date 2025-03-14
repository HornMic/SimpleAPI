using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController() : ControllerBase
    {

        [HttpGet] 
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"value1", "value2"};
        }



        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
        return "Les Jackson";
        }

    }
}
