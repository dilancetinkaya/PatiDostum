using FluentValidation;
using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Application.Validations;

    public class AdvertValidator:AbstractValidator<AdvertDto>
    {
    public AdvertValidator()
    {
        RuleFor(x=>x.AdKindId).NotEmpty();
        RuleFor(x=>x.AddressId).NotEmpty();
        RuleFor(x=>x.AnimalId).NotEmpty();
        RuleFor(x=>x.MessageId).NotEmpty();
        RuleFor(x=>x.UserId).NotEmpty();
    }
    }

