using RotaLocadora.Model;

namespace RotaLocadora.Service.HistoryService
{
    public interface IHistoryInterface
    {
        Task<ServiceResponse<List<HistoryActivitiesModel>>> GetHistory();
    }
}
