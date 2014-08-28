using System;
using System.Collections.Generic;

namespace com.openrest.packages
{
    public class GetPackageRequest : Request
    {
        public const string TYPE = "package.get";

        public string projectId;
        public string packageId;

        /** Empty constructor required for initialization from JSON-encoded string. */
        public GetPackageRequest()
            : base(TYPE)
        {
        }

        public GetPackageRequest(string projectId, string packageId)
            : base(TYPE)
        {
            this.projectId = projectId;
            this.packageId = packageId;
        }
    }
}
