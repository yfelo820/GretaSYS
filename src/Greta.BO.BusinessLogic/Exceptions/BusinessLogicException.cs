using System;

namespace Greta.BO.BusinessLogic.Exceptions
{
    public sealed class BusinessLogicException : Exception
    {
        public BusinessLogicException(string message) : base(message)
        {
        }
    }
}
