using System;
using Xamarin;
using Xamarin.Forms.Platform.Android;

using Xamarin.Forms;
using AndHow.SharedComponents.Android;
using AndHow.SharedComponents;

[assembly: ExportRenderer(typeof(Circle), typeof(CircleRenderer))]
namespace AndHow.SharedComponents.Android
{
	public class CircleRenderer : ViewRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged (e);

			if (e.OldElement == null) {
				// perform initial setup
				var circle = (Circle)Element;
				var cn = new NativeCircle (this.Context);

				cn.radius = circle.Radius ;
				cn.color = circle.Color.ToAndroid ();
				SetNativeControl (cn);
			}


		}

	}
}

