using FluentValidation;
using Movie.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Business.ValidationRules.FluentValidation
{
    public class PlayerValidator : AbstractValidator<Player>
    {
        public PlayerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Oyuncu adı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Oyuncu soyadı boş geçilemez");
        }
    }
}
