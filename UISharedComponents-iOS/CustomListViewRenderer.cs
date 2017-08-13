using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using AndHow.SharedComponents.iOS;
using AndHow.SharedComponents;

[assembly: ExportRenderer(typeof(CustomListView), typeof(CustomListViewRenderer))]
namespace AndHow.SharedComponents.iOS
{
	public class CustomListViewRenderer : ListViewRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.ListView> e)
		{
			base.OnElementChanged (e);
		

			var lv = (CustomListView)Element;

			if (lv != null) {

				Control.SeparatorStyle = UIKit.UITableViewCellSeparatorStyle.SingleLine;
				Control.SeparatorColor = lv.SeparatorColor.ToUIColor ();;
				Control.AllowsSelection = lv.IsSelectionEnabled;

			

				if(lv.SeparatorVisibility == SeparatorVisibility.None)
					Control.SeparatorStyle = UIKit.UITableViewCellSeparatorStyle.None;
				Control.ScrollEnabled = lv.IsScrollEnabled;
				Control.ScrollsToTop = false;
			}
		
		}
	}
}

