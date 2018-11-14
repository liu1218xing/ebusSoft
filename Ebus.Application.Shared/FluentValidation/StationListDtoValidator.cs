using Ebus.Application.Shared.Stations.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebus.Application.Shared.FluentValidation
{
    public class StationListDtoValidator : AbstractValidator<StationListDto>
    {
        public StationListDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .WithName("站点名称")
                .WithMessage("{PropertyName}是必填的")
                .MaximumLength(50)
                .WithMessage("{PropertyName}的最大长度是{MaxLength}");
           
        }
    }
}
