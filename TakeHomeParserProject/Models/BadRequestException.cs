using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeParserProject.Models
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string userFriendlyErrorMessage) : base(userFriendlyErrorMessage)
        {
            
        }
    }
}
