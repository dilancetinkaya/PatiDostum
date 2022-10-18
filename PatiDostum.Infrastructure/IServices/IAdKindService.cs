using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.IServices;

    public interface IAdKindService
    {
    public List<AdKindDto> GetAdKind();
    public AdKindDto GetAdKindById(Guid id);
    public void CreateAdKind(CreateAdKindDto adKind);
    public void UpdateAdKind(UpdateAdKindDto adKind,Guid id);
    public void DeleteAdKind(Guid id);
}

