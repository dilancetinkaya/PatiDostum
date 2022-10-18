using FluentValidation;
using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Application.Validations;

public class SpeciesValidator : AbstractValidator<SpeciesDto>
{
    public SpeciesValidator()
    {
        RuleFor(x => x.SpeciesName).NotEmpty();
    }
}

