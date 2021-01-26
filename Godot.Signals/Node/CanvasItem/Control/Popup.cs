namespace Godot {
    public static partial class Signals {
        public class Popup : Control {
            /// <summary> 
            /// Emitted when a popup is about to be shown. <br/>
            /// This is often used in <see cref="Godot.PopupMenu"/> to clear the list of options then create a new one according to the current context.
            /// </summary>
            public const string AboutToShow = "about_to_show";

            /// <summary> Emitted when a popup is hidden. <br/> </summary>
            public const string Hidden = "popup_hide";
        }
    }
}
