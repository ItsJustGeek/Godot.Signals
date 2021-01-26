namespace Godot {
    public static partial class Signals {
        public class GraphEdit : Control {
            /// <summary> Emitted at the beginning of a <see cref="Godot.GraphNode"/> movement. </summary>
            public const string BeginNodeMove = "_begin_node_move";

            /// <summary> Emitted at the end of a <see cref="Godot.GraphNode"/> movement. </summary>
            public const string EndNodeMove = "_end_node_move";

            /// <summary> Emitted when user dragging connection from input port into empty space of the graph. </summary>
            /// <remarks> [Args: <see cref="System.string"/> to, <see cref="System.int"/> toSlot, <see cref="Godot.Vector2"/> releasePosition] </remarks>
            public const string ConnectionFromEmpty = "connection_from_empty";

            /// <summary> Emitted to the GraphEdit when the connection between the from_slot slot of the from GraphNode and the to_slot slot of the to GraphNode is attempted to be created. </summary>
            /// <remarks> [Args: <see cref="System.string"/> from, <see cref="System.int"/> fromSlot, <see cref="System.string"/> to, <see cref="System.int"/> toSlot] </remarks>
            public const string ConnectionRequest = "connection_request";

            /// <summary> Emitted when user dragging connection from output port into empty space of the graph. </summary>
            /// <remarks> [Args: <see cref="System.string"/> from, <see cref="System.int"/> fromSlot, <see cref="Godot.Vector2"/> releasePosition] </remarks>
            public const string ConnectionToEmpty = "connection_to_empty";

            /// <summary> Emitted when the user presses Ctrl + C. </summary>
            public const string CopyNodesRequest = "copy_nodes_request";

            /// <summary> Emitted when a GraphNode is attempted to be removed from the GraphEdit. </summary>
            public const string DeleteNodesRequest = "delete_nodes_request";

            /// <summary> Emitted to the GraphEdit when the connection between from_slot slot of from GraphNode and to_slot slot of to GraphNode is attempted to be removed. </summary>
            /// <remarks> [Args: <see cref="System.string"/> from, <see cref="System.int"/> fromSlot, <see cref="System.string"/> to, <see cref="System.int"/> toSlot] </remarks>
            public const string DisconnectionRequest = "disconnection_request";

            /// <summary> Emitted when a GraphNode is attempted to be duplicated in the GraphEdit. </summary>
            public const string DuplicateNodesRequest = "duplicate_nodes_request";

            /// <summary> Emitted when a GraphNode is selected. </summary>
            /// <remarks> [Args: <see cref="Godot.Node"/> node] </remarks>
            public const string NodeSelected = "node_selected";

            /// <summary> Emitted when a GraphNode is unselected. </summary>
            /// <remarks> [Args: <see cref="Godot.Node"/> node] </remarks>
            public const string NodeUnselected = "node_unselected";

            /// <summary> Emitted when the user presses Ctrl + V. </summary>
            public const string PasteNodesRequest = "paste_nodes_request";

            /// <summary> Emitted when a popup is requested. Happens on right-clicking in the GraphEdit. position is the position of the mouse pointer when the signal is sent. </summary>
            /// <remarks> [Args: <see cref="Godot.Vector2"/> position] </remarks>
            public const string PopupRequest = "popup_request";

            /// <summary> Emitted when the scroll offset is changed by the user. It will not be emitted when changed in code. </summary>
            /// <remarks> [Args: <see cref="Godot.Vector2"/> offset] </remarks>
            public const string ScrollOffsetChanged = "scroll_offset_changed";
        }
    }
}
