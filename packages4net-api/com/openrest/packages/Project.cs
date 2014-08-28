using System;
using System.Collections.Generic;

namespace com.openrest.packages
{
    public class Project
    {
        /** Empty constructor required for initialization from JSON-encoded string. */
        public Project() { }

        public Project(string id, long? created, IList<Package> packages)
        {
            this.id = id;
            this.created = created;
            this.packages = packages;
        }

        public string id;
        public long? created;
        public IList<Package> packages = new List<Package>();
    }
}
