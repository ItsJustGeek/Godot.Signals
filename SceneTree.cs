namespace Godot {
    public static partial class Signals {
        public class SceneTree : MainLoop {
            /// <summary> Emitted whenever this SceneTree’s network_peer successfully connected to a server.  Only emitted on clients. </summary>
            public const string ConnectedToServer = "connected_to_server";

            /// <summary> Emitted whenever this SceneTree’s network_peer fails to establish a connection to a server.  Only emitted on clients. </summary>
            public const string ConnectionFailed = "connection_failed";

            /// <summary> Emitted when files are dragged from the OS file manager and dropped in the game window.The arguments are a list of file paths and the identifier of the screen where the drag originated. </summary>
            /// <remarks>[Args: PackedStringArray, int] </remarks>
            public const string FilesDropped = "files_dropped";

            /// <summary> Emitted whenever global menu item is clicked. </summary>
            /// <remarks> [Args: Variant, Variant] </remarks>
            public const string GlobalMenuAction = "global_menu_action";

            /// <summary> Emitted immediately before Node._process is called on every node in the SceneTree. </summary>
            public const string IdleFrame = "idle_frame";

            /// <summary> Emitted whenever this SceneTree’s network_peer connects with a new peer.ID is the peer ID of the new peer.Clients get notified when other clients connect to the same server.  Upon connecting to a server, a client also receives this signal for the server(with ID being 1). </summary>
            /// <remarks> [Args: int] </remarks>
            public const string NetworkPeerConnected = "network_peer_connected";

            /// <summary> Emitted whenever this SceneTree’s network_peer disconnects from a peer.Clients get notified when other clients disconnect from the same server. </summary>
            /// <remarks> [Args: int] </remarks>
            public const string NetworkPeerDisconnected = "network_peer_disconnected";

            /// <summary> Emitted whenever a node is added to the SceneTree. </summary>
            /// <remarks> [Args: Node] </remarks>
            public const string NodeAdded = "node_added";

            /// <summary> Emitted when a node’s configuration changed.Only emitted in tool mode. </summary>
            /// <remarks> [Args: Node] </remarks>
            public const string NodeConfigurationWarningChanged = "node_configuration_warning_changed";

            /// <summary> Emitted whenever a node is removed from the SceneTree. </summary>
            /// <remarks> [Args: Node] </remarks>
            public const string NodeRemoved = "node_removed";

            /// <summary> Emitted whenever a node is renamed. </summary>
            /// <remarks> [Args: Node] </remarks>
            public const string NodeRenamed = "node_renamed";

            /// <summary> Emitted immediately before Node._physics_process is called on every node in the SceneTree. </summary>
            public const string PhysicsFrame = "physics_frame";

            /// <summary> Emitted when the screen resolution (fullscreen) or window size (windowed) changes. </summary>
            public const string ScreenResized = "screen_resized";

            /// <summary> Emitted whenever this SceneTree’s network_peer disconnected from server.Only emitted on clients. </summary>
            public const string ServerDisconnected = "server_disconnected";

            /// <summary> Emitted whenever the SceneTree hierarchy changed (children being moved or renamed, etc.). </summary>
            public const string TreeChanged = "tree_changed";
        }
    }
}
