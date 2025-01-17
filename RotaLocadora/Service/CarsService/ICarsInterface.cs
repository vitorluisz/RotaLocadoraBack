using RotaLocadora.Model;

namespace RotaLocadora.Service.CarsService
{
    public interface ICarsInterface
    {
        Task<ServiceResponse<List<CarsModel>>> CreateCars(CarsModel car);
        Task<ServiceResponse<List<CarsModel>>> GetCars();
        Task<ServiceResponse<List<CarsModel>>> UpdateCars(CarsModel car);
        Task<ServiceResponse<List<CarsModel>>> DeleteCars(int id);
    }
}
