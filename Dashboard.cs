using fluent_validation_windowform.Models;
using fluent_validation_windowform.Validators;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fluent_validation_windowform
{
    public partial class Dashboard : Form
    {
        BindingList<string> errors = new BindingList<string>();
        public Dashboard()
        {
            InitializeComponent();
            errorBox.DataSource = errors;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            errors.Clear();
            
            Address address = new Address() { 
                Town = townBox.Text,
                Country = countryBox.Text,
                Postcode = postcodeBox.Text
            };
            Customer customer = new Customer() { 
                Name = nameBox.Text,
                Address = address
            };

            CustomerValidator validator = new CustomerValidator();

            ValidationResult results = validator.Validate(customer);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    errors.Add($"{failure.PropertyName}: {failure.ErrorMessage}");
                }
                //string allmessages = results.ToString("~");
            }

        }
    }
}
