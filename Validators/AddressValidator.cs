using System;
using System.Collections.Generic;
using System.Text;
using fluent_validation_windowform.Models;
using FluentValidation;

namespace fluent_validation_windowform.Validators
{
    class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(address => address.Town).NotNull().NotEmpty();
            RuleFor(address => address.Country).NotNull().NotEmpty();
            RuleFor(address => address.Postcode).NotNull().NotEmpty();
        }
    }
}
