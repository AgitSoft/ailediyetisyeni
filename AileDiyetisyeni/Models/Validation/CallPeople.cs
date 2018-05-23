using AileDiyetisyeni.Validation;
using FluentValidation.Attributes;

namespace AileDiyetisyeni.Models
{
    [Validator(typeof(UserValidator))]
    public partial class CallPeople
    {
        public string FullName
        {
            get
            {
                return Name + " " + Surname;
            }
        }
    }
}