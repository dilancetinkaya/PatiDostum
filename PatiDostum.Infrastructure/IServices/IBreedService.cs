using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.IServices;

public interface IBreedService
{
    public List<BreedDto> GetBreed();
    public BreedDto GetBreedById(Guid id);
    public bool CreateBreed(CreateBreedDto breed);
    public bool UpdateBreed(UpdateBreedDto breed,Guid id);
    public void DeleteBreed(Guid id);
}

