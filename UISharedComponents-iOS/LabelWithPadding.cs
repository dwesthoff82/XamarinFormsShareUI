using System;
using UIKit;
using System.Drawing;


namespace AndHow.SharedComponents.iOS
{
	public class LabelWithPadding : UILabel
	{
		UIEdgeInsets _insets;
		public UIEdgeInsets Insets { get{ 



				return _insets;
			
			}
			set{_insets = value;} }


		public override void DrawText (CoreGraphics.CGRect rect)
		{
			base.DrawText (Insets.InsetRect (rect));
		}

	}
}

