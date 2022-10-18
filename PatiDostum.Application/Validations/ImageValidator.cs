using FluentValidation;
using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Application.Validations;

public class ImageValidator : AbstractValidator<ImageDto>
{
    public ImageValidator()
    {
        RuleFor(x=>x.AdId).NotEmpty();
        RuleFor(x=>x.ImgPath).NotEmpty();
    }
}

