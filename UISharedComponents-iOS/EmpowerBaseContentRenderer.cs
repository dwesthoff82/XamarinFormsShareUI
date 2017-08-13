using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using EmpowerOne.CustomViews;
using EmpowerOne;
using EmpowerOne.iOS;
using UIKit;
using System.IO;
using Foundation;


[assembly:ExportRenderer(typeof(EmpowerOneBaseContentPage), typeof(EmpowerBaseContentRenderer))]
namespace EmpowerOne.iOS
{
	public class EmpowerBaseContentRenderer : PageRenderer
	{


		static UIKit.UIImage image = null;

		protected override void OnElementChanged (VisualElementChangedEventArgs e)
		{
			base.OnElementChanged (e);





			if (e.OldElement == null) {
				var page = Element as EmpowerOneBaseContentPage;




				if (image == null) {
					var item = App.db.GetResource (SqlLiteLoader.TagNames.DefaultBKG.ToString (), 1);

					using (MemoryStream ms = new MemoryStream (item.Data)) {

		

		
						image = new UIImage (NSData.FromStream (ms));
					}
				}

				UIImageView uiv = new UIImageView (image);

				uiv.Frame = this.ViewController.View.Frame;
				uiv.ContentMode = UIViewContentMode.ScaleToFill;

				View.AddSubview (uiv);
				View.SendSubviewToBack (uiv);
				
			
			//	View.BackgroundColor = UIColor.FromPatternImage (image);
			//	UIKit.UIImageView uai = new UIImageView (this.View.Frame);
			//	this.View.AddSubview (uai);
			//	this.View.SendSubviewToBack (uai);

				page.PropertyChanged += ((sender, ee) => {

					if(ee.PropertyName == "Title" || ee.PropertyName == "subTitle"){

						InvokeOnMainThread(()=>{
							if (tv != null)
								tv.Text = page.Title;
							if (tv2 != null)
								tv2.Text = page.subTitle;
						});
					}					
				});
			}



 			





		}

		UILabel tv;
		UILabel tv2;


		public override void WillMoveToParentViewController (UIKit.UIViewController parent)
		{
			base.WillMoveToParentViewController (parent);
			var page = (EmpowerOneBaseContentPage)Element;

			if (this.NavigationItem.TitleView == null && !string.IsNullOrEmpty(this.NavigationItem.Title) && !string.IsNullOrEmpty(page.subTitle)  ) {

				if (tv == null || tv2 == null) {
					CoreGraphics.CGRect rect = new CoreGraphics.CGRect (0, 0, 200, 45);

					UIKit.UIView view = new UIKit.UIView (rect);

					CoreGraphics.CGRect rectTitle = new CoreGraphics.CGRect (0, -3, 200, 30);

					tv = new UIKit.UILabel (rectTitle);
					tv.BackgroundColor = Color.Transparent.ToUIColor ();
					tv.TextAlignment = UITextAlignment.Center;
					tv.TextColor = Color.White.ToUIColor ();
					CoreGraphics.CGRect rectsubTitle = new CoreGraphics.CGRect (0, 18, 200, 22);

					tv2 = new UIKit.UILabel (rectsubTitle);
					tv2.BackgroundColor = Color.Transparent.ToUIColor ();
					tv.Font = UIFont.FromName ("Oswald-Regular", 18.5f);
					tv.Text = Title;
					tv2.Font = UIFont.FromName ("Sintony", 10f);
					tv2.Text = page.subTitle;
					tv2.TextAlignment = UITextAlignment.Center;
					tv2.TextColor = UIColor.FromRGBA (0xe6, 0xe6, 0xe6, 0xe6);
					view.AddSubview (tv);
					view.AddSubview (tv2);
					parent.NavigationItem.TitleView = view;
				}


			}
		}


	}
}

