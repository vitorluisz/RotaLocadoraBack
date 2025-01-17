using RotaLocadora.DataContext;
using RotaLocadora.Model;

namespace RotaLocadora.Service.UsuariosService
{
    public class UsuariosService
    {
        readonly private ApplicationDbContext _db;

        public UsuariosService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse<List<UsuariosModel>>> CreateFuncionario(UsuariosModel novoFuncionario)
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

    }
}
