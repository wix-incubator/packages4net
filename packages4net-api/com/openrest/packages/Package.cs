using System;
using System.Collections.Generic;

namespace com.openrest.packages
{
    public class Package
    {
        /** Empty constructor required for initialization from JSON-encoded string. */
        public Package() { }

        public Package(string id, long? created, IDictionary<string, Blob> blobs)
        {
            this.id = id;
            this.created = created;
            this.blobs = blobs;
        }

        public string id;
        public long? created;
        public IDictionary<string, Blob> blobs = new Dictionary<string, Blob>();
    }
}
