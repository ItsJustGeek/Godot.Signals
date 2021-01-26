namespace Godot {
    public static partial class Signals {
        public class Viewport : Node {
            /// <summary> Emitted when a <see cref="Godot.Control"/> node grabs keyboard focus. </summary>
            /// <remarks> [Args: <see cref="Godot.Control"/> node] </remarks>
            public const string GUIFocusChanged = "gui_focus_changed";

            /// <summary> Emitted when the size of the <see cref="Godot.Viewport"/> is changed, whether by <see cref="Godot.Viewport.SetSizeOverride(bool, Vector2?, Vector2?)"/>, resize of window, or some other means. </summary>
            public const string SizeChanged = "size_changed";
        }
    }
}
