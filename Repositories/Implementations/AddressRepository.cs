using BmesRestApi.Database;
using BmesRestApi.Models.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesRestApi.Repositories.Implementations
{
    public class AddressRepository :IAddressRepository
    {
        public readonly BmesDbContext _context;
        public AddressRepository(BmesDbContext context)
        {
            _context = context;
        }

        public Address FindAddressById(long Id)
        {
            var address = _context.Addresses.Find(Id);
            return address;
        }

        public IEnumerable<Address> GetAllAdresses()
        {
            var addresses = _context.Addresses;
            return addresses;
        }

        public void SaveAddress(Address address)
        {
            _context.Addresses.Add(address);
            _context.SaveChanges();
        }
        public void UpdateAddress(Address address)
        {
            _context.Addresses.Update(address);
            _context.SaveChanges();
        }
        public void DeleteAddresses(Address address)
        {
            _context.Addresses.Remove(address);
            _context.SaveChanges();
        }
    }
}
