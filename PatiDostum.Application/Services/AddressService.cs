using AutoMapper;
using PatiDostum.Core.Entities;
using PatiDostum.Core.IRepositories;
using PatiDostum.Infrastructure.Dto;
using PatiDostum.Infrastructure.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Application.Services;
public class AddressService : IAddressService
{
    private readonly IAddressRepository _addressRepository;
    private readonly IMapper _mapper;

    public AddressService(IAddressRepository addressRepository, IMapper mapper)
    {
        _addressRepository = addressRepository;
        _mapper = mapper;

    }

    public async Task CreateAddress(CreateAddressDto address)
    {
        var addressDto = _mapper.Map<AddressEntity>(address);
         _addressRepository.CreateAddress(addressDto);
    }

    public bool DeleteAddress(Guid id)
    {
        _addressRepository.DeleteAddress(id);
        return true;
    }

    public List<AddressDto> GetAddress()
    {
        var addresses = _addressRepository.GetAddress();
        var addressesDto = _mapper.Map<List<AddressDto>>(addresses);
        return addressesDto;
    }

    public AddressDto GetAddressById(Guid id)
    {
        var address = _addressRepository.GetAddressById(id);
        var addressDto = _mapper.Map<AddressDto>(address);
        return addressDto;
    }

    public AddressDto GetAddressByUserId(string id)
    {
        var userAddress = _addressRepository.GetAddressByUserId(id);
        var userAddressDto = _mapper.Map<AddressDto>(userAddress);
        return userAddressDto;
    }

    public bool UpdateAddress(UpdateAddressDto address, Guid id)
    {

        var updateAddressDto = _mapper.Map<AddressEntity>(address);
        updateAddressDto.Id = id;
        _addressRepository.UpdateAddress(updateAddressDto);
        return true;


    }

}
