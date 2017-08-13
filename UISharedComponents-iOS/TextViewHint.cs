using System;
using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace AndHow.SharedComponents.iOS
{
	public class TextViewHint : UITextViewDelegate
	{
		public string hint;
		public CustomEditor elm;
		public TextViewHint (string hintIn,CustomEditor elm)
		{
			hint = hintIn;
			this.elm = elm;
		}

		public override void EditingStarted (UITextView textView)
		{
			try{
				if (textView.Text.Equals (hint)) {
					textView.Text = "";
					textView.TextColor = Color.Black.ToUIColor ();
				}
				textView.BecomeFirstResponder();
			}catch(Exception ex){
			
				int x = 0;
				x++;
			
			}
		}

		public override void EditingEnded (UITextView textView)
		{
			try{
			if (textView.Text.Equals ("")) {
				textView.Text = hint;
				textView.TextColor = Color.FromHex ("a6a6a6").ToUIColor ();
			
			} else
				elm.Text = textView.Text;
				


			//textView.Ended.Invoke(null,null);
				textView.ResignFirstResponder();
				elm.DoneEditingProp();
			}catch(Exception ex){

				int x = 0;
				x++;

			}

		}

	

		public override void Changed (UITextView textView)
		{

			try{
			elm.Text = textView.Text;
			}catch(Exception ex){
			
				int x = 0;
				x++;
			
			
			}
		}

	}
}

