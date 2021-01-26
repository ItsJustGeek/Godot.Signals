namespace Godot {
    public static partial class Signals {
        public class Tree : Control {
            /// <summary> Emitted when a button on the tree was pressed (see <see cref="Godot.TreeItem.AddButton(int, Texture, int, bool, string)"/>). </summary>
            /// <remarks> [Args: <see cref="TreeItem"/> item, <see cref="int"/> column, <see cref="int"/> id] </remarks>
            public const string ButtonPressed = "button_pressed";

            /// <summary> Emitted when a cell is selected. </summary>
            public const string CellSelected = "cell_selected";

            /// <summary> Emitted when a column's title is pressed. </summary>
            /// <remarks> [Args: <see cref="int"/> collumn] </remarks>
            public const string ColumnTitlePressed = "column_title_pressed";

            /// <summary> Emitted when a cell with the <see cref="Godot.TreeItem.TreeCellMode.Custom"/> is clicked to be edited. </summary>
            /// <remarks> [Args: <see cref="bool"/> arrowClicked] </remarks>
            public const string CustomPopupEdited = "custom_popup_edited";

            /// <summary> Emitted when the right mouse button is pressed in the empty space of the tree. </summary>
            /// <remarks> [Args: <see cref="Godot.Vector2"/> position] </remarks>
            public const string EmptyRightMouseButton = "empty_rmb";

            /// <summary> Emitted when the right mouse button is pressed if right mouse button selection is active and the tree is empty. </summary>
            /// <remarks> [Args: <see cref="Godot.Vector2"/> position] </remarks>
            public const string EmptyTreeRightMouseButtonSelected = "empty_tree_rmb_selected";

            /// <summary> Emitted when an item's label is double-clicked. </summary>
            public const string ItemActivated = "item_activated";

            /// <summary> Emitted when an item is collapsed by a click on the folding arrow. </summary>
            /// <remarks> [Args: <see cref="Godot.TreeItem"/> item] </remarks>
            public const string ItemCollapsed = "item_collapsed";

            /// <summary> Emitted when a custom button is pressed (i.e. in a <see cref="Godot.TreeItem.TreeCellMode.Custom"/> mode cell). </summary>
            public const string ItemCustomButtonPressed = "item_custom_button_pressed";

            /// <summary> Emitted when an item's icon is double-clicked. </summary>
            public const string ItemDoubleClicked = "item_double_clicked";

            /// <summary> Emitted when an item is edited. </summary>
            public const string ItemEdited = "item_edited";

            /// <summary> Emitted when an item is edited using the right mouse button. </summary>
            public const string ItemRightMouseButtomEdited = "item_rmb_edited";

            /// <summary> Emitted when an item is selected with the right mouse button. </summary>
            public const string ItemRightMouseButtomSelected = "item_rmb_selected";

            /// <summary> Emitted when an item is selected. </summary>
            public const string ItemSelected = "item_selected";

            /// <summary> Emitted instead of <see cref="ItemSelected"/> if <see cref="Godot.Tree.SelectMode"/> is <see cref="Godot.Tree.SelectModeEnum.Multi"/>. </summary>
            /// <remarks> [Args: <see cref="Godot.TreeItem"/> item, <see cref="int"/> column, <see cref="bool"/> selected] </remarks>
            public const string MultiSelected = "multi_selected";

            /// <summary> Emitted when a left mouse button click does not select any item. </summary>
            public const string NothingSelected = "nothing_selected";
        }
    }
}
