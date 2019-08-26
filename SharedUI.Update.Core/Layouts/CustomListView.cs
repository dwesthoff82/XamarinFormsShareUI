using System;
using Xamarin.Forms;
namespace AndHow.SharedComponents
{
	public class CustomListView : ListView
	{	public bool _Changed;
		public bool IsScrollEnabled = false;
		public bool IsSelectionEnabled = false;

		/*public bool Changed{ get{ return _Changed;
			
			} 


			set{this.OnPropertyChanged ("Changed");_Changed = value; } }*/

	}
}

