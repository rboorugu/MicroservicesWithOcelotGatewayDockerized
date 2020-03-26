using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace SportsAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SportsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Cricket", "Football", "Basketball", "Tennis" };
        }
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "CricketId = " + id;
        }
    }
}
