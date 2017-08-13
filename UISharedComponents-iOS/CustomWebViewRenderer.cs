using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using AndHow.SharedComponents.iOS;
using AndHow.SharedComponents;




[assembly: ExportRenderer (typeof(CustomWebView), typeof(CustomWebViewRenderer))]
namespace AndHow.SharedComponents.iOS
{
	public class CustomWebViewRenderer : WebViewRenderer
	{

		protected override void OnElementChanged (VisualElementChangedEventArgs e)
		{
			base.OnElementChanged (e);


			try {
				

				var webview = this;
				//				webview.SizeToFit();

				webview.ScalesPageToFit = true;
				webview.ScrollView.ScrollEnabled = false;


			} catch (Exception ex) {
			}
		}


	}
}

