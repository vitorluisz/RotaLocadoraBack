using Microsoft.AspNetCore.Mvc;
using RotaLocadora.Model;
using RotaLocadora.Service.HistoryService;

namespace RotaLocadora.Controllers
{
    public class HistoryController : Controller
    {
        private readonly IHistoryInterface _IHistoryInterface;
        public HistoryController(IHistoryInterface historyInterface)
        {
            _IHistoryInterface = historyInterface;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<HistoryActivitiesModel>>>> GetHistory()
        {
            return Ok(await _IHistoryInterface.GetHistory());
        }
    }
}
