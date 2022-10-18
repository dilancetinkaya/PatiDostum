using FluentValidation;
using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Application.Validations;

public class NeighborhoodValidator : AbstractValidator<NeighborhoodDto>
{
    public NeighborhoodValidator()
    {
        RuleFor(x => x.DistrictId).NotEmpty();
        RuleFor(x => x.NeighborhoodName).NotEmpty();
        RuleFor(x => x.NeighborhoodKey).NotEmpty();

    }
}

