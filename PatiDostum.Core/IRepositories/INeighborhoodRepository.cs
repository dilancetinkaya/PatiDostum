using PatiDostum.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Core.IRepositories;

public interface INeighborhoodRepository
{
    public List<NeighborhoodEntity> GetNeighborhood();
    public NeighborhoodEntity GetNeighborhoodById(Guid id);
    public void CreateNeighborhood(NeighborhoodEntity neighborhood);
    public void UpdateNeighborhood(NeighborhoodEntity neighborhood);
    public void DeleteNeighborhood(Guid id);
}

