using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using AndHow.SharedComponents.iOS;
using AndHow.SharedComponents;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace AndHow.SharedComponents.iOS
{
	public class CustomEntryRenderer : EntryRenderer
	{
		
		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged (e);




			if (e.OldElement == null && Control != null) {


				var label = Element as CustomEntry;;
				//Control = null;

				try{
					if(!string.IsNullOrEmpty(label.FontName)){



						var font = UIFont.FromName (label.FontName, (float)label.FontSize);
						Control.Font = font;
					}
				}catch(Exception ex){
				
				
				
				}
				var ie = Control;//new InsetEntry ();
				ie.BorderStyle = UIKit.UITextBorderStyle.None;
				ie.BackgroundColor = Color.White.ToUIColor ();
				ie.Layer.BorderWidth = 1;
				ie.Layer.BorderColor = Color.FromHex ("A6A6A6").ToCGColor ();
	
			
				SetNativeControl (ie);
			
	
			}
		}
	}
}

