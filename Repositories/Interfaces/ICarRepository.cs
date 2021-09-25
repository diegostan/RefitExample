using System.Threading.Tasks;
using Refit;
using RefitExample.DTO;
using RefitExample.Models;
using RefitExample.Results;

namespace RefitExample.Repositories.Interfaces
{
    public interface ICarRepository
    {
        [Get("/v1/cars")]
        Task<CarDTO> ReturnCar();

        [Post("/v1/cars")]
        Task<Result> InsertCar(CarModel car);
    }
}