using RotaLocadora.DataContext;
using RotaLocadora.Model;

namespace RotaLocadora.Service.HistoryService
{
    public class HistoryService : IHistoryInterface
    {
        readonly private ApplicationDbContext _db;

        public HistoryService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse<List<HistoryActivitiesModel>>> GetHistory()
        {
            ServiceResponse<List<HistoryActivitiesModel>> serviceResponse = new ServiceResponse<List<HistoryActivitiesModel>>();

            try
            {
                serviceResponse.Dados = _db.HistoryActivities.ToList();

                if (serviceResponse.Dados.Count == 0)
                {
                    serviceResponse.Mensagem = "Sem dados encontrados.";
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
