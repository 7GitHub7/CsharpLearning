using FluentValidation;
using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardUI.Validators
{
    class PersonValidator : AbstractValidator<PersonModel>
    {
        public PersonValidator()
        {
            RuleFor(p => p.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is empty")
                .Length(2, 50).WithMessage("Length of ({TotalLength}) {PropertyName} Invalid ")
                .Must(BeAValidName).WithMessage("{PropertyName} contains invalid characters");
        }

        protected bool BeAValidName(string name) {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(Char.IsLetter);
                    
        }

    }
}
