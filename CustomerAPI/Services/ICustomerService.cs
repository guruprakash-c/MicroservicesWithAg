using CustomerAPI.Models;

namespace CustomerAPI.Services
{
    public interface ICustomerService
    {
        public IEnumerable<Customers> GetCustomerList();
        public Customers GetCustomerById(int customerId);
        public Customers AddCustomer(Customers newCustomer);
        public Customers UpdateCustomer(Customers existingCustomer);
        public bool DeleteCustomer(int customerId);
    }
}
