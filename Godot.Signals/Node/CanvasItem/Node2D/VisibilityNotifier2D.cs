namespace Godot {
    public static partial class Signals {
        public class VisibilityNotifier2D : Node2D {


            /// <summary> Emitted when the <see cref="Godot.VisibilityNotifier2D"/> enters the screen. </summary>
            public const string ScreenEntered = "screen_entered";

            /// <summary> Emitted when the <see cref="Godot.VisibilityNotifier2D"/> exits the screen. </summary>
            public const string ScreenExited = "screen_exited";

            /// <summary> Emitted when the <see cref="Godot.VisibilityNotifier2D"/> enters a <see cref="Godot.Viewport"/>'s view. </summary>
            /// <remarks> [Args: <see cref="Godot.Viewport"/> viewport] </remarks>
            public const string ViewportEntered = "viewport_entered";

            /// <summary> Emitted when the <see cref="Godot.VisibilityNotifier2D"/> exits a <see cref="Godot.Viewport"/>'s view. </summary>
            /// <remarks> [Args: <see cref="Godot.Viewport"/> viewport] </remarks>
            public const string ViewportExited = "viewport_exited";
        }
    }
}
