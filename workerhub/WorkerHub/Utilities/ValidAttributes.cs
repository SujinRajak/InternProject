using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkerHub.Utilities
{
    public class ValidAttributes : ValidationAttribute
    {
        private readonly string _comparisonProperty;

        public ValidAttributes(string comparisonProperty)
        {
            _comparisonProperty = comparisonProperty;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ErrorMessage = ErrorMessageString;
           //startdate val
            var currentValue = (int)value;
            
            var property = validationContext.ObjectType.GetProperty(_comparisonProperty);
            

            if (property == null)
                throw new ArgumentException("Property with this name not found");

            //gets the enddate val 
            var comparisonValue = (int)property.GetValue(validationContext.ObjectInstance);
        
            if (comparisonValue >= currentValue)
                return new ValidationResult(ErrorMessage);

            return ValidationResult.Success;
        }
    }
}
