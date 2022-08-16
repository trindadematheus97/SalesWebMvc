using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class DbcConcurrencyException : ApplicationException
    {
         public DbcConcurrencyException(string message) : base(message)
        {

        }
    }
}
