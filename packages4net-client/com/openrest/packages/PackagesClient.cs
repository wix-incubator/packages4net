using System;
using System.Collections.Generic;

namespace com.openrest.packages
{
    /** The Openrest Packages client. */
    public class PackagesClient
    {
        private static readonly Uri ENDPOINT = new Uri("https://packages.openrest.com/v1.0");
        private readonly PackagesProtocol protocol;

        public PackagesClient()
        {
            protocol = new PackagesProtocol();

            // @see http://stackoverflow.com/questions/566437/http-post-returns-the-error-417-expectation-failed-c
            System.Net.ServicePointManager.Expect100Continue = false;
        }

        public T Request<T>(Request request)
        {
            return protocol.Post<T>(ENDPOINT, request);
        }
    }
}
