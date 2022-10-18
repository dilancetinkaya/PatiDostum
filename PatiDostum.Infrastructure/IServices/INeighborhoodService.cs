using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.IServices;

public interface INeighborhoodService
{
    public List<NeighborhoodDto> GetNeighborhood();
    public NeighborhoodDto GetNeighborhoodById(Guid id);
    public void CreateNeighborhood(CreateNeighborhoodDto neighborhood);
    public void UpdateNeighborhood(UpdateNeighborhoodDto neighborhood,Guid id);
    public void DeleteNeighborhood(Guid id);
}

