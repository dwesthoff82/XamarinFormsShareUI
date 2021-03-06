﻿using AndHow.SharedComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SharedUI.Update
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            CurvedStackLayout curvedStackLayout = new CurvedStackLayout() {
                BackgroundColor = Color.White
                ,Padding=15,Margin=15

            };



            RoundedRectangle rr = new RoundedRectangle { WidthRequest=100, HeightRequest=50, Radius = 1, Color = Color.BlueViolet};

            

            curvedStackLayout.Children.Add(new CustomFontLabel
            {
                FontSize = 25,
                FontName = "agencyr",
                Text = "This is a label with a custom Font"
            });


            CustomDatePicker customDatePicker = new CustomDatePicker { Text="Pick a day"};


            CustomTimePicker ctp = new CustomTimePicker(DateTime.Now) { Text="Pick a time"};

      

            Editor editor = new Editor
            {
                Text="regular editor",
                HeightRequest = 100,
                WidthRequest= 200

            };


            CustomEditor customEditor = new CustomEditor
            {
                HeightRequest= 200,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 25,
                FontName = "agencyr",
                Text = "This is a custom editor with a custom Font"


            };
         //   curvedStackLayout.Children.Add(editor);

            curvedStackLayout.Children.Add(customEditor);
            curvedStackLayout.Children.Add(new Circle
            {
                Radius = 20,
                Color = Color.Black,
                HeightRequest = 100,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            });




            curvedStackLayout.Children.Add(rr);
            curvedStackLayout.Children.Add(customDatePicker);
            curvedStackLayout.Children.Add(ctp);

            curvedStackLayout.Children.Add(new Calendar { HorizontalOptions = LayoutOptions.FillAndExpand, HeightRequest = 200});


            Label label = new Label { Text = "This is an image from a database" };

            curvedStackLayout.Children.Add(label);
            ResourceImage ri = new ResourceImage
            {
               
                SourceType = ResourceImage.SourceTypes.Database,
                ResourceName = "2",
                HeightRequest = 300,
                WidthRequest= 300
            };

            curvedStackLayout.Children.Add(ri);

            scrollyScroll.Content = curvedStackLayout;

         



       
        }
    }
}
