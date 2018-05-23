using FluentValidation;

namespace AileDiyetisyeni.Validation
{
    public class UserValidator : AbstractValidator<Models.CallPeople>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Adınızı yazabilir misiniz :)");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Adınızı en fazla 20 karakter olarak yazabilirsiniz.");
            RuleFor(x => x.Surname).NotNull().WithMessage("Soy Adınızı yazabilir misiniz :)");
            RuleFor(x => x.MailAdress).NotNull().WithMessage("Mail adresinizi yazabilir misiniz :)");
            RuleFor(x => x.MailAdress).EmailAddress().WithMessage("Mail adresinizin formatını kontol eder misiniz :)");
            RuleFor(x => x.Phone).NotNull().WithMessage("Telefonunuzu yazabilir misiniz :)")
                    .Length(11).WithMessage("Lütfen 11 karakterden fazla girmeyiniz!");

        }
    }
}