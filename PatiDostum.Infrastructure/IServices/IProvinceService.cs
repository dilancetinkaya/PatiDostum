using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.IServices;

public interface IProvinceService
{
    public List<ProvinceDto> GetProvince();
    public ProvinceDto GetProvinceById(Guid id);
    public void CreateProvince(CreateProvinceDto province);
    public void UpdateProvince(UpdateProvinceDto province,Guid id);
    public void DeleteProvince(Guid id);
}

