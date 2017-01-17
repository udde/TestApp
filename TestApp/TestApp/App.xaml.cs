﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Xamarin.Forms;

namespace TestApp
{
    public partial class App : Application
    {
        public App()
        {
            MobileCenter.Start(typeof(Analytics), typeof(Crashes));

            InitializeComponent();

            MainPage = new TestApp.MainPage();
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
            int x = 10 ;
            int y = 0;
            int crash = x / y;
        }
    }
}
