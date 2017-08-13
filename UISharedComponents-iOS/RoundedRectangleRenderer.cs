using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using AndHow.SharedComponents;
using AndHow.SharedComponents.iOS;


[assembly: ExportRenderer(typeof(RoundedRectangle),typeof(RoundedRectangleRenderer))]
namespace AndHow.SharedComponents.iOS
{
	public class RoundedRectangleRenderer : ViewRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged (e);

			if (e.OldElement == null) {
			
				RoundedRectangle roundRect = (RoundedRectangle)Element;
				var cn = new NativeRectangle (roundRect.Color.ToCGColor(),(float)roundRect.Radius);
				cn.BackgroundColor = Color.Transparent.ToUIColor ();
				SetNativeControl (cn);
			}


		}

		protected override void OnElementPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);

			if (e.PropertyName.Contains ("Height")) {
			
				//((NativeRectangle)NativeView).SetNeedsLayout ();
			
			
			}

		}

	}
}
