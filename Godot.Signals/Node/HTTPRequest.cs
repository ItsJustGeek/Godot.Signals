namespace Godot {
    public static partial class Signals {
        public class HTTPRequest : Node {
            /// <summary> Emitted when a request is completed. </summary>
            /// <remarks> [Args: <see cref="int"/> result, <see cref="int"/> responseCode, <see cref="string[]"/> headers, <see cref="byte[]"/> body] </remarks>
            public const string RequestCompleted = "request_completed";
        }
    }
}
