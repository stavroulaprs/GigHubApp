using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace GigHubApplication.CustomAnnotations
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime datetime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "dd MMM yyyy", 
                DateTimeFormatInfo.InvariantInfo, 
                DateTimeStyles.None, out datetime);

            return (isValid && datetime > DateTime.Now);
                //? ValidationResult.Success
                //: new ValidationResult("The date must be later than today");
        }
    }
}