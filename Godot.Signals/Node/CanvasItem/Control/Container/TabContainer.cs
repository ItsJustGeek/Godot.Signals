namespace Godot {
    public static partial class Signals {
        public class TabContainer : Container {
            /// <summary> Emitted when the <see cref="Godot.TabContainer"/>'s <see cref="Godot.Popup"/> button is clicked. See <see cref="Godot.TabContainer.SetPopup"/> for details. </summary>
            public const string PrePopupPressed = "pre_popup_pressed";

            /// <summary> Emitted when switching to another tab. </summary>
            /// <remarks> [Args: <see cref="System.int"/> tab] </remarks>
            public const string TabChanged = "tab_changed";

            /// <summary> Emitted when a tab is selected, even if it is the current tab. </summary>
            /// <remarks> [Args: <see cref="System.int"/> tab] </remarks>
            public const string TabSelected = "tab_selected";
        }
    }
}
