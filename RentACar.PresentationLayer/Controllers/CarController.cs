using Microsoft.AspNetCore.Mvc;
using RentACarProject.BusinessLayer.Abstract;
using RentACarProject.EntityLayer.Concrete;

namespace RentACar.PresentationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController:ControllerBase
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService=carService;
        }

        [HttpGet]
        public IActionResult GetByIdCar (int id)
        {
            var IdCar= _carService.TGetById(id);
            return Ok(IdCar);
        }
        [HttpPost]
        public IActionResult InsertCar (Car car)
        {
            _carService.TInsert(car);
            return Created();
        }
        [HttpDelete]
        public IActionResult DeleteCar(Car car)
        {
            var cardelete = car;
            _carService.TDelete(cardelete);
            return Ok(cardelete);
        }
        [HttpPut]
        public IActionResult UpdateCar(Car car)
        {
            _carService.TUpdate(car);
            return NoContent();
        }

    }
}
