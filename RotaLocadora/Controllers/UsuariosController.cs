using Microsoft.AspNetCore.Mvc;
using RotaLocadora.Model;
using RotaLocadora.Service.UsuariosService;

namespace RotaLocadora.Controllers
{
    [ApiController]
    public class UsuariosController : Controller
    {
        private readonly IUsuariosInterface _IFuncionarioInterface;
        public UsuariosController(IUsuariosInterface funcionarioInterface)
        {
            _IFuncionarioInterface = funcionarioInterface;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<UsuariosController>>>> CreateFuncionario(UsuariosModel novoFuncionario)
        {
            return Ok(await _IFuncionarioInterface.CreateFuncionario(novoFuncionario));
        }
    }
}
