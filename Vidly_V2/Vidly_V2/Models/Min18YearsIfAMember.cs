using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly_V2.Models
{
    public class Min18YearsIfAMember:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //casting the object instace to customer type
            var customer = (Customer)validationContext.ObjectInstance;

            if(customer.MembershipTypeId == MembershipType.Unknown
                || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if(customer.BirthDate == null)
                return new ValidationResult("BirthDate is requeried");

            var age = DateTime.Today.Year - customer.BirthDate.Value.Year;

            return (age > 18) ? ValidationResult.Success : new ValidationResult("Customer should be at least 18 years old");

        }
    }
}