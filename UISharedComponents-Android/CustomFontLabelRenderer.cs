using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Graphics;

using Xamarin;
using AndHow.SharedComponents.Android;
using AndHow.SharedComponents;

[assembly: ExportRenderer(typeof(CustomFontLabel), typeof(CustomFontLabelRenderer))]
namespace AndHow.SharedComponents.Android
{
	public class CustomFontLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged (e);

			CustomFontLabel label = (CustomFontLabel)Element;

			try{
				if(e.OldElement == null){
				if(!string.IsNullOrEmpty(label.FontName))
					Control.Typeface = Typeface.CreateFromAsset (Forms.Context.Assets, label.FontName + ".ttf");
				}
				if(label.FontSize != 0)
					Control.TextSize = (float)label.FontSize;
				if(label.MarginLeft !=0 || label.MarginRight != 0)
					Control.SetPadding((int)label.MarginLeft,0,0,0);
			}catch(Exception ex){
			
			
			
			
			}


		}

	}
}

