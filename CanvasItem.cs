namespace Godot {
    public static partial class Signals {
        public class CanvasItem : Node {
            /// <summary> Emitted when the <see cref="Godot.CanvasItem"/> must redraw. This can only be connected realtime, as deferred will not allow drawing. </summary>
            public const string Draw = "draw";

            /// <summary> Emitted when becoming hidden. </summary>
            public const string Hide = "hide";

            /// <summary> Emitted when the item rect has changed. </summary>
            public const string ItemRectChanged = "item_rect_changed";

            /// <summary> Emitted when the visibility (hidden/visible) changes. </summary>
            public const string VisibilityChanged = "visibility_changed ";
        }
    }
}
