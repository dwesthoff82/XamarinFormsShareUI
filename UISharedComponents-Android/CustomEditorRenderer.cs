using System;
using Xamarin.Forms.Platform.Android;
using Android;
using Xamarin.Forms;
using Android.Graphics.Drawables;
using AndHow.SharedComponents.Android;
using AndHow.SharedComponents;


[assembly: ExportRenderer(typeof(CustomEditor),typeof(CustomEditorRenderer))]
namespace AndHow.SharedComponents.Android
{
	public class CustomEditorRenderer: EditorRenderer
	{

		//added comment - checking jenkins build

		protected override void OnElementChanged (ElementChangedEventArgs<Editor> e)
		{
			try{
				base.OnElementChanged (e);

				var editorElement = (CustomEditor)Element;


				if (editorElement != null && Control != null) {
					Control.Background = this.Resources.GetDrawable(UISharedComponentsAndroid.Resource.Drawable.Border);
					var tf = global::Android.Graphics.Typeface.CreateFromAsset (Forms.Context.Assets, editorElement.FontName  + ".ttf");
					Control.Typeface = tf;

					Control.Text = string.Empty;
					Control.SetTextColor(editorElement.TextColor.ToAndroid());
					Control.Hint = editorElement.Hint;
					Control.SetHintTextColor(global::Android.Graphics.Color.Gray);
					Control.TextSize = (float)editorElement.FontSize == 0 ? 13: (float)editorElement.FontSize;


				}
			}catch (Exception ex){

				int x = 0;
				x++;



			}
		}

	}
}


    