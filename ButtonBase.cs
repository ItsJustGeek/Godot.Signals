namespace Godot {
    public static partial class Signals {
        public class BaseButton : Control {
            /// <summary> Emitted when the <see cref="Godot.BaseButton"/> starts being held down. </summary>
            public const string ButtonDown = "button_down";

            /// <summary> Emitted when the <see cref="Godot.BaseButton"/> stops being held down. </summary>
            public const string ButtonUp = "button_up";

            /// <summary>
            /// Emitted when the <see cref="Godot.BaseButton"/> is toggled or pressed. <br/>
            /// This is on <see cref="ButtonDown"/> if <see cref="Godot.BaseButton.ActionMode"/> is <see cref="Godot.BaseButton.ActionModeEnum.Press"/> and on <see cref="ButtonUp"/> otherwise. 
            /// </summary>
            public const string Pressed = "pressed";

            /// <summary>
            /// Emitted when the <see cref="Godot.BaseButton"/> was just toggled between pressed and normal states (only if toggle_mode is active). <br/>
            /// The new state is contained in the <see cref="Godot.BaseButton._Toggled(bool)"/> argument.
            /// </summary>
            /// <remarks> [Args: <see cref="bool"/> buttonPressed] </remarks>
            public const string Toggled = "toggled";
        }
    }
}
