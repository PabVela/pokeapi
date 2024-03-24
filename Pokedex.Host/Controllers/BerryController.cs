using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Pokedexx.Application.DTOs;

namespace Pokedex.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BerryController : ControllerBase
    {
       

        public BerryController()
        {
            
        }

        [HttpGet("{name}")]
        public Task<IActionResult> Get(string name)
        {
            if(int.TryParse(name, out int id))
            {
                return Task.FromResult<IActionResult>(Ok("con id: "+id));
                //PETICION A BASE DE DATOS
            }
            else
            {
                return Task.FromResult<IActionResult>(Ok("Con nombre: "+name));
            }
        }

    }
}
