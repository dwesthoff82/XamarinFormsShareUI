using System;
using Xamarin.Forms;

namespace AndHow.SharedComponents
{
	public class Circle : View
	{

		public double Radius{ get; set;}
		private Color _color;
		public Color Color{ get{ return _color;}
			set{ _color = value;

				OnPropertyChanged ();


			}}



	
	}
}

