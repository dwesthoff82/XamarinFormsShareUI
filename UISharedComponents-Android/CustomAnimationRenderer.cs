using System;
using Xamarin.Forms.Platform.Android;

using Xamarin.Forms;
using Android;

using System.Threading.Tasks;

using System.IO;
using Android.Widget;
using Android.Graphics.Drawables;
using AndHow.SharedComponents.Android;
using AndHow.SharedComponents;



[assembly: ExportRenderer(typeof(CustomAnimation), typeof(CustomAnimationRenderer))]
namespace AndHow.SharedComponents.Android
{
	public class CustomAnimationRenderer :ViewRenderer
	{

		AnimationDrawable ad = null;
		protected override void OnElementChanged (ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged (e);


			if (e.OldElement == null) {
			
				ImageView iv = new ImageView (this.Context);

				iv.SetBackgroundResource (Resource.Drawable.PunchAnimation);


				ad = (AnimationDrawable)iv.Background;

				SetNativeControl (iv);
			
			
			
			
			}

		}

		protected override void OnElementPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);


			if (e.PropertyName == "startAnimating") {

				if (((CustomAnimation)Element).startAnimating) {
					((CustomAnimation)Element).Done = false;

					ad.Start ();

					new Task (() => {
						System.Threading.Thread.Sleep (1000);
						((CustomAnimation)Element).isAnimating = false;
						System.Threading.Thread.Sleep (1500);
						((CustomAnimation)Element).Done = true;

					}).Start ();;



				}

			}

		}


	}
}