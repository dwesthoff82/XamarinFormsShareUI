using System;
using UIKit;
using CoreGraphics;

namespace AndHow.SharedComponents.iOS
{
	public class CircleNative : UIView
	{
		public CGColor clr ;
		float radius;
		public CircleNative(CGColor clr,float radius){
			BackgroundColor = UIColor.Clear;
			Opaque = false;
			this.clr = clr;
			this.radius = radius;
		
		}

		public override void Draw (CGRect rect)
		{

			base.Draw (rect);
		
			using (CGContext g = UIGraphics.GetCurrentContext ()) {

				CGRect rf;
				//if (rect.Width > rect.Height) {
			
					var loc = rect.Location;


					rf = new CGRect (loc, new CGSize (2*radius, 2*radius));
			/*


				} else {
				
					var loc = rect.Location;
					float dif = (rect.Height - rect.Width) / 2.0f;

					loc.X = rect.X + (dif);

					rf = new System.Drawing.RectangleF (loc, new System.Drawing.SizeF (rect.Height, rect.Height));

				
				}*/
				//g.SetBlendMode (CGBlendMode.Clear);
				g.ClearRect (rect);
				g.SetFillColor(clr);
			

				g.FillEllipseInRect (rf);

			
			
			
			
			}
		}
	}
}

