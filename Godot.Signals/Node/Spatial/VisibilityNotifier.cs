namespace Godot {
    public static partial class Signals {
        public class VisibilityNotifier : Spatial {
            /// <summary> Emitted when the VisibilityNotifier enters a Camera’s view. </summary>
            /// <remarks> [Args: <see cref="Godot.Camera"/> camera] </remarks>
            public const string CameraEntered = "camera_entered";

            /// <summary> Emitted when the VisibilityNotifier exits a Camera’s view. </summary>
            /// <remarks> [Args: <see cref="Godot.Camera"/> camera] </remarks>
            public const string CameraExited = "camera_exited";

            /// <summary> Emitted when the VisibilityNotifier enters the screen. </summary>
            public const string ScreenEntered = "screen_entered";

            /// <summary> Emitted when the VisibilityNotifier exits the screen. </summary>
            public const string ScreenExited = "screen_exited";
        }
    }
}
