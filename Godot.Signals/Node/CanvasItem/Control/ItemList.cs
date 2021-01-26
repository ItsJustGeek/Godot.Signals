namespace Godot {
    public static partial class Signals {
        public class ItemList : Control {
            /// <summary> Triggered when specified list item is activated via double-clicking or by pressing Enter. </summary>
            /// <remarks> [Args: <see cref="int"/> index] </remarks>
            public const string ItemActivated = "item_activated";

            /// <summary>
            /// Triggered when specified list item has been selected via right mouse clicking. <br/>
            /// The click position is also provided to allow appropriate popup of context menus at the correct location. <br/>
            /// <see cref="Godot.ItemList.AllowRmbSelect"/> must be enabled.
            /// </summary>
            /// <remarks> [Args: <see cref="int"/> index, <see cref="Godot.Vector2"/> atPosition] </remarks>
            public const string ItemRightMouseButtonSelected = "item_rmb_selected";

            /// <summary>
            /// Triggered when specified item has been selected. <br/>
            /// <see cref="Godot.ItemList.AllowReselect"/> must be enabled.
            /// </summary>
            /// <remarks> [Args: <see cref="int"/> index] </remarks>
            public const string ItemSelected = "item_selected";

            /// <summary> Triggered when a multiple selection is altered on a list allowing multiple selection. </summary>
            /// <remarks> [Args: <see cref="int"/> index, <see cref="bool"/> selected] </remarks>
            public const string MultiSelected = "multi_selected";

            /// <summary> Triggered when a left mouse click is issued within the rect of the list but on empty space. </summary>
            public const string NothingSelected = "nothing_selected";

            /// <summary> 
            /// Triggered when a right mouse click is issued within the rect of the list but on empty space. <br/>
            /// <see cref="Godot.ItemList.AllowRmbSelect"/> must be enabled.
            /// </summary>
            /// <remarks> [Args: <see cref="Godot.Vector2"/> atPosition] </remarks>
            public const string RightMouseButtonClicked = "rmb_clicked";
        }
    }
}
