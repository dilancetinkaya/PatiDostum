using AutoMapper;
using PatiDostum.Core.Entities;
using PatiDostum.Core.IRepositories;
using PatiDostum.Infrastructure.Dto;
using PatiDostum.Infrastructure.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Application.Services;

public class AdKindService : IAdKindService
{
    private readonly IAdKindRepository _adKindRepository;
    private readonly IMapper _mapper;
    public AdKindService(IAdKindRepository adKindRepository, IMapper mapper)
    {
        _adKindRepository = adKindRepository;
        _mapper = mapper;
    }
    public void CreateAdKind(CreateAdKindDto adKind)
    {
        var createdAdKind = _mapper.Map<AdKindEntity>(adKind);
        _adKindRepository.CreateAdKind(createdAdKind);
    }

    public void DeleteAdKind(Guid id)
    {
        _adKindRepository.DeleteAdKind(id);
    }

    public List<AdKindDto> GetAdKind()
    {
        var adKinds = _adKindRepository.GetAdKind();
        var adKindsDto = _mapper.Map<List<AdKindDto>>(adKinds);
        return adKindsDto;
    }

    public AdKindDto GetAdKindById(Guid id)
    {
        var adKind = _adKindRepository.GetAdKindById(id);
        var adKindDto = _mapper.Map<AdKindDto>(adKind);
        return adKindDto;
    }

    public void UpdateAdKind(UpdateAdKindDto adKind,Guid id)
    {
        var updatedAdKind = _mapper.Map<AdKindEntity>(adKind);
        updatedAdKind.Id = id;  
        _adKindRepository.UpdateAdKind(updatedAdKind);
    }
}

