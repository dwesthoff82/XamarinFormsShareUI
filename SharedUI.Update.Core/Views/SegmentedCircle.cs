using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace AndHow.SharedComponents
{
	public class SegmentedCircle : View
	{
		public double thickness = 10;
		List<Color> colors;


		public List<Color> Colors{

			get{ 
				if (colors == null)
					colors = new List<Color> ();
			
				return colors;
			}


		}

		List<double> radians;

		public List<double> Radians{

			get{ 
			
				if (radians == null)
					radians = new List<double> ();

				return radians;

			}


		}


	
		public SegmentedCircle ()
		{
			this.Colors.Add (Color.FromHex("E6E6E6"));
			this.Colors.Add (Color.Green);
			this.Radians.Add (2*Math.PI);
			this.Radians.Add (.25 * Math.PI);
			this.thickness = 13;
		}


		public SegmentedCircle (List<Color> colors, List<double> radians, double thickness = 10)
		{
			this.colors = colors;
			this.radians = radians;
			this.thickness = thickness;
		}
	}
}

