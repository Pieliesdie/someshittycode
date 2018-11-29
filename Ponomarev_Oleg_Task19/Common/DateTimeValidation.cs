using System;
using System.ComponentModel.DataAnnotations;

namespace Common
{
    class DateTimeValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                if(((DateTime)value)<DateTime.Now
                    && ((DateTime)value).Year > (DateTime.Now.Year - 150))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
