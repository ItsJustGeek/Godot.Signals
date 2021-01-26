namespace Godot {
    public static partial class Signals {
        public class AnimationPlayer : Node {
            /// <summary> If the currently being played <see cref="Godot.Animation"/> changes, this signal will notify of such change. </summary>
            /// <remarks> [Args: <see cref="string"/> oldName, <see cref="string"/> newName] </remarks>
            public const string AnimationChanged = "animation_changed";

            /// <summary> Notifies when an <see cref="Godot.Animation"/> finished playing. </summary>
            /// /// <remarks> [Args: <see cref="string"/> animationName] </remarks>
            public const string AnimationFinished = "animation_finished";

            /// <summary> Notifies when an <see cref="Godot.Animation"/> starts playing. </summary>
            /// <remarks> [Args: <see cref="string"/> animationName] </remarks>
            public const string AnimationStarted = "animation_started";

            /// <summary> Notifies when the caches have been cleared, either automatically, or manually via <see cref="Godot.AnimationPlayer.ClearCaches"/>. </summary>
            public const string CachesCleared = "caches_cleared";
        }
    }
}
