using System;
using System.Collections.Generic;
using System.Text;

namespace MyRecipeBook.Exceptions.ExceptionsBase
{
    public class ErrorOnValidationException : MyRecipeBookException
    {
        public IList<string> ErrorMessages { get; set; } = new List<string>();

        public ErrorOnValidationException(IList<string> errorMessages) {
            ErrorMessages = errorMessages;
        }
    }
}
