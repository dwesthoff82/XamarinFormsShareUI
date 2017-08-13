using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using AndHow.SharedComponents.iOS;

[assembly: ExportRenderer(typeof(MyScrollView), typeof(MyScrollViewRenderer))]
namespace AndHow.SharedComponents.iOS
{
	public class MyScrollViewRenderer : ScrollViewRenderer
	{
		protected override void OnElementChanged (VisualElementChangedEventArgs e)
		{
			base.OnElementChanged (e);


			var lv = (MyScrollView)Element;

			if (lv != null) {


				if (lv.Refresh != null) {
					var control = new UIRefreshControl ();

					control.AddTarget ((sender, ee) => {


						lv.Refresh(sender,ee);
					

						control.EndRefreshing ();

					}, UIControlEvent.ValueChanged);
					NativeView.AddSubview (control);


				}


				((UIScrollView)NativeView).ScrollsToTop = lv.ScrollToTop;
				ScrollsToTop = lv.ScrollToTop;;
			}

		


		}


	}
}

