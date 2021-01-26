namespace Godot {
    public static partial class Signals {
        public class TextEdit : Control {
            /// <summary> Emitted when a breakpoint is placed via the breakpoint gutter. </summary>
            /// /// <remarks> [Args: <see cref="int"/> row] </remarks>
            public const string BreakpointToggled = "breakpoint_toggled";

            /// <summary> Emitted when the cursor changes. </summary>
            public const string CursorChanged = "cursor_changed";

            /// <summary> Emitted when the info icon is clicked. </summary>
            /// <remarks> [Args: <see cref="int"/> row, <see cref="string"/> info] </remarks>
            public const string InfoClicked = "info_clicked";

            /// <summary> No documentation provided by Godot! </summary>
            public const string RequestCompletion = "request_completion";

            /// <summary> No documentation provided by Godot! </summary>
            /// <remarks> [Args: <see cref="string"/> symbol, <see cref="int"/> row,  <see cref="int"/> collumn] </remarks>
            public const string SymbolLookup = "symbol_lookup";

            /// <summary> Emitted when the text changes. </summary>
            public const string TextChanged = "text_changed";
        }
    }
}
