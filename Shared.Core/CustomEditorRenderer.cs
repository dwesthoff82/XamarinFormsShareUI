using System;
using Xamarin.Forms.Platform.Android;
using Android;
using Xamarin.Forms;
using Android.Graphics.Drawables;

using AndHow.SharedComponents;
using Android.Content;
using Shared.Core;

[assembly: ExportRenderer(typeof(CustomEditor),typeof(CustomEditorRenderer))]
namespace Shared.Core
{
	public class CustomEditorRenderer: EditorRenderer
	{
        public CustomEditorRenderer(Context context)
            :base(context)
        {


        }
		//added comment - checking jenkins build

		protected override void OnElementChanged (ElementChangedEventArgs<Editor> e)
		{
			try{
				base.OnElementChanged (e);

				var editorElement = (CustomEditor)Element;


				if (editorElement != null && Control != null) {

                  
                    Control.Background = Context.GetDrawable(Shared.Core.Resource.Drawable.border);
                    var tf = global::Android.Graphics.Typeface.CreateFromAsset (base.Context.Assets, editorElement.FontName  + ".ttf");
					Control.Typeface = tf;

					Control.Text = string.Empty;
					Control.SetTextColor(editorElement.TextColor.ToAndroid());
					Control.Hint = editorElement.Hint;
					Control.SetHintTextColor(global::Android.Graphics.Color.Gray);
					Control.TextSize = (float)editorElement.FontSize == 0 ? 13: (float)editorElement.FontSize;


				}
			}catch {

				


			}
		}

	}
}


    