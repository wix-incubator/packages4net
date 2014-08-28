using System;
using System.Collections.Generic;
using System.Net;

namespace com.openrest.packages
{
    public class PackagesException : ApplicationException
    {
        public PackagesException(Error error)
        {
            this.error = error;
        }

        public PackagesException(Error error, Exception cause)
            : base(cause.Message, cause)
        {
            this.error = error;
        }

        public Error Error
        {
            get
            {
                return error;
            }
        }

        private readonly Error error;
    }
}
