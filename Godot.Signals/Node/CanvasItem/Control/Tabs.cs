namespace Godot {
    public static partial class Signals {
        public class Tabs : Control {
            /// <summary> Emitted when the active tab is rearranged via mouse drag. See <see cref="Godot.Tabs.DragToRearrangeEnabled"/>. </summary>
            /// <remarks> [Args: <see cref="int"/> idxTo] </remarks>
            public const string RepositionActiveTabRequest = "reposition_active_tab_request";

            /// <summary> Emitted when a tab is right-clicked. </summary>
            /// <remarks> [Args: <see cref="int"/> tab] </remarks>
            public const string RightButtonPressed = "right_button_pressed";

            /// <summary> Emitted when switching to another tab. </summary>
            /// <remarks> [Args: <see cref="int"/> tab] </remarks>
            public const string TabChanged = "tab_changed";

            /// <summary> Emitted when a tab is clicked, even if it is the current tab. </summary>
            /// <remarks> [Args: <see cref="int"/> tab] </remarks>
            public const string TabClicked = "tab_clicked";

            /// <summary> Emitted when a tab is closed. </summary>
            /// <remarks> [Args: <see cref="int"/> tab] </remarks>
            public const string TabClose = "tab_close";

            /// <summary> Emitted when a tab is hovered by the mouse. </summary>
            /// <remarks> [Args: <see cref="int"/> tab] </remarks>
            public const string TabHover = "tab_hover";
        }
    }
}
