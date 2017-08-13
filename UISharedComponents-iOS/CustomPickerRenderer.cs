using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;
using AndHow.SharedComponents;
using AndHow.SharedComponents.iOS;


[assembly: ExportRenderer (typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace AndHow.SharedComponents.iOS
{
	public class CustomPickerRenderer : PickerRenderer
	{

		protected override void OnElementChanged (ElementChangedEventArgs<Picker> e)
		{
			try{
				base.OnElementChanged (e);
			
				CustomPicker pickerElement = (CustomPicker)Element;

				var font = UIFont.FromName (pickerElement.FontName, (float)pickerElement.FontSize);

				if(pickerElement != null && Control != null)
				{
					Control.Font = font;
					Control.Layer.BorderWidth = (nfloat)pickerElement.Border;
					Control.Layer.BorderColor = pickerElement.BorderColor.ToCGColor ();
				//	Control.TextColor = pickerElement.TextColor.ToUIColor();
				}



			}catch(Exception ex) {

			}
		}
	}
}

