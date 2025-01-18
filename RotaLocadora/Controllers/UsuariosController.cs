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

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<List<UsuariosModel>>>> GetUsuarioById(int id)
        {
            return Ok(await _IUsuariosInterface.GetUsuarioById(id));
        }

        [HttpPost("verificar-usuario")]
        public async Task<ActionResult<ServiceResponse<string>>> Login([FromBody] UsuariosModel login)
        {
            return Ok(await _IUsuariosInterface.Login(login));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<UsuariosModel>>>> CreateUsuario(UsuariosModel novoUsuario)
        {
            return Ok(await _IUsuariosInterface.CreateUsuario(novoUsuario));
        }
    }
}
