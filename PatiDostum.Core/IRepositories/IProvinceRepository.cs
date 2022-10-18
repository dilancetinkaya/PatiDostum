using PatiDostum.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.IRepositories;

public interface IProvinceRepository
{
    public List<ProvinceEntity> GetProvince();
    public ProvinceEntity GetProvinceById(Guid id);
    public void CreateProvince(ProvinceEntity province);
    public void UpdateProvince(ProvinceEntity province);
    public void DeleteProvince(Guid id);
}

