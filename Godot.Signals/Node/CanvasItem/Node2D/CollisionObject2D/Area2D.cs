namespace Godot {
    public static partial class Signals {
        public class Area2D : CollisionObject2D {
            /// <summary> Emitted when another <see cref="Godot.Area2D"/> enters. </summary>
            /// <remarks> [Args: <see cref="Godot.Area2D"/> area] </remarks>
            public const string AreaEntered = "area_entered";

            /// <summary> Emitted when another <see cref="Godot.Area2D"/> exits. </summary>
            /// <remarks> [Args: <see cref="Godot.Area2D"/> area] </remarks>
            public const string AreaExited = "area_exited";

            /// <summary> 
            /// Emitted when another <see cref="Godot.Area2D"/> enters, reporting which areas overlapped. <br/>
            /// shape_owner_get_owner(shape_find_owner(shape)) returns the parent object of the owner of the <see cref="Godot.Shape"/>. 
            /// </summary>
            /// <remarks> [Args: <see cref="int"/> areaID, <see cref="Godot.Area2D"/> area, <see cref="int"/> areaShape, <see cref="int"/> selfShape] </remarks>
            public const string AreaShapeEntered = "area_shape_entered";

            /// <summary> Emitted when another <see cref="Godot.Shape"/> exits, reporting which areas were overlapping. </summary>
            /// <remarks> [Args: <see cref="int"/> areaID, <see cref="Godot.Area2D"/> area, <see cref="int"/> areaShape, <see cref="int"/> selfShape] </remarks>
            public const string AreaShapeExited = "area_shape_exited";

            /// <summary> 
            /// Emitted when a physics body enters. <br/>
            /// The body argument can either be a <see cref="Godot.PhysicsBody2D"/> or a <see cref="Godot.TileMap"/> instance (while TileMaps are not physics body themselves, they register their tiles with collision shapes as a virtual physics body).
            /// </summary>
            /// <remarks> [Args: <see cref="Godot.Node"/> body] </remarks>
            public const string BodyEntered = "body_entered";


            /// <summary> 
            /// Emitted when a physics body exits. <br/>
            /// The body argument can either be a <see cref="Godot.PhysicsBody2D"/> or a <see cref="Godot.TileMap"/> instance (while TileMaps are not physics body themselves, they register their tiles with collision shapes as a virtual physics body).
            /// </summary>
            /// <remarks> [Args: <see cref="Godot.Node"/> body] </remarks>
            public const string BodyExited = "body_exited";

            /// <summary> 
            /// Emitted when a physics body enters, reporting which shapes overlapped. <br/>
            /// The body argument can either be a <see cref="Godot.PhysicsBody2D"/> or a <see cref="Godot.TileMap"/> instance (while TileMaps are not physics body themselves, they register their tiles with collision shapes as a virtual physics body).
            /// </summary>
            /// <remarks> [Args: <see cref="int"/> bodyID, <see cref="Godot.Node"/> body, <see cref="int"/> bodyShape, <see cref="int"/> areaShape] </remarks>
            public const string BodyShapeEntered = "body_shape_entered";

            /// <summary> 
            /// Emitted when a physics body exits, reporting which shapes were overlapping. <br/>
            /// The body argument can either be a <see cref="Godot.PhysicsBody2D"/> or a <see cref="Godot.TileMap"/> instance (while TileMaps are not physics body themselves, they register their tiles with collision shapes as a virtual physics body).
            /// </summary>
            /// <remarks> [Args: <see cref="int"/> bodyID, <see cref="Godot.Node"/> body, <see cref="int"/> bodyShape, <see cref="int"/> areaShape] </remarks>
            public const string BodyShapeExited = "body_shape_exited";
        }
    }
}
