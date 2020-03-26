using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PlayersAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlayersController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Lebron", "Sachin", "Federer" };
        }

        [HttpGet("{sport}")]
        public ActionResult<string> Get(string sport)
        {
            if (sport == "Cricket")
                return "sachin";
            else if (sport == "Football")
                return "Drew Bress";
            else if (sport == "Basketball")
                return "Lebron James";
            else if (sport == "Tennis")
                return "Federer";
            else
                return "no matching sport";
        }
    }
}