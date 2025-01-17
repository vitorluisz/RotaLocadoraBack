using Microsoft.AspNetCore.Mvc;
using RotaLocadora.Model;
using RotaLocadora.Service.CarsService;
using RotaLocadora.Service.UsuariosService;

namespace RotaLocadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : Controller
    {
        private readonly IUsuariosInterface _IUsuariosInterface;
        public UsuariosController(IUsuariosInterface usuariosInterface)
        {
            _IUsuariosInterface = usuariosInterface;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<UsuariosController>>>> CreateUsuario(UsuariosModel novoUsuario)
        {
            return Ok(await _IUsuariosInterface.CreateUsuario(novoUsuario));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<List<CarsModel>>>> GetUsuarioById(int id)
        {
            return Ok(await _IUsuariosInterface.GetUsuarioById(id));
        }
    }
}
