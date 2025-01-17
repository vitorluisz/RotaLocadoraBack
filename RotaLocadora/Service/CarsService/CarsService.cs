using Microsoft.EntityFrameworkCore;
using RotaLocadora.DataContext;
using RotaLocadora.Model;

namespace RotaLocadora.Service.CarsService
{
    public class CarsService : ICarsInterface
    {
        readonly private ApplicationDbContext _db;

        public CarsService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse<List<CarsModel>>> GetCars()
        {
            ServiceResponse<List<CarsModel>> serviceResponse = new ServiceResponse<List<CarsModel>>();

            try
            {
                serviceResponse.Dados = _db.Cars.ToList();

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

        public async Task<ServiceResponse<CarsModel>> GetCarById(int id)
        {
            ServiceResponse<CarsModel> serviceResponse = new ServiceResponse<CarsModel>();

            try
            {
                CarsModel car = _db.Cars.FirstOrDefault(x => x.Id == id);
                serviceResponse.Dados = car;

                if (car == null)
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

        public async Task<ServiceResponse<List<CarsModel>>> CreateCars(CarsModel novoCars)
        {
            ServiceResponse<List<CarsModel>> serviceResponse = new ServiceResponse<List<CarsModel>>();

            try
            {
                if (novoCars == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Informar dados.";
                    serviceResponse.Sucesso = false;
                }

                _db.Cars.Add(novoCars);
                await _db.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<CarsModel>>> UpdateCars(CarsModel recebidoCars)
        {
            ServiceResponse<List<CarsModel>> serviceResponse = new ServiceResponse<List<CarsModel>>();

            try
            {
                if (recebidoCars == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Informar dados.";
                    serviceResponse.Sucesso = false;
                    return serviceResponse;
                }

                var car = await _db.Cars.FirstOrDefaultAsync(x => x.Id == recebidoCars.Id);

                if (car == null)
                {
                    serviceResponse.Mensagem = "Funcionario não existe.";
                    return serviceResponse;
                }

                var CarsNovo = new CarsModel()
                {
                    Id = car.Id,
                    Marca = car.Marca,
                    Star = car.Star,
                    Latitude = car.Latitude,
                    Longitude = car.Longitude,
                    ZeroKm = car.ZeroKm,
                    Ano = car.Ano,
                    Cor = car.Cor,
                    Modelo = car.Modelo,
                    Proposito = car.Proposito
                };

                _db.Cars.Update(CarsNovo);
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<CarsModel>>> DeleteCars(int id)
        {
            ServiceResponse<List<CarsModel>> serviceResponse = new ServiceResponse<List<CarsModel>>();

            try
            {
                CarsModel car = await _db.Cars.FirstOrDefaultAsync(x => x.Id == id);

                if (car == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Chamado não existe.";
                    serviceResponse.Sucesso = false;
                }

                _db.Cars.Remove(car);
                await _db.SaveChangesAsync();

                serviceResponse.Dados = _db.Cars.ToList();
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
