using PatiDostum.Core.Context;
using PatiDostum.Core.Entities;
using PatiDostum.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.Repositories;

public class AddressRepository : IAddressRepository
{
    private readonly ApplicationDbContext _applicationDbContext;
    public AddressRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
    public void CreateAddress(AddressEntity address)
    {
        _applicationDbContext.Address.Add(address);
        _applicationDbContext.SaveChanges();
    }

    public bool DeleteAddress(Guid id)
    {
        var deleteAddress = _applicationDbContext.Address.FirstOrDefault(x => x.Id == id);
        if (deleteAddress != null)
        {
            _applicationDbContext.Address.Remove(deleteAddress);
            _applicationDbContext.SaveChanges();

        }
        return true;
    }

    public List<AddressEntity> GetAddress()
    {
        var addresses = _applicationDbContext.Address.ToList();
        return addresses;

    }

    public AddressEntity GetAddressById(Guid id)
    {
        var address = _applicationDbContext.Address.FirstOrDefault(x => x.Id == id);
        return address;
    }

    public AddressEntity GetAddressByUserId(string id)
    {
        var usersAddress = (from user in _applicationDbContext.User
                            where user.Id == id
                            select user.Address).FirstOrDefault();
        return usersAddress;
    }

    public AddressEntity UpdateAddress(AddressEntity address)
    {
        var updatedAddress = _applicationDbContext.Address.FirstOrDefault(x => x.Id == address.Id);
        updatedAddress.ProvinceId = address.ProvinceId;
        updatedAddress.DistrictId = address.DistrictId;
        updatedAddress.NeighborhoodId = address.NeighborhoodId;
        updatedAddress.Detail = address.Detail;
        _applicationDbContext.Address.Update(updatedAddress);
        _applicationDbContext.SaveChanges();
        return updatedAddress;
    }
}

