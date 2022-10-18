using PatiDostum.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.IRepositories;

    public interface IAdKindRepository
    {
    public List<AdKindEntity> GetAdKind();
    public AdKindEntity GetAdKindById(Guid id);
    public void CreateAdKind(AdKindEntity adKind);
    public void UpdateAdKind(AdKindEntity adKind);
    public void DeleteAdKind(Guid id);
    }

