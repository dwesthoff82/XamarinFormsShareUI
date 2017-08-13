using System;
using Xamarin.Forms.Platform.Android;
using Android;

using Xamarin.Forms;
using AndHow.SharedComponents.Android;
using AndHow.SharedComponents;


[assembly: ExportRenderer(typeof(CustomPicker),typeof(CustomPickerRenderer))]
namespace AndHow.SharedComponents.Android
{
	public class CustomPickerRenderer : PickerRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Picker> e)
		{
			base.OnElementChanged (e);


			if (Element != null && Control != null) {
			
				Control.SetBackgroundResource (UISharedComponentsAndroid.Resource.Drawable.Border);
			
				CustomPicker picker = (CustomPicker)Element;

				Control.SetTextColor (picker.TextColor.ToAndroid ());


			
			
			
			}



		}

	}
}

