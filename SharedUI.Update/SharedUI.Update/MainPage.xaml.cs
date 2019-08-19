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

            CustomEditor customEditor = new CustomEditor("agencyr", 15);

            curvedStackLayout.Children.Add(customDatePicker);
            curvedStackLayout.Children.Add(ctp);
        //    curvedStackLayout.Children.Add(customEditor);

            curvedStackLayout.Children.Add(new Circle
            {
                Radius = 30,
                Color = Color.AliceBlue,
                HeightRequest=60,
                WidthRequest = 100
            });






            scrollyScroll.Content = curvedStackLayout;

         



       
        }
    }
}