﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new HApp.MainPage();
            //MainPage = new HApp.LandingPage();
            
            MainPage = new NavigationPage(new LandingPage());
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
