namespace Godot {
    public static partial class Signals {
        public class Node : GodotObject {
            /// <summary> Emitted when the node is ready. </summary>
            public const string Ready = "ready";

            /// <summary> Emitted when the node is renamed. </summary>
            public const string Renamed = "renamed";

            /// <summary> Emitted when the node enters the tree. </summary>
            public const string TreeEntered = "tree_entered";

            /// <summary> Emitted after the node exits the tree and is no longer active. </summary>
            public const string TreeExited = "tree_exited";

            /// <summary> Emitted when the node is still active but about to exit the tree.This is the right place for de-initialization (or a “destructor”, if you will). </summary>
            public const string TreeExiting = "tree_exiting";
        }
    }
}
