using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId == MembershipType.Unkonwn || 
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.DateOfBirth == null)
                return new ValidationResult("Date of Birth is Required");

            var age = DateTime.Today.Year - customer.DateOfBirth.Value.Year;

            return (age>= Customer.AgeLimit)
                ? ValidationResult.Success
                : new ValidationResult("Customer shuld be at least "+ Customer.AgeLimit+ " years old to go on a membership");

        }
    }
}