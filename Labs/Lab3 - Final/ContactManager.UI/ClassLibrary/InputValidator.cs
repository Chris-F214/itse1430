using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class InputValidator
    {
        public void Validate (IValidatableObject value)
        {
            Validator.ValidateObject(value, new ValidationContext(value));
        }
    }
}
