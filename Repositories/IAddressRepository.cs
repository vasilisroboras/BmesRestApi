using BmesRestApi.Models.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Repositories
{
    public interface IAddressRepository
    {
        Address FindAddressById(long Id);

        IEnumerable<Address> GetAllAdresses();

        void SaveAddress(Address address);
        void UpdateAddress(Address address);
        void DeleteAddresses(Address address);
    }
}
