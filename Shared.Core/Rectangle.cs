using Android.Content;
using Android.Graphics;
using Android.Util;
using Android.Views;
using System;

namespace Shared.Core
{
    public class Rectangle : View
    {


        public Color Color { get; set; }
        public Rectangle(Context context) :
            base(context)
        {
            Initialize();
        }

        public Rectangle(Context context, IAttributeSet attrs) :
            base(context, attrs)
        {
            Initialize();
        }

        public Rectangle(Context context, IAttributeSet attrs, int defStyle) :
            base(context, attrs, defStyle)
        {
            Initialize();
        }

        void Initialize()
        {
        }


        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);
            var Rect = new RectF();

            Rect.Top = 0;
            Rect.Bottom = canvas.Height-10;
            Rect.Left = 0;
            Rect.Right = canvas.Width-10;

            Paint pt = new Paint();

            pt.Color = this.Color;
            canvas.DrawRoundRect(Rect, 20, 20, pt);


        }
    }
}
