namespace Godot {
    public static partial class Signals {
        public class ColorPickerButton : Button {
            /// <summary> Emitted when the color changes. </summary>
            /// <remarks> [Args: <see cref="Color"/> color] </remarks>
            public const string ColorChanged = "color_changed";

            /// <summary> Emitted when the <see cref="Godot.ColorPicker"/> is created (the button is pressed for the first time). </summary>
            public const string PickerCreated = "picker_created";

            /// <summary> Emitted when the <see cref="Godot.ColorPicker"/> is closed. </summary>
            public const string PopupClosed = "popup_closed";
        }
    }
}
