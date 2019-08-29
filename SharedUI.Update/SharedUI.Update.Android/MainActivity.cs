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

          
          

            LoadApplication(new App());
        }

        /// <summary>
        /// This is a function that is going to create or open the local DB for resources... 
        /// </summary>
        /// <returns></returns>
        private SQLiteConnection GetConnection()
        {
            //Get the DB from assets if it doesnt exits... 


            //check for the existence of the db in the private app folder


            //1. It doesnt exist and 
                //a. we need to copy the file from the assets ...
                
            //2. Open a connection to the sqlite db 


            //return the current open connection 
            return null; 
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] global::Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}