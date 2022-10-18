using FluentValidation;
using PatiDostum.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Application.Validations;

public class MessageValidator : AbstractValidator<MessageDto>
{
    public MessageValidator()
    {
        RuleFor(x=>x.ReceiverId).NotEmpty();
        RuleFor(x=>x.SenderId).NotEmpty();
        RuleFor(x=>x.RepliesId).NotEmpty();

    }
}

