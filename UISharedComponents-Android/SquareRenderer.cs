using System;
using Xamarin.Forms.Platform.Android;
using Android.Views;
using Xamarin.Forms;
using AndHow.SharedComponents;
using AndHow.SharedComponents.Android;


[assembly: ExportRenderer(typeof(Square), typeof(SquareRenderer))]
namespace AndHow.SharedComponents.Android
{
	public class SquareRenderer: ViewRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.View> e)
		{
			base.OnElementChanged (e);


			if (e.OldElement == null) {

				var uiv = new global::Android.Views.View (this.Context);
				uiv.SetBackgroundResource (UISharedComponentsAndroid.Resource.Drawable.Border);
			
				this.SetNativeControl(uiv);


				if (((Square)Element).DisplayActivityIndicator) {





				}


				//this.NativeView.Layer.BorderColor = Color.Gray.ToCGColor();
				//this.NativeView.Layer.BorderWidth = 1;

			}
		}
	}
}

