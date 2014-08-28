using System;
using System.Collections.Generic;

namespace com.openrest.packages
{
    public class DeletePackageRequest : Request
    {
        public const string TYPE = "package.delete";

        public string accessToken;
        public string projectId;
        public string packageId;

        /** Empty constructor required for initialization from JSON-encoded string. */
        public DeletePackageRequest()
            : base(TYPE)
        {
        }

        public DeletePackageRequest(string accessToken, string projectId, string packageId)
            : base(TYPE)
        {
            this.accessToken = accessToken;
            this.projectId = projectId;
            this.packageId = packageId;
        }
    }
}
