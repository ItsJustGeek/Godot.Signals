namespace Godot {
    public static partial class Signals {
        public class Tween : Node {
            /// <summary> Emitted when all processes in a <see cref="Godot.Tween"/> end. </summary>
            public const string TweenAllCompleted = "tween_all_completed";

            /// <summary> Emitted when a <see cref="Godot.Tween"/> ends. </summary>
            /// <remarks> [Args: <see cref="Godot.Object"/> object, <see cref="NodePath"/> key] </remarks>
            public const string TweenCompleted = "tween_completed";

            /// <summary> Emitted when a <see cref="Godot.Tween"/> starts. </summary>
            /// <remarks> [Args: <see cref="Godot.Object"/> object, <see cref="NodePath"/> key] </remarks>
            public const string TweenStarted = "tween_started";

            /// <summary> Emitted when at each step of the animation. </summary>
            /// <remarks> [Args: <see cref="Godot.Object"/> object, <see cref="NodePath"/> key, <see cref="float"/> elapsed, <see cref="Godot.Object"/> value] </remarks>
            public const string TweenStep = "tween_step";
        }
    }
}
