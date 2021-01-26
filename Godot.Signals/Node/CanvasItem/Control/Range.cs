namespace Godot {
    public static partial class Signals {
        public class Range : Control {
            /// <summary> Emitted when <see cref="Godot.Range.MinValue"/>, <see cref="Godot.Range.MaxValue"/>, <see cref="Godot.Range.Page"/>, or <see cref="Godot.Range.Step"/> change. </summary>
            public const string Changed = "changed";

            /// <summary> Emitted when <see cref="Godot.Range.Value"/> changes. </summary>
            /// <remarks> [Args: <see cref="float"/> value] </remarks>
            public const string ValueChanged = "value_changed";
        }
    }
}
