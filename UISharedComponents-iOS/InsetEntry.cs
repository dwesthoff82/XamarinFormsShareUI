using System;
using CoreGraphics;
namespace AndHow.SharedComponents.iOS
{
	public class InsetEntry : UIKit.UITextField
	{
		public override CoreGraphics.CGRect EditingRect (CoreGraphics.CGRect forBounds)
		{
			return new CGRect(forBounds.X+5,forBounds.Y,forBounds.Width-5,forBounds.Height);
		}

		public override CGRect TextRect (CGRect forBounds)
		{
			return new CGRect(forBounds.X+5,forBounds.Y,forBounds.Width-5,forBounds.Height);
		}
	}
}

