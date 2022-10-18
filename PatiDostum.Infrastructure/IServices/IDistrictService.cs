using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.IServices;

public interface IDistrictService
{
    public List<DistrictDto> GetDistrict();
    public DistrictDto GetDistrictById(Guid id);
    public void CreateDistrict(CreateDistrictDto district);
    public void UpdateDistrict(UpdateDistrictDto district,Guid id);
    public void DeleteDistrict(Guid id);
}

