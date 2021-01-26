namespace Godot {
    public static partial class Signals {
        public class ARVRAnchor : Spatial {
            /// <summary>
            /// Emitted when the mesh associated with the anchor changes or when one becomes available. <br/>
            /// This is especially important for topology that is constantly being mesh_updated.
            /// </summary>
            /// <remarks> [Args: <see cref="Mesh"/> mesh] </remarks>
            public const string MeshUpdated = "mesh_updated";
        }
    }
}
