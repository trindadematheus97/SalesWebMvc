using System;
using System.Runtime.Serialization;

namespace SalesWebMvc.Controllers
{
    [Serializable]
    internal class DbcConcurrencyExcption : Exception
    {
        public DbcConcurrencyExcption()
        {
        }

        public DbcConcurrencyExcption(string message) : base(message)
        {
        }

        public DbcConcurrencyExcption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DbcConcurrencyExcption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}