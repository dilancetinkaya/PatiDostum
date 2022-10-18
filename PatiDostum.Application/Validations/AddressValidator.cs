using FluentValidation;
using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Application.Validaitons;

public class AddressValidator : AbstractValidator<AddressDto>
{
    public AddressValidator()
    {
        RuleFor(x => x.DistrictId).NotEmpty().WithMessage("district id cannot null");
        RuleFor(x => x.ProvinceId).NotEmpty().WithMessage("province id cannot null");
        RuleFor(x => x.NeighborhoodId).NotEmpty().WithMessage("neighborhood id cannot null");
    }
}

