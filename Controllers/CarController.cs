using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RefitExample.DTO;
using RefitExample.Models;
using RefitExample.Repositories.Interfaces;
using RefitExample.Results;

namespace RefitExample.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class CarController : ControllerBase
    {
        [HttpGet]
        public Task<CarDTO> GetCars([FromServices] ICarRepository repository)
        {
            return repository.ReturnCar();
        }

        [HttpPost]
        public Task<Result> PostCar([FromBody] CarModel car, [FromServices] ICarRepository repository)
        {
            return repository.InsertCar(car);
        }
    }
}