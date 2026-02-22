using Microsoft.AspNetCore.Mvc;
using RentACarProject.BusinessLayer.Abstract;
using RentACarProject.EntityLayer.Concrete;

namespace RentACar.PresentationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
   public class PresentationController : ControllerBase {
        private readonly IOrderService _orderService;
        public PresentationController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet("{id}")]
        public IActionResult GetByIdOrder(int id) { 
            if(id == 0) { return BadRequest(); }
          var GetOrder= _orderService.TGetById(id);
            return Ok(new
            {   
                msg = "Baþarýlýrý",
                Order = GetOrder
            });
        }

        [HttpPost("{order}")]
        public IActionResult AddOrder(Order order) { 
            if(order == null){ NotFound(); }
        _orderService.TInsert(order);
            return Ok("Sipariþ Eklendi");
        }
        [HttpDelete("{order}")]
        public IActionResult DeleteByIdOrder(Order order) { 
        _orderService.TDelete(order);
            return NoContent();

        }
        [HttpPut]
        public IActionResult UpdateOrder(Order order)
        {
            _orderService.TUpdate(order);
            return Ok("Sipariþ baþarýyla güncellendi.");
        }

    }
   
        
    
}
