using System;
using System.Collections.Generic;

namespace com.openrest.packages
{
    public class Response<T>
    {
        public Error error;
        public T value;

        /** Empty constructor required for initialization from JSON-encoded string. */
        public Response() { }

        public Response(T value)
        {
            this.value = value;
        }
    }
}
