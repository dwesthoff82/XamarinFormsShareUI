using System;
using Xamarin.Forms;
using System.IO;
using SharedUI.Update.Core.DataAccess;

namespace AndHow.SharedComponents
{
	public class ResourceImage :Image
	{
        public static DataAccessLayer DataAccessLayer { get; set; }

        public static void Init(DataAccessLayer dataAccessLayer = null)
        {

            DataAccessLayer = dataAccessLayer;

        }
		public enum SourceTypes{

			Database,
			File,
			Function,


		}
		private bool _LoadAct = false;
		public bool LoadAct { get{
				return _LoadAct;
			}

			set{ _LoadAct = value; OnPropertyChanged ("LoadAct");
			
			}
		}
		public Func<Stream> Func{ get; set; }
		public SourceTypes SourceType{ get; set;}
		public string ResourceName{ get; set;}
		public ResourceImage ()
		{
		}

		
		public ResourceImage(Func<Stream> func){
		
			SourceType = SourceTypes.Function;
			Func = func;
		
		
		}
	}
}

