using RotaLocadora.Model;

namespace RotaLocadora.Service.UsuariosService
{
    public interface IUsuariosInterface
    {
        Task<ServiceResponse<List<UsuariosModel>>> CreateUsuario(UsuariosModel novoUsuario);
    }
}
