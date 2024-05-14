using CustomerAPI.Models;
using CustomerAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService) => _customerService = customerService;

        [HttpPost]
        public Customers AddCustomers(Customers newCustomer) => _customerService.AddCustomer(newCustomer);
        [HttpGet]
        public IEnumerable<Customers> FetchAllCustomers() => _customerService.GetCustomerList();
        [HttpGet("{customerId:int}")]
        public Customers FetchCustomersById(int customerId) => _customerService.GetCustomerById(customerId);
        [HttpPut]
        public Customers UpdateExistingCustomer(Customers existingCustomer) => _customerService.UpdateCustomer(existingCustomer);
        [HttpDelete("{customerId:int}")]
        public bool DeleteCustomerById(int customerId) => _customerService.DeleteCustomer(customerId);
    }
}
