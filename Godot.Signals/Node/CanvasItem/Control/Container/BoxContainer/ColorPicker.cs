namespace Godot {
    public static partial class Signals {
        public class ColorPicker : BoxContainer {
            /// <summary> Emitted when the color is changed. </summary>
            /// <remarks> [Args: <see cref="Godot.Color"/> color] </remarks>
            public const string ColorChanged = "color_changed";

            /// <summary> Emitted when a preset is added. </summary>
            /// <remarks> [Args: <see cref="Godot.Color"/> color] </remarks>
            public const string PresetAdded = "preset_added";

            /// <summary> Emitted when a preset is removed. </summary>
            /// <remarks> [Args: <see cref="Godot.Color"/> color] </remarks>
            public const string PresetRemoved = "preset_removed";
        }
    }
}
