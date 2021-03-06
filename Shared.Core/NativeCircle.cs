﻿using System;

using Android;
using Android.Views;
using Android.Graphics;
using Android.Content;
using Android.Util;

namespace Shared.Core
{
	public class NativeCircle : View
	{
		public double Radius{ get; set;}
		public Color Color { get; set; }
		public NativeCircle(Context ctx)
			:base (ctx)
        {
            Initialize();
        }

        public NativeCircle(Context context, IAttributeSet attrs) :
            base(context, attrs)
        {
            Initialize();
        }

        public NativeCircle(Context context, IAttributeSet attrs, int defStyle) :
            base(context, attrs, defStyle)
        {
            Initialize();
        }

        void Initialize()
        {
        }

        protected override void OnDraw (Canvas canvas)
		{
			base.OnDraw (canvas);

			Paint pt = new Paint ();
			pt.Color = Color.Black;
            pt.AntiAlias = true;

            //TODO: this needs to be modified to account for the density of the screen. 
            canvas.DrawCircle ((float)Radius, (float)Radius, (float)Radius, pt);
		
		}
	}
}

