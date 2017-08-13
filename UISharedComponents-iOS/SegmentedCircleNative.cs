using System;
using UIKit;
using System.Collections.Generic;
using CoreGraphics;
namespace AndHow.SharedComponents.iOS
{
	public class SegmentedCircleNative : UIView
	{
		double radius;
		double thickness;

		List<double> radians;
		List<CGColor> colors;


		public SegmentedCircleNative (double radius, List<double> radians, List<CGColor> colors,double thickness)
		{
			BackgroundColor = UIColor.Clear;
			Opaque = false;

			this.radius = radius;
			this.radians = radians;
			this.thickness = thickness;
			this.colors = colors;
		}


		public override void Draw(CGRect rect){
		
			base.Draw (rect);

			using (CGContext g = UIGraphics.GetCurrentContext ()) {
			
			
				CGRect rf;
				//if (rect.Width > rect.Height) {

				var loc = rect.Location;
				//loc = new CGPoint (.55f, rect.Height / 2.0f);
				radius = ((rect.Width -(thickness+10))/ 2.0f) ;
				rf = new CGRect (loc, new CGSize (rect.Width , rect.Height));
			
			
				//g.ClearRect (rect);
			
				//g.AddArc (rect.Width / 2.0f, rect.Height / 2.0f, (nfloat)radius, 0, 360, false);

				g.SetStrokeColor(colors[0]);
				g.SetLineWidth ((nfloat)thickness);
				//g.Clip ();

			/*	g.StrokePath ();//StrokeEllipseInRect (rf);
				g.ClosePath ();
				g.BeginPath ();


				g.AddArc (rect.Width / 2.0f, rect.Height / 2.0f, (nfloat)radius, 0, 80, false);

			*/	
				UIBezierPath path = null;
				for (int i = 0; i < colors.Count; i++) {

					path = UIBezierPath.FromArc (new CGPoint (rect.Width / 2.0f, rect.Height / 2.0f), (nfloat)radius, 1.75f * (float)Math.PI, (nfloat)radians[i] + 1.75f*((nfloat)Math.PI), true);

					g.SetStrokeColor (colors [i]);
					path.LineWidth = (nfloat)thickness;
					path.Stroke ();


					//g.SetLineWidth ((nfloat)thickness);

				}	//path = UIBezierPath.FromArc (new CGPoint (rect.Width / 2.0f, rect.Height / 2.0f), (nfloat)radius, 0, 15, false);

				//path.LineWidth = 10;
				//path.Stroke ();
				//g.StrokePath ();//StrokeEllipseInRect (rf);
			}
		
		}
	}
}

