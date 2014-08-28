using System;
using System.Collections.Generic;

namespace com.openrest.packages
{
    public class GetProjectRequest : Request
    {
        public const string TYPE = "project.get";

        public string projectId;

        /** Empty constructor required for initialization from JSON-encoded string. */
        public GetProjectRequest()
            : base(TYPE)
        {
        }

        public GetProjectRequest(string projectId)
            : base(TYPE)
        {
            this.projectId = projectId;
        }
    }
}
