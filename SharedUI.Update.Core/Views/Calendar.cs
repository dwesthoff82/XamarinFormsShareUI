using System;
using Xamarin.Forms;

namespace AndHow.SharedComponents
{
	public class Calendar : StackLayout
	{
		Grid gridHeader;
		Grid grid;
		public Calendar ()//This is a factory you cant have my constructor
		{
			BuildHeader ();
			BuildBody ();


		}


        //TODO: Update to include the intialization of the caldendar with dates....


		public void BuildBody(){

			grid = new Grid { 

				ColumnDefinitions = {


					new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)},
					new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)},
					new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)},
					new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)},
					new ColumnDefinition{Width = new GridLength(1, GridUnitType.Star)}
				},
				RowDefinitions = {new RowDefinition{Height = new GridLength(1,GridUnitType.Star)},
					new RowDefinition{Height = new GridLength(30,GridUnitType.Absolute)},
					new RowDefinition{Height = new GridLength(30,GridUnitType.Absolute)},
					new RowDefinition{Height = new GridLength(30,GridUnitType.Absolute)},
					new RowDefinition{Height = new GridLength(30,GridUnitType.Absolute)} 
				}




			};


		}
		public void BuildHeader(){

		
			gridHeader = new Grid { ColumnDefinitions = {

					new ColumnDefinition{ Width = new GridLength (1, GridUnitType.Star) },
					new ColumnDefinition{ Width = new GridLength (1, GridUnitType.Star) }

				},
				RowDefinitions = {new RowDefinition{Height = new GridLength(1,GridUnitType.Auto)},
					new RowDefinition{Height = new GridLength(1,GridUnitType.Auto)}


				},HeightRequest = 55


			};
			gridHeader.Padding = 0;
			gridHeader.BackgroundColor = Color.FromHex("ff014d82");


		}



	}
}

