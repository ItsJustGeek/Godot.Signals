namespace Godot {
    public static partial class Signals {
        public class RigidBody : CollisionObject {
            /// <summary>
            /// Emitted when a body enters into contact with this one. <br/>
            /// Requires <see cref="Godot.RigidBody.ContactMonitor"/> to be set to true and <see cref="Godot.RigidBody.ContactsReported"/> to be set high enough to detect all the collisions. 
            /// </summary>
            /// <remarks> [Args: <see cref="Godot.Node"/> body] </remarks>
            public const string BodyEntered = "body_entered";

            /// <summary>
            /// Emitted when a body shape exits contact with this one. <br/>
            /// Requires <see cref="Godot.RigidBody.ContactMonitor"/> to be set to true and <see cref="Godot.RigidBody.ContactsReported"/> to be set high enough to detect all the collisions. 
            /// </summary>
            /// <remarks> [Args: <see cref="Godot.Node"/> body] </remarks>
            public const string BodyExited = "body_exited";

            /// <summary>
            /// Emitted when a body enters into contact with this one. <br/>
            /// Requires <see cref="Godot.RigidBody.ContactMonitor"/> to be set to true and <see cref="Godot.RigidBody.ContactsReported"/> to be set high enough to detect all the collisions. <br/>
            /// This signal not only receives the body that collided with this one, but also its <see cref="Godot.RID"/> (bodyID), the shape index from the colliding body (bodyShape), and the shape index from this body (localShape) the other body collided with.
            /// </summary>
            /// <remarks> [Args: <see cref="int"/> bodyID, <see cref="Godot.Node"/> body, <see cref="int"/> bodyShape, <see cref="int"/> localShape] </remarks>
            public const string BodyShapeEntered = "body_shape_entered";

            /// <summary>
            /// Emitted when a body exits contact with this one. <br/>
            /// Requires <see cref="Godot.RigidBody.ContactMonitor"/> to be set to true and <see cref="Godot.RigidBody.ContactsReported"/> to be set high enough to detect all the collisions. <br/>
            /// This signal not only receives the body that stopped colliding with this one, but also its <see cref="Godot.RID"/> (bodyID), the shape index from the colliding body (bodyShape), and the shape index from this body (localShape) the other body collided with.
            /// </summary>
            /// <remarks> [Args: <see cref="int"/> bodyID, <see cref="Godot.Node"/> body, <see cref="int"/> bodyShape, <see cref="int"/> localShape] </remarks>
            public const string BodyShapeExited = "body_shape_exited";

            /// <summary>
            /// Emitted when the physics engine changes the body's sleeping state. <br/>
            /// Changing the value <see cref="Godot.RigidBody.Sleeping"/> will not trigger this signal. It is only emitted if the sleeping state is changed by the physics engine or <see cref="Godot.Object.EmitSignal(string, object[])"/>(<see cref="RigidBody.SleepingStateChanged"/>) is used.
            /// </summary>
            public const string SleepingStateChanged = "sleeping_state_changed";
        }
    }
}
