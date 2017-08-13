using System;
using UIKit;
using CoreGraphics;
namespace AndHow.SharedComponents.iOS
{
	public class NativeRectangle : UIView
	{
		float radius;
		CGColor clr;

		public NativeRectangle (CGColor color, float radius)
		{
			BackgroundColor = UIColor.Clear;
			Opaque = false;
			this.clr = color;
			this.radius = radius;
		
		
		}

		public override void Draw (CGRect rect)
		{
			base.Draw (rect);

			using (CGContext g = UIGraphics.GetCurrentContext ()) {
			
				var path = UIBezierPath.FromRoundedRect (rect, radius);
				g.SetFillColor (clr);
				g.SetStrokeColor (clr);
				//g.AddPath (path);
				path.Fill ();

				path.Stroke ();
			
			}

		}
	}
}

