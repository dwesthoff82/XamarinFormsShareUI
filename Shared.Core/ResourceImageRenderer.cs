using System;

using Xamarin;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using System.IO;
using Android.Views;
using Android.Runtime;
using System.Threading.Tasks;
using AndHow.SharedComponents;
using Android.Content;
using Shared.Core;

[assembly: ExportRenderer(typeof(ResourceImage), typeof(ResourceImageRenderer))]
namespace Shared.Core
{
	public class ResourceImageRenderer : ImageRenderer
	{
        public ResourceImageRenderer(Context context) : base(context)
        { }
        protected override void OnElementChanged (ElementChangedEventArgs<Image> e)
		{
			base.OnElementChanged (e);

			if (e.OldElement == null) 
			{
			
				var el = (ResourceImage)Element;



				if (el.SourceType == ResourceImage.SourceTypes.Database) {
					/*
					var item = App.db.GetResource (el.ResName, 1);

					using (var ms = new MemoryStream (item.Data)) {
						global::Android.Graphics.BitmapFactory.Options options = new global::Android.Graphics.BitmapFactory.Options ();

						options.InJustDecodeBounds = false;

						options.InSampleSize = 2;//calculateInSampleSize (options, outS.X / 4, outS.Y / 4);
						ms.Position = 0;
						using (global::Android.Graphics.Rect rt = new global::Android.Graphics.Rect (0, 0, 0, 0)) {
							var bitmap = global::Android.Graphics.BitmapFactory.DecodeStream (ms, rt, options);



							bitmap.Density = global::Android.Graphics.Bitmap.DensityNone;
							Control.SetImageDrawable (new global::Android.Graphics.Drawables.BitmapDrawable (bitmap));
						}

					}*/
				} else if (el.SourceType == ResourceImage.SourceTypes.File) {
			
					using (global::Android.Graphics.BitmapFactory.Options options = new global::Android.Graphics.BitmapFactory.Options ()) {
						
						options.InJustDecodeBounds = false;

						options.InSampleSize = 1;//calculateInSampleSize (options, outS.X / 4, outS.Y / 4);
						var gd = Context.Resources.GetIdentifier (el.ResName.Split (new char[]{ '.' }) [0], "drawable", Context.PackageName);
						using (global::Android.Graphics.Rect rt = new global::Android.Graphics.Rect (0, 0, 0, 0)) {
							var bitmap = global::Android.Graphics.BitmapFactory.DecodeResource (Context.Resources, gd, options);//DecodeStream (ms, rt, options);
							bitmap.Density = global::Android.Graphics.Bitmap.DensityNone;


                          
                             Control.SetImageDrawable (new global::Android.Graphics.Drawables.BitmapDrawable (this.Context.Resources,bitmap));
						}
					}

			

			
				} else if (el.SourceType == ResourceImage.SourceTypes.Function) {
				
					new Task (() => {

						//var s = el.Func();

						var ms = el.Func();
						if(ms == null)return;

							global::Android.Graphics.BitmapFactory.Options options = new global::Android.Graphics.BitmapFactory.Options ();

							options.InJustDecodeBounds = false;

							options.InSampleSize = 2;//calculateInSampleSize (options, outS.X / 4, outS.Y / 4);
							ms.Position = 0;


							Device.BeginInvokeOnMainThread(()=>{
								using (global::Android.Graphics.Rect rt = new global::Android.Graphics.Rect (0, 0, 0, 0)) {
								
									try{
										var bitmap = global::Android.Graphics.BitmapFactory.DecodeStream (ms, rt, options);



										bitmap.Density = global::Android.Graphics.Bitmap.DensityNone;
										Control.SetImageDrawable (new global::Android.Graphics.Drawables.BitmapDrawable (this.Context.Resources,bitmap));

									}catch(Exception  eee){



										
									}
							}
							});


					}).Start();
				
				
				}
			
			
			
			}
				
		}
		
	}
}

