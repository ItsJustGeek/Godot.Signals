namespace Godot {
    public static partial class Signals {
        public class CollisionObject2D : Spatial {
            /// <summary>
            /// Emitted when <see cref="Godot.CollisionObject._InputEvent(Object, Godot.InputEvent, Vector3, Vector3, int)"/> occurs. <br/>
            /// Requires <see cref="Godot.CollisionObject2D.InputPickable"/> to be true and at least one collision_layer bit to be set.
            /// </summary>
            /// <remarks> [Args: <see cref="Godot.Node"/> node, <see cref="Godot.InputEvent"/> event, <see cref="Godot.Vector3"/> clickPosition, <see cref="Godot.Vector3"/> clickNormal, <see cref="int"/> shapeIdx] </remarks>
            public const string InputEvent = "input_event";

            /// <summary>
            /// Emitted when the mouse pointer enters any of this object's shapes. <br/> 
            /// Requires <see cref="Godot.CollisionObject2D.InputPickable"/> to be true and at least one collision_layer bit to be set. 
            /// </summary>            
            public const string MouseEntered = "mouse_entered";

            /// <summary>
            /// Emitted when the mouse pointer exits all this object's shapes. <br/>
            /// Requires <see cref="Godot.CollisionObject2D.InputPickable"/> to be true and at least one collision_layer bit to be set. 
            /// </summary>
            public const string MouseExited = "mouse_exited";
        }
    }
}
