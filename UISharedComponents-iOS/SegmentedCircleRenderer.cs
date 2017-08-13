using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using System.Collections.Generic;
using AndHow.SharedComponents;
using AndHow.SharedComponents.iOS;


[assembly: ExportRenderer(typeof(SegmentedCircle), typeof(SegmentedCircleRenderer))]

namespace AndHow.SharedComponents.iOS
{
	public class SegmentedCircleRenderer : ViewRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged (e);

			if (e.OldElement == null) {
				// perform initial setup
				List<CoreGraphics.CGColor> colors = new List<CoreGraphics.CGColor> ();;
				SegmentedCircle circle = (SegmentedCircle)Element;
				circle.Colors.ForEach ((x) => {
				
					colors.Add(x.ToCGColor());
				
				});
				var cn = new SegmentedCircleNative (50,circle.Radians,colors,circle.thickness);
				cn.BackgroundColor = Color.Transparent.ToUIColor ();
				SetNativeControl (cn);
			}


		}

	}
}

