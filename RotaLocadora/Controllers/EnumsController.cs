using Microsoft.AspNetCore.Mvc;
using RotaLocadora.Enums;

namespace RotaLocadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnumsController : ControllerBase
    {

        [HttpGet("Cores")]
        public ActionResult<IEnumerable<string>> GetCoresEnum()
        {

            var cores = Enum.GetValues(typeof(CoresEnum))
                            .Cast<CoresEnum>()
                            .Select(c => c.ToString())
                            .ToList();

            return Ok(cores);
        }

        [HttpGet("Proposito")]
        public ActionResult<IEnumerable<string>> GetPropositoEnum()
        {

            var cores = Enum.GetValues(typeof(PropositoEnum))
                            .Cast<PropositoEnum>()
                            .Select(c => c.ToString())
                            .ToList();

            return Ok(cores);
        }

        [HttpGet("Cars")]
        public ActionResult<IEnumerable<string>> GetCarsEnum()
        {

            var cores = Enum.GetValues(typeof(CarsEnum))
                            .Cast<CarsEnum>()
                            .Select(c => c.ToString())
                            .ToList();

            return Ok(cores);
        }
    }
}
