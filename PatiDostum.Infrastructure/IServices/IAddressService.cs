using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.IServices;

    public interface IAddressService
    {
    public List<AddressDto> GetAddress();
    public AddressDto GetAddressById(Guid id);
    public AddressDto GetAddressByUserId(string id);
    public Task CreateAddress(CreateAddressDto address);
    public bool UpdateAddress(UpdateAddressDto address,Guid id);
    public bool DeleteAddress(Guid id);
}

