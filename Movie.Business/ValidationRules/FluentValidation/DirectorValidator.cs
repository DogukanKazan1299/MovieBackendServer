using FluentValidation;
using Movie.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Business.ValidationRules.FluentValidation
{
    public class DirectorValidator : AbstractValidator<Director>
    {
        public DirectorValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Yönetmen adı boş geçilemez");
        }
    }
}
