using System;
using System.Collections.Generic;

namespace com.openrest.packages
{
    public class GetPackageUploadUrlRequest : Request
    {
        public const string TYPE = "package.uploadurl";

        public string accessToken;
        public string projectId;
        public string packageId;

        /** Empty constructor required for initialization from JSON-encoded string. */
        public GetPackageUploadUrlRequest()
            : base(TYPE)
        {
        }

        public GetPackageUploadUrlRequest(string accessToken, string projectId, string packageId)
            : base(TYPE)
        {
            this.accessToken = accessToken;
            this.projectId = projectId;
            this.packageId = packageId;
        }
    }
}
