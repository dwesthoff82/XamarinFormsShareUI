using System;

using Android;
using Android.Views;
using Android.Graphics;
using Android.Content;

namespace AndHow.SharedComponents.Android
{
	public class NativeCircle : View
	{
		public double radius{ get; set;}
		public Color color;
		public NativeCircle(Context ctx)
			:base (ctx)
		{



		}

		protected override void OnDraw (Canvas canvas)
		{
			base.OnDraw (canvas);

			Paint pt = new Paint ();
			pt.Color = color;
			pt.AntiAlias = true;
			canvas.DrawCircle (canvas.Width/2.0f, canvas.Height/2.0f, (float)radius, pt);
		
		}
	}
}

