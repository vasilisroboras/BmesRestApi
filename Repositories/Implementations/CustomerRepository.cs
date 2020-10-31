using BmesRestApi.Database;
using BmesRestApi.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Repositories.Implementations
{
    public class CustomerRepository :ICustomerRepository
    {
        private BmesDbContext _context;
        public CustomerRepository(BmesDbContext context)
        {
            _context = context;
        }

        public Customer FindCustomerById(long Id)
        {
            var customer = _context.Customers.Find(Id);
            return customer;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            var customer = _context.Customers;
            return customer;
        }

        public void SaveCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
        public void UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }
        public void DeleteCustomer(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
    }
}
