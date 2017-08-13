
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Graphics;

namespace AndHow.SharedComponents.Android
{
	public class Rectangle : View
	{
		public Rectangle (Context context) :
			base (context)
		{
			Initialize ();
		}

		public Rectangle (Context context, IAttributeSet attrs) :
			base (context, attrs)
		{
			Initialize ();
		}

		public Rectangle (Context context, IAttributeSet attrs, int defStyle) :
			base (context, attrs, defStyle)
		{
			Initialize ();
		}

		void Initialize ()
		{
		}


		protected override void OnDraw (Canvas canvas)
		{
			base.OnDraw (canvas);
			var Rect = new RectF ();

			Rect.Top = 0;
			Rect.Bottom = canvas.Height;
			Rect.Left = 0;
			Rect.Right = canvas.Width;

			Paint pt = new Paint ();

			pt.Color = Color.White;
			canvas.DrawRoundRect (Rect, 20,20, pt);


		}
	}
}

