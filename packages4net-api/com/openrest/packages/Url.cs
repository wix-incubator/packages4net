using System;

namespace com.openrest.packages
{
    public class Url
    {
        /** Empty constructor required for initialization from JSON-encoded string. */
        public Url() { }

        public Url(string url)
        {
            this.url = url;
        }

        public string url;
    }
}
