using System;
using System.Collections.Generic;

namespace com.openrest.packages
{
    public class Blob
    {
        /** Empty constructor required for initialization from JSON-encoded string. */
        public Blob() { }

        public Blob(string id, string url, string imageUrl)
        {
            this.id = id;
            this.url = url;
            this.imageUrl = imageUrl;
        }

        public string id;
        public string url;
        public string imageUrl;
    }
}
