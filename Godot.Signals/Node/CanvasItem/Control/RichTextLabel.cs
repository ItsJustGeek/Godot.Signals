namespace Godot {
    public static partial class Signals {
        public class RichTextLabel : Control {
            /// <summary>
            /// Triggered when the user clicks on content between meta tags. <br/>
            /// If the meta is defined in text, e.g. [url={"data"="hi"}]hi[/url], then the parameter for this signal will be a <see cref="string"/> type. <br/>
            /// If a particular type or an object is desired, the <see cref="Godot.RichTextLabel.PushMeta(object)"/> method must be used to manually insert the data into the tag stack.  </summary>
            /// <remarks> [Args: <see cref="Godot.Variant"/> meta] </remarks>
            public const string MetaClicked = "meta_clicked";

            /// <summary> Triggers when the mouse exits a meta tag. </summary>
            /// <remarks> [Args: <see cref="Godot.Variant"/> meta] </remarks>
            public const string MetaHoverEnded = "meta_hover_ended";

            /// <summary> Triggers when the mouse enters a meta tag. </summary>
            /// <remarks> [Args: <see cref="Godot.Variant"/> meta] </remarks>
            public const string MetaHoverStarted = "meta_hover_started";
        }
    }
}
