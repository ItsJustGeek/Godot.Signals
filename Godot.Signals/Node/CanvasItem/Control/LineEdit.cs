namespace Godot {
    public static partial class Signals {
        public class LineEdit : Control {
            /// <summary> Emitted when trying to append text that would overflow the <see cref="Godot.LineEdit.MaxLength"/>.  </summary>
            public const string TextChangeRejected = "text_change_rejected ";

            /// <summary> Emitted when the text changes. </summary>
            /// <remarks> [Args: <see cref="string"/>] </remarks>
            public const string TextChanged = "text_changed";

            /// <summary> Emitted when the user presses <see cref="Godot.KeyList.Enter"/> on the <see cref="Godot.LineEdit"/>.</summary>
            /// <remarks> [Args: <see cref="string"/>] </remarks>
            public const string TextEntered = "text_entered";
        }
    }
}
