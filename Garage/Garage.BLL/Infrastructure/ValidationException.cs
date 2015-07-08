using System;

namespace Garage.BLL.Infrastructure
{
    class ValidationException : Exception
    {
        public string Property { get; protected set; }
        public ValidationException(string message, string property) : base(message)
        {
            Property = property;
        }
    }
}
