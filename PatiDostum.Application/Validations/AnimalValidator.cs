using FluentValidation;
using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Application.Validations;

public class AnimalValidator : AbstractValidator<AnimalDto>
{
    public AnimalValidator()
    {
        RuleFor(x => x.SpeciesId).NotEmpty();

        RuleFor(x => x.Gender).NotEmpty();
    }
}

