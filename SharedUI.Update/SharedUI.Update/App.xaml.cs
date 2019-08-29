using SharedUI.Update.Core.DataAccess;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SharedUI.Update
{
    public partial class App : Application
    {


        //Single global database access for resources.... 
        public static DataAccessLayer DataAccessLayer { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
