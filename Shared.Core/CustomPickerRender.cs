using System;
using Xamarin.Forms.Platform.Android;
using Android;

using Xamarin.Forms;

using AndHow.SharedComponents;
using Android.Content;
using Shared.Core;

[assembly: ExportRenderer(typeof(CustomPicker),typeof(CustomPickerRenderer))]
namespace Shared.Core
{
	public class CustomPickerRenderer : PickerRenderer
	{
        public CustomPickerRenderer(Context context)
            : base(context)
        { }

		protected override void OnElementChanged (ElementChangedEventArgs<Picker> e)
		{
			base.OnElementChanged (e);


			if (Element != null && Control != null) {


      
				Control.SetBackgroundResource (Shared.Core.Resource.Drawable.border);
			
				CustomPicker picker = (CustomPicker)Element;

				Control.SetTextColor (picker.TextColor.ToAndroid ());


			
			
			
			}



		}

	}
}

