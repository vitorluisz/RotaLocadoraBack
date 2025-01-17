using RotaLocadora.DataContext;
using RotaLocadora.Model;

namespace RotaLocadora.Service.UsuariosService
{
    public class UsuariosService : IUsuariosInterface
    {
        readonly private ApplicationDbContext _db;

        public UsuariosService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse<List<UsuariosModel>>> CreateUsuario(UsuariosModel novoFuncionario)
        {
            ServiceResponse<List<UsuariosModel>> serviceResponse = new ServiceResponse<List<UsuariosModel>>();

            try
            {
                if (novoFuncionario == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Informar dados.";
                    serviceResponse.Sucesso = false;
                }

                _db.Usuarios.Add(novoFuncionario);
                await _db.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<UsuariosModel>> GetUsuarioById(int id)
        {
            ServiceResponse<UsuariosModel> serviceResponse = new ServiceResponse<UsuariosModel>();

            try
            {
                UsuariosModel usuario = _db.Usuarios.FirstOrDefault(x => x.Id == id);
                serviceResponse.Dados = usuario;

                if (usuario == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuário não localizado.";
                    serviceResponse.Sucesso = false;
                }

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;
        }

    }
}
