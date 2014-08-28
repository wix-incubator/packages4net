using System;
using System.Collections.Generic;

namespace com.openrest.packages
{
    public class CreatePackageRequest : Request
    {
        public const string TYPE = "package.create";

        public string accessToken;
        public string projectId;
        public string packageId;

        /** Empty constructor required for initialization from JSON-encoded string. */
        public CreatePackageRequest()
            : base(TYPE)
        {
        }

        public CreatePackageRequest(string accessToken, string projectId, string packageId)
            : base(TYPE)
        {
            this.accessToken = accessToken;
            this.projectId = projectId;
            this.packageId = packageId;
        }
    }
}
