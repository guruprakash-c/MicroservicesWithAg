using CustomerAPI.Data;
using CustomerAPI.Models;

namespace CustomerAPI.Services
{
    public class CustomersService : ICustomerService
    {
        private readonly CustomerDbContextClass _customerDbContext;
        public CustomersService(CustomerDbContextClass customerDbContext)
        {
            _customerDbContext = customerDbContext;
        }
        public Customers AddCustomer(Customers newCustomer)
        {
            var customer = _customerDbContext.Customers.Add(newCustomer);
            _customerDbContext.SaveChanges();
            return customer.Entity;
        }
        public IEnumerable<Customers> GetCustomerList() => _customerDbContext.Customers.ToList();
        public Customers GetCustomerById(int customerId) => _customerDbContext.Customers.Where(p => p.CustomerId == customerId).FirstOrDefault();
        public bool DeleteCustomer(int customerId)
        {
            var del_cust = _customerDbContext.Customers.Where(p => p.CustomerId == customerId).FirstOrDefault();
            _customerDbContext.Customers.Remove(del_cust);
            _customerDbContext.SaveChanges();
            return del_cust != null ? true : false;
        }
        public Customers UpdateCustomer(Customers existingCustomer)
        {
            var x_cust = _customerDbContext.Customers.Update(existingCustomer);
            _customerDbContext.SaveChanges();
            return x_cust.Entity;
        }
    }
}
