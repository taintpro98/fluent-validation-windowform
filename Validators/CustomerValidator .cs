using System;
using System.Collections.Generic;
using System.Text;
using fluent_validation_windowform.Models;
using FluentValidation;

namespace fluent_validation_windowform.Validators
{
    class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.Name).NotNull().NotEmpty().NotEqual("foo");
            RuleFor(customer => customer.Address).SetValidator(new AddressValidator());
        }
    }
}
