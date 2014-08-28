using System;
using System.Collections.Generic;

namespace com.openrest.packages
{
    public class CreateProjectRequest : Request
    {
        public const string TYPE = "project.create";

        public string accessToken;
        public string projectId;

        /** Empty constructor required for initialization from JSON-encoded string. */
        public CreateProjectRequest()
            : base(TYPE)
        {
        }

        public CreateProjectRequest(string accessToken, string projectId)
            : base(TYPE)
        {
            this.accessToken = accessToken;
            this.projectId = projectId;
        }
    }
}
