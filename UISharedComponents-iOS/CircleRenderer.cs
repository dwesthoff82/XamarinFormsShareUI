using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using CoreGraphics;
using AndHow.SharedComponents.iOS;
using AndHow.SharedComponents;


[assembly: ExportRenderer(typeof(Circle), typeof(CircleRenderer))]
namespace AndHow.SharedComponents.iOS
{
	public class CircleRenderer : ViewRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged (e);
		
			if (e.OldElement == null) {
				// perform initial setup
				Circle circle = (Circle)Element;
				var cn = new CircleNative (circle.Color.ToCGColor(),(float)circle.Radius/2.0f);
				cn.BackgroundColor = Color.Transparent.ToUIColor ();
				SetNativeControl (cn);
			}


		}


		protected override void OnElementPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);


			Circle cirtc = (Circle)Element;


			try{
				//var font = UIFont.FromName (label.FontName, (float)label.FontSize);
				((CircleNative)Control).clr = cirtc.Color.ToCGColor();

				Control.SetNeedsDisplay();
			}catch(Exception ex){




			}
		}


	}
}

