using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class TravelValidator : AbstractValidator<Travel>
    {
        public TravelValidator()
        {
            RuleFor(t => t.TravelName).MinimumLength(3).WithMessage("en az 3 simvol olmalidir");
            RuleFor(t => t.TravelName).NotEmpty().WithMessage("Bosh ola bilmez");
            RuleFor(t => t.Price).GreaterThan(0).WithMessage("Sifirdan boyuk olmalidir");
        }

    }
}
