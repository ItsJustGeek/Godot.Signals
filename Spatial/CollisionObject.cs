namespace Godot {
    public static partial class Signals {
        public class CollisionObject : Spatial {
            /// <summary> Emitted when <see cref="Godot.CollisionObject._InputEvent(Object, Godot.InputEvent, Vector3, Vector3, int)"/> receives an event. See its description for details. </summary>
            /// <remarks> [Args: <see cref="Godot.Node"/> node, <see cref="Godot.InputEvent"/> event, <see cref="Godot.Vector3"/> clickPosition, <see cref="Godot.Vector3"/> clickNormal, <see cref="int"/> shapeIdx] </remarks>
            public const string InputEvent = "input_event";

            /// <summary> Emitted when the mouse pointer enters any of this object's shapes. </summary>            
            public const string MouseEntered = "mouse_entered";

            /// <summary> Emitted when the mouse pointer exits all this object's shapes. </summary>
            public const string MouseExited = "mouse_exited";
        }
    }
}
