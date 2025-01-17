using Microsoft.AspNetCore.Mvc;
using RotaLocadora.Model;
using RotaLocadora.Service.CarsService;
using RotaLocadora.Service.UsuariosService;

namespace RotaLocadora.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarsInterface _ICarsInterface;
        public CarsController(ICarsInterface carsInterface)
        {
            _ICarsInterface = carsInterface;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<CarsModel>>>> GetCars()
        {
            return Ok(await _ICarsInterface.GetCars());
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<CarsModel>>>> CreateCars(CarsModel novoCars)
        {
            return Ok(await _ICarsInterface.CreateCars(novoCars));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<CarsModel>>>> UpdateCars(CarsModel editadoCars)
        {
            return Ok(await _ICarsInterface.UpdateCars(editadoCars));
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<CarsModel>>>> DeleteCars(int id)
        {
            return Ok(await _ICarsInterface.DeleteCars(id));
        }
    }
}
