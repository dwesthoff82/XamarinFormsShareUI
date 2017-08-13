using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using AndHow.SharedComponents.iOS;
using AndHow.SharedComponents;


[assembly: ExportRenderer(typeof(CustomFontLabel), typeof(CustomFontLabelRenderer))]
namespace AndHow.SharedComponents.iOS
{
	public class CustomFontLabelRenderer : LabelRenderer
	{

		protected override void OnElementChanged (ElementChangedEventArgs<Label> e){
		
			base.OnElementChanged (e);

			CustomFontLabel label = (CustomFontLabel)Element;


			try{

				if(!String.IsNullOrEmpty(label.FontName)){

					var font = UIFont.FromName (label.FontName, (float)label.FontSize);
					Control.Font = font;
				}

				if(label.MarginLeft != 0 && e.OldElement == null){
					if(Control != null)
						Control.Hidden = true;
					var lwp = new LabelWithPadding();
					lwp.Insets = new UIEdgeInsets(0,(nfloat)label.MarginLeft,0,(nfloat)label.MarginRight);
					lwp.Text = Control.Text;
					lwp.TextColor = Control.TextColor;
					lwp.Font = Control.Font;
					lwp.LineBreakMode = Control.LineBreakMode;
					lwp.Lines = Control.Lines;
					this.SetNativeControl( lwp);
				}


				if(label.Border != 0){
					
					Control.Layer.BorderWidth = (nfloat)label.Border;
					Control.Layer.BorderColor = label.BorderColor.ToCGColor();
					Control.Layer.CornerRadius = (nfloat)label.BorderRadius;//(nfloat)label.Height/2.0f;

				}
			


			}catch(Exception ex){
			

			
			
			}



		}


		protected override void OnElementPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);


			CustomFontLabel label = (CustomFontLabel)Element;


			try{


				if(label.Border != 0){

					Control.Layer.BorderWidth = (nfloat)label.Border;
					Control.Layer.BorderColor = label.BorderColor.ToCGColor();
					Control.Layer.CornerRadius = (nfloat)label.BorderRadius;

				}

				var font = UIFont.FromName (label.FontName, (float)label.FontSize);
				Control.Font = font;
				//Control.LayoutMargins = new UIEdgeInsets(0,(nfloat)label.MarginLeft,0,0);
				//Control.LayoutMarginsDidChange();
			}catch(Exception ex){




			}
		}

		public override void DidChangeValue (string forKey)
		{
			base.DidChangeValue (forKey);




		}

	
	

	
	
	
	}



}

