using FluentValidation;
using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Application.Validations;

    public class AdKindValidator:AbstractValidator<AdKindDto>
    {
    public AdKindValidator()
    {
        RuleFor(x=>x.AdName).NotEmpty().WithMessage("Ad Name cannot empty");
    }
    }

