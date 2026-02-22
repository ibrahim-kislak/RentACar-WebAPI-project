using Microsoft.AspNetCore.Mvc;
using RentACarProject.BusinessLayer.Abstract;
using RentACarProject.EntityLayer.Concrete;

namespace RentACar.PresentationLayer.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdCustomer(int id)
        {
            var value = _customerService.TGetById(id);
            return Ok(value);
        }

        [HttpPost("{car}")]
        public IActionResult InsertCustomer (Customer customer)
        {
            _customerService.TInsert(customer);
            return Created();
        }
        [HttpPut]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _customerService.TUpdate(customer);
            return Ok(customer);
        }
        [HttpDelete]
        public IActionResult DeleteCustomer(Customer customer)
        {
            _customerService.TDelete(customer);
            return Ok();
        }
    }
}
