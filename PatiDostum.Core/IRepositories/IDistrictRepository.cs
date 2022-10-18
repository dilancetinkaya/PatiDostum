using PatiDostum.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.IRepositories;

public interface IDistrictRepository
{
    public List<DistrictEntity> GetDistrict();
    public DistrictEntity GetDistrictById(Guid id);
    public void CreateDistrict(DistrictEntity district);
    public void UpdateDistrict(DistrictEntity district);
    public void DeleteDistrict(Guid id);
}

