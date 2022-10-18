using PatiDostum.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.IRepositories;
  public interface IAddressRepository
    {
    public List<AddressEntity> GetAddress();
    public AddressEntity GetAddressById(Guid id);
    public AddressEntity GetAddressByUserId(string id);
    public void CreateAddress(AddressEntity address);
    public AddressEntity UpdateAddress(AddressEntity address);
    public bool DeleteAddress(Guid id);
}
