namespace Godot {
    public static partial class Signals {
        public class AnimatedSprite : Node2D {
            /// <summary>
            /// Emitted when the <see cref="Godot.Animation"/> is finished (when it plays the last frame).
            /// If the animation is looping, this signal is emitted every time the last frame is drawn.
            /// </summary>
            public const string AnimationFinished = "animation_finished";

            /// <summary> Emitted when <see cref="Godot.AnimatedSprite.Frame"/> changed. </summary>
            public const string FrameChanged = "frame_changed";
        }
    }
}
