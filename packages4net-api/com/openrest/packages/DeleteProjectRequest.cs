using System;
using System.Collections.Generic;

namespace com.openrest.packages
{
    public class DeleteProjectRequest : Request
    {
        public const string TYPE = "project.delete";

        public string accessToken;
        public string projectId;

        /** Empty constructor required for initialization from JSON-encoded string. */
        public DeleteProjectRequest()
            : base(TYPE)
        {
        }

        public DeleteProjectRequest(string accessToken, string projectId)
            : base(TYPE)
        {
            this.accessToken = accessToken;
            this.projectId = projectId;
        }
    }
}
