namespace Godot {
    public static partial class Signals {
        public class GraphNode : Container {
            /// <summary>
            /// Emitted when the <see cref="Godot.GraphNode"/> is requested to be closed.
            /// Happens on clicking the close button (see <see cref="Godot.GraphNode.ShowClose"/>). 
            /// </summary>
            public const string CloseRequest = "close_request";

            /// <summary> Emitted when the GraphNode is dragged. </summary>
            /// <remarks> [Args: <see cref="Godot.Vector2"/> from, <see cref="Godot.Vector2"/> to]</remarks>
            public const string Dragged = "dragged";

            /// <summary> Emitted when the <see cref="Godot.GraphNode"/> is moved. </summary>
            public const string OffsetChanged = "offset_changed";

            /// <summary>
            /// Emitted when the <see cref="Godot.GraphNode"/> is requested to be displayed over other ones. 
            /// Happens on focusing (clicking into) the <see cref="Godot.GraphNode"/>. 
            /// </summary>
            public const string RaiseRequest = "raise_request";

            /// <summary>
            /// Emitted when the <see cref="Godot.GraphNode"/> is requested to be resized.
            /// Happens on dragging the resizer handle (see <see cref="Godot.GraphNode.Resizable"/>).
            /// </summary>
            /// <remarks> [Args: <see cref="Godot.Vector2"/> newMinSize] </remarks>
            public const string ResizeRequest = "resize_request";
        }
    }
}
