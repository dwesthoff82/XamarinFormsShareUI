using System;
using Xamarin.Forms.Platform.iOS;
using UIKit;

using Xamarin.Forms;
using AndHow.SharedComponents.iOS;
using AndHow.SharedComponents;

[assembly: ExportRenderer (typeof(CustomEditor), typeof(CustomEditorRenderer))]
namespace AndHow.SharedComponents.iOS
{
	public class CustomEditorRenderer : EditorRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Editor> e)
		{
			try {
				base.OnElementChanged (e);

				CustomEditor editorElement = (CustomEditor)Element;
				UIFont font = null;


				if(!string.IsNullOrEmpty(editorElement.FontName)){
				
					float size =(float) editorElement.FontSize;

					if(size == 0)
						size = 13;
					font = UIFont.FromName (editorElement.FontName, size);
				}
				TextViewHint textViewHint = new TextViewHint (editorElement.Hint,editorElement);

				if (e.OldElement == null) {
					UITextView tv = new UITextView{ Delegate = textViewHint };
					tv.Text = editorElement.Hint;
					tv.TextColor = Color.Black.ToUIColor ();
					//tv.KeyboardType = UIKeyboardType.Url;
					tv.TextContainer.MaximumNumberOfLines=0;
					SetNativeControl (tv);

				}
				if (editorElement != null && Control != null) {
					Control.Layer.BorderColor = editorElement.BorderColor.ToCGColor ();
					Control.Layer.BorderWidth = 1;
					Control.TextColor = editorElement.TextColor.ToUIColor ();
					if(font != null)Control.Font = font;

				}
			


			} catch (Exception ex) {

			
			
			
			}
		}
		protected override void UpdateNativeWidget ()
		{

			try{
				base.UpdateNativeWidget ();
			}catch(Exception ex){
				int x = 0;
				x++;
			
			
			}
		}

		protected override void Dispose (bool disposing)
		{
			//base.Dispose (disposing);
		}
	}
}

