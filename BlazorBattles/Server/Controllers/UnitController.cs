using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorBattles.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorBattles.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        public IList<Unit> Units => new List<Unit>
        {
            new Unit { Id = 1, Titie = "Knight", Attack = 10, Defense = 10, BananaCost = 100 },
            new Unit { Id = 2, Titie = "Archer", Attack = 15, Defense = 5, BananaCost = 150 },
            new Unit { Id = 3, Titie = "Mage", Attack = 20, Defense = 1, BananaCost = 200 },
        };

        [HttpGet]
        public IActionResult GetUnits()
        {
            return Ok(Units);
        }
    }
}
