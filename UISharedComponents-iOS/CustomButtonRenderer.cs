using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using CoreGraphics;
using UIKit;
using AndHow.SharedComponents;
using AndHow.SharedComponents.iOS;


[assembly: ExportRenderer(typeof(CustomFontButton), typeof(CustomButtonRenderer))]
namespace AndHow.SharedComponents.iOS
{
	public class CustomButtonRenderer :ButtonRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged (e);


			var bt = (CustomFontButton)Element;


			if (bt != null && Control != null) {
			
				var font = UIFont.FromName (bt.FontName, (float)bt.FontSize);
			
				Control.Font = font;


				if (bt.OutLineColor != null ) {
				
					
					Control.BackgroundColor = Color.White.ToUIColor ();
					Control.SetTitleColor (((Color)bt.OutLineColor).ToUIColor (), UIControlState.Normal);
					Control.Layer.BorderWidth = 1;
					Control.Layer.BorderColor = ((Color)bt.OutLineColor).ToCGColor ();

				
				}
			
			}
		}
	}
}

