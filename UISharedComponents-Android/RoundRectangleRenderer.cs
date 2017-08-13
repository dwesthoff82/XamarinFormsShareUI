using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using AndHow.SharedComponents;
using AndHow.SharedComponents.Android;



[assembly: ExportRenderer(typeof(RoundedRectangle),typeof(RoundRectangleRenderer))]
namespace AndHow.SharedComponents.Android
{
	public class RoundRectangleRenderer : ViewRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged (e);

			if (e.OldElement == null) {
				RoundedRectangle roundRect = (RoundedRectangle)Element;
				var cn = new Rectangle (this.Context);

				SetNativeControl (cn);

			}


		}

	}

}

