using System;

namespace com.openrest.packages
{
    public class Error
    {
	    public const String ERROR_INVALID_REQUEST = "invalid_request";
	    public const String ERROR_INVALID_DATA = "invalid_data";
	    public const String ERROR_INTERNAL = "internal";
	    public const String ERROR_SECURITY = "security";
	    public const String ERROR_TIMEOUT = "timeout";
	    public const String ERROR_CONFLICT = "conflict";
        public const String ERROR_NOT_FOUND = "not_found";

        /** Empty constructor required for initialization from JSON-encoded string. */
        public Error() { }

        public Error(string code, string message)
        {
            this.code = code;
            this.message = message;
        }

        public string code;
        public string message;
    }
}
