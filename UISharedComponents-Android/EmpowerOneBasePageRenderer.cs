using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using EmpowerOne.CustomViews;
using EmpowerOne;
using Android.Views;
using Android;
using Android.App;
using EmpowerOne.Android;
using Android.Text;
using Android.Text.Style;
using Android.Widget;
using System.IO;
using Android.Runtime;


[assembly:ExportRenderer (typeof(EmpowerOneBaseContentPage), typeof(EmpowerOneBasePageRenderer))]
namespace EmpowerOne.Android
{
	public class EmpowerOneBasePageRenderer : PageRenderer
	{

		public static global::Android.Graphics.Drawables.BitmapDrawable bkg = null;


		protected override void OnElementChanged (ElementChangedEventArgs<Page> e)
		{
			base.OnElementChanged (e);
			if (e.OldElement == null) {
				var act = Forms.Context as Activity;
				var page = Element as EmpowerOneBaseContentPage;
				page.PropertyChanged += ((sender, ee) => {
					if (page != null && page.subTitle != null)
						(Forms.Context as Activity).ActionBar.Subtitle = page.subTitle;				
				});


				if (e.OldElement == null) {
					if (bkg == null) {
						var item = App.db.GetResource (SqlLiteLoader.TagNames.DefaultBKG.ToString (), 1);

						using (var ms = new MemoryStream (item.Data)) {
							using (global::Android.Graphics.BitmapFactory.Options options = new global::Android.Graphics.BitmapFactory.Options ()){
								options.InJustDecodeBounds = true;

								//BitmapFactory.decodeResource(res, resId, options);
								global::Android.Graphics.BitmapFactory.DecodeStream (ms, null, options);
								IWindowManager windowManager = Context.GetSystemService (global::Android.Content.Context.WindowService).JavaCast<IWindowManager> ();
								global::Android.Graphics.Point outS = new global::Android.Graphics.Point ();
								windowManager.DefaultDisplay.GetSize (outS);
								options.InJustDecodeBounds = false;

								options.InSampleSize = calculateInSampleSize (options, outS.X / 4, outS.Y / 4);
								ms.Position = 0;
								using (global::Android.Graphics.Rect rt = new global::Android.Graphics.Rect (0, 0, 0, 0)) {
									var bitmap = global::Android.Graphics.BitmapFactory.DecodeStream (ms, rt, options);
								
							

									bitmap.Density = global::Android.Graphics.Bitmap.DensityNone;
								
									bkg = new global::Android.Graphics.Drawables.BitmapDrawable (bitmap);
								}
						
							}

						
						}
					}
					this.Background = bkg;





				}
			}
		}


		public static int calculateInSampleSize(
			global::Android.Graphics.BitmapFactory.Options options, int reqWidth, int reqHeight) {
			// Raw height and width of image
			int height = options.OutHeight;
			int width = options.OutWidth;
			int inSampleSize = 1;

			if (height > reqHeight || width > reqWidth) {

				 int halfHeight = height / 2;
				 int halfWidth = width / 2;

				// Calculate the largest inSampleSize value that is a power of 2 and keeps both
				// height and width larger than the requested height and width.
				while ((halfHeight / inSampleSize) > reqHeight
					&& (halfWidth / inSampleSize) > reqWidth) {
					inSampleSize *= 2;
				}
			}

			return inSampleSize;
		}





		private TextView getActionBarTitle ()
		{
			var act = Forms.Context as Activity;
			int inti = Resources.GetIdentifier ("action_bar_title", "id", "android");
			return act.Window.DecorView.FindViewById<TextView> (inti);

		}

		static bool setTitleFonts = true;

		protected override void OnDraw (global::Android.Graphics.Canvas canvas)
		{
			base.OnDraw (canvas);
			if (setTitleFonts) {
				var tv = getActionBarTitle ();
				if (tv != null) {
					tv.Typeface = global::Android.Graphics.Typeface.CreateFromAsset (Forms.Context.Assets, Constants.OswaldRegular + ".ttf");
					setTitleFonts = false;
				}
			}
		}

	}
}

