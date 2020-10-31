using BmesRestApi.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Repositories
{
    public interface ICustomerRepository
    {
        Customer FindCustomerById(long Id);
        IEnumerable<Customer> GetAllCustomers();
        void SaveCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);


    }
}
