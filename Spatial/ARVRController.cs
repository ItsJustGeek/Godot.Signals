namespace Godot {
    public static partial class Signals {
        public class ARVRController : Spatial {
            /// <summary> Emitted when a button on this controller is pressed. </summary>
            /// <remarks> [Args: <see cref="int"/> button] </remarks>
            public const string ButtonPressed = "button_pressed";

            /// <summary> Emitted when a button on this controller is released. </summary>
            /// <remarks> [Args: <see cref="int"/> button] </remarks>
            public const string ButtonReleased = "button_release";

            /// <summary>
            /// Emitted when the mesh associated with the controller changes or when one becomes available. <br/>
            /// Generally speaking this will be a static mesh after becoming available.
            /// </summary>
            /// <remarks> [Args: <see cref="int"/> button] </remarks>
            public const string MeshUpdated = "mesh_updated";
        }
    }
}
