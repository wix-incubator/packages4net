using System;
using System.Collections.Generic;

namespace com.openrest.packages
{
    public class Request
    {
        public string type;

        protected Request(string type)
        {
            this.type = type;
        }
    }
}
