using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using AndHow.SharedComponents.iOS;
using AndHow.SharedComponents;

[assembly: ExportRenderer(typeof(Square), typeof(SquareRenderer))]
namespace AndHow.SharedComponents.iOS
{
	public class SquareRenderer : ViewRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged (e);


			if (e.OldElement == null) {
			
				UIKit.UIView uiv = new UIKit.UIView ();
				uiv.Layer.BorderColor = Color.Gray.ToCGColor();
				uiv.Layer.BorderWidth = 1;
				uiv.BackgroundColor = Color.Gray.MultiplyAlpha (.15).ToUIColor ();
				this.SetNativeControl(uiv);


				if (((Square)Element).DisplayActivityIndicator) {
				
					InvokeOnMainThread (() => {


						var uia = new  UIKit.UIActivityIndicatorView (UIKit.UIActivityIndicatorViewStyle.WhiteLarge);
						uia.Center = new CoreGraphics.CGPoint(Control.Center);
						//Control.BackgroundColor = Color.Gray.ToUIColor ();

						uia.AutoresizingMask = (UIKit.UIViewAutoresizing.FlexibleLeftMargin   | 
							UIKit.UIViewAutoresizing.FlexibleRightMargin  | 
							UIKit.UIViewAutoresizing.FlexibleTopMargin    | 
							UIKit.UIViewAutoresizing.FlexibleBottomMargin);

						Control.AddSubview (uia);
						uia.StartAnimating ();

					});

				
				
				}


				//this.NativeView.Layer.BorderColor = Color.Gray.ToCGColor();
				//this.NativeView.Layer.BorderWidth = 1;
			
			}
		}
	}
}

