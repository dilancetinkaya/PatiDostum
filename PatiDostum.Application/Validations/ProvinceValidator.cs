using FluentValidation;
using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Application.Validations;

public class ProvinceValidator : AbstractValidator<ProvinceDto>
{
    public ProvinceValidator()
    {
        RuleFor(x => x.ProvinceName).NotEmpty();
        RuleFor(x => x.ProvinceKey).NotEmpty();


    }
}

