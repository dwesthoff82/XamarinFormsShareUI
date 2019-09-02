using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;
using SharedUI.Update.Core.DataAccess;
using SQLite;
using System.IO;
using Environment = System.Environment;
using AndHow.SharedComponents;

namespace SharedUI.Update.Droid
{
    [Activity(Label = "SharedUI.Update", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            Shared.Core.Init.Initialize();//This call makes sure this library is loaded by the dependency service 😊

            App.DataAccessLayer = new DataAccessLayer
            {
                SQLiteConnection = GetConnection()
            };


            ResourceImage.Init(App.DataAccessLayer);
          

            LoadApplication(new App());
        }

        /// <summary>
        /// This is a function that is going to create or open the local DB for resources... 
        /// </summary>
        /// <returns></returns>
        private SQLiteConnection GetConnection()
        {
            //Get the DB from assets if it doesnt exits... 

            string dbPath = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "base.db3");

            Console.Write(dbPath);
            //check for the existence of the db in the private app folder
              if (!File.Exists(dbPath))
              {
                  //1. It doesnt exist and 
                  //a. we need to copy the file from the assets ...
               


                  using (var reader = new BinaryReader(Application.Context.Assets.Open("base.db")))
                  {
                      using (var writer = new BinaryWriter(new FileStream(dbPath, FileMode.Create)))
                      {
                          byte[] buffer = new byte[2048];
                          int length = 0;
                          while ((length = reader.Read(buffer, 0, buffer.Length)) > 0)
                          {
                              writer.Write(buffer, 0, length);
                          }
                      }
                  }



              }



              //2. Open a connection to the sqlite db 
              

            //return the current open connection 
            return  new SQLiteConnection(dbPath); 
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] global::Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}