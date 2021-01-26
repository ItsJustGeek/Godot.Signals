namespace Godot {
    public static partial class Signals {
        public class OptionButton : Button {
            /// <summary> Emitted when the user navigates to an item using the ui_up or ui_down actions. The index of the item selected is passed as argument. </summary>
            /// <remarks> [Args: <see cref="System.int"/> index] </remarks>
            public const string ItemFocused = "item_focused";

            /// <summary> Emitted when the current item has been changed by the user. The index of the item selected is passed as argument. </summary>
            /// <remarks> [Args: <see cref="System.int"/> index] </remarks>
            public const string ItemSelected = "item_selected";
        }
    }
}
