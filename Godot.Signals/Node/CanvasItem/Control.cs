namespace Godot {
    public static partial class Signals {
        public class Control : CanvasItem {
            /// <summary> Emitted when the <see cref="Godot.Node"/> gains keyboard focus. </summary>
            public const string FocusEntered = "focus_entered";

            /// <summary> Emitted when the <see cref="Godot.Node"/> loses keyboard focus. </summary>
            public const string FocusExited = "focus_exited";

            /// <summary> Emitted when the <see cref="Godot.Node"/> receives an <see cref="Godot.InputEvent"/>. </summary>
            /// <remarks> [Args: <see cref="Godot.InputEvent"/>] </remarks>
            public const string GuiInput = "gui_input";

            /// <summary> Emitted when the <see cref="Godot.Node"/>'s minimum size changes. </summary>
            public const string MinimumSizeChanged = "minimum_size_changed";

            /// <summary> Emitted when a modal <see cref="Godot.Control"/> is closed. See <see cref="Godot.Control.ShowModal(bool)"/>. </summary>
            public const string ModalClosed = "modal_closed";

            /// <summary> 
            /// Emitted when the mouse enters the <see cref="Godot.Control"/>'s <see cref="Godot.Rect2"/> area, 
            /// provided its <see cref="Godot.Control.MouseFilter"/> lets the event reach it. 
            /// </summary>
            public const string MouseEntered = "mouse_entered";

            /// <summary> 
            /// Emitted when the mouse leaves the <see cref="Godot.Control"/>'s <see cref="Godot.Rect2"/> area,
            /// provided its <see cref="Godot.Control.MouseFilter"/> lets the event reach it. 
            /// </summary>
            public const string MouseExited = "mouse_exited";

            /// <summary> Emitted when the <see cref="Godot.Control"/> changes size. </summary>
            public const string Resized = "resized";

            /// <summary>
            /// Emitted when one of the size flags changes.
            /// See <see cref="Godot.Control.SizeFlagsHorizontal"/> and <see cref="Godot.Control.SizeFlagsVertical"/>. 
            /// </summary>
            public const string SizeFlagsChanged = "size_flags_changed";
        }
    }
}
