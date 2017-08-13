using System;

using Xamarin;
using Xamarin.Forms.Platform.iOS;

using Xamarin.Forms;

using System.IO;
using AndHow.SharedComponents.iOS;
using AndHow.SharedComponents;


[assembly: ExportRenderer(typeof(ResourceImage), typeof(ResourceImageRenderer))]
namespace AndHow.SharedComponents.iOS
{
	public class ResourceImageRenderer : ImageRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Image> e)
		{
			base.OnElementChanged (e);

			if (e.OldElement == null) 
			{

				var el = (ResourceImage)Element;



				if (el.SourceType == ResourceImage.SourceTypes.Database) {



						
				} else if (el.SourceType == ResourceImage.SourceTypes.File) {
				
				
					el.Source = ImageSource.FromFile (el.ResName);
				

				} else if (el.SourceType == ResourceImage.SourceTypes.Function) {
				
					el.Source = ImageSource.FromStream (el.Func);

				
				}



			}

		}
		UIKit.UIActivityIndicatorView uia ;

		protected override void OnElementPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);



			if (e.PropertyName == "LoadAct") {

				var el = (ResourceImage)Element;

				if (el.LoadAct && el.SourceType == ResourceImage.SourceTypes.Function) {
					InvokeOnMainThread (() => {
						uia = new  UIKit.UIActivityIndicatorView (UIKit.UIActivityIndicatorViewStyle.WhiteLarge);

						//Control.BackgroundColor = Color.Gray.ToUIColor ();
						Control.AddSubview (uia);
						uia.StartAnimating ();

					});
					int x = 0;
					x++;
				
				
				} else if (!el.LoadAct && el.SourceType == ResourceImage.SourceTypes.Function) {
				
				/*	InvokeOnMainThread (() => {

						Control.BackgroundColor = Color.Transparent.ToUIColor();
						if(uia != null){uia.StopAnimating();
							uia.RemoveFromSuperview();
							uia = null;
						}
						
					});*/
				
				
				}
			
			}
		}

	}
}

