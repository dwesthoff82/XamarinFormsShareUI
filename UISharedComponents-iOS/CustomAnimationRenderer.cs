using System;
using Xamarin.Forms.Platform.iOS;

using Xamarin.Forms;
using UIKit;

using System.Threading.Tasks;
using Foundation;
using System.IO;
using AndHow.SharedComponents.iOS;
using AndHow.SharedComponents;


[assembly: ExportRenderer(typeof(CustomAnimation), typeof(CustomAnimationRenderer))]
namespace AndHow.SharedComponents.iOS
{
	public class CustomAnimationRenderer :ViewRenderer
	{


		protected override void OnElementPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);


			if (e.PropertyName == "startAnimating") {

				if (((CustomAnimation)Element).startAnimating) {
					((CustomAnimation)Element).Done = false;
					var cn = Control as UIImageView;

					cn.ContentMode = UIViewContentMode.ScaleAspectFill;
					cn.AnimationDuration = 2;
					cn.AnimationRepeatCount = 1;
					cn.StartAnimating ();
					//cn.d
					//UIImageView
					UIImageView.SetAnimationDelegate (this);
					UIImageView.SetAnimationDidStopSelector(new ObjCRuntime.Selector("stoppedAnimating"));
					new Task (() => {
						System.Threading.Thread.Sleep (1000);
						((CustomAnimation)Element).isAnimating = false;
						System.Threading.Thread.Sleep (1500);
						((CustomAnimation)Element).Done = true;

					}).Start ();;
				


				}
			
			}
				
		}

		[Export("stoppedAnimating:")]
		void StoppedAnimating(NSObject obj){

			int x=0;
			x++;


		}
		protected override void OnElementChanged (ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged (e);

			if (e.OldElement == null) {

				var images = new UIImage[60];
				var cn =new  UIImageView ();
				for (int i = 1; i <= 60; i++) {
					UIImage current;
					if (i < 10) {
						current = UIImage.FromBundle ("clockin_half_0" + i.ToString () + ".png");
					}else current = UIImage.FromBundle ("clockin_half_" + i.ToString () + ".png");

					UIGraphics.BeginImageContext (current.Size);

					var imagecontext = UIGraphics.GetCurrentContext ();
					imagecontext.DrawImage(new CoreGraphics.CGRect(new CoreGraphics.CGPoint(0,0), current.Size),current.CGImage);
				
					var image = UIGraphics.GetImageFromCurrentImageContext ();

					images [i - 1] = image;

					UIGraphics.EndImageContext ();

					current.Dispose ();

				
				}
				//UIImage[] animationImages = new UIImage[60] ();
				cn.AnimationImages = images;
				SetNativeControl (cn);



			}





		}

	}
}

