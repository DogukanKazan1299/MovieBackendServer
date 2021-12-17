using FluentValidation;
using Movie.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Business.ValidationRules.FluentValidation
{
    public class MovieValidator : AbstractValidator<Moviee>
    {
        public MovieValidator()
        {
            RuleFor(x => x.MovieName).NotEmpty().WithMessage("Film adı boş geçilemez");
            RuleFor(x => x.MovieName).MinimumLength(2).WithMessage("Film adı en az 2 karakter olmalı");
            RuleFor(x => x.MovieName).MaximumLength(50).WithMessage("Film adı max 50 karakter olmalı");
        }
    }
}
