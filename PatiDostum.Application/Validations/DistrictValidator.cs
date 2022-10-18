using FluentValidation;
using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Application.Validations;

public class DistrictValidator : AbstractValidator<DistrictDto>
{
    public DistrictValidator()
    {
        RuleFor(x=>x.ProvinceId).NotEmpty();
        RuleFor(x=>x.DistrictKey).NotEmpty();
        RuleFor(x=>x.DistrictName).NotEmpty();
    }
}

