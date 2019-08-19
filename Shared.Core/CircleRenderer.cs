using System;
using Xamarin;
using Xamarin.Forms.Platform.Android;

using Xamarin.Forms;

using AndHow.SharedComponents;
using Android.Content;
using Shared.Core;

[assembly: ExportRenderer(typeof(Circle), typeof(CircleRenderer))]
namespace Shared.Core
{
	public class CircleRenderer : ViewRenderer
	{
        public CircleRenderer(Context context)
            : base(context)
        { }
		protected override void OnElementChanged (ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged (e);

			if (e.OldElement == null)
            {
				// perform initial setup
				var circle = (Circle)Element;
				var cn = new NativeCircle(this.Context)
                {

                    radius = circle.Radius,
                    color = circle.Color.ToAndroid(),

                };

				
				SetNativeControl (cn);
			}


		}

	}
}

