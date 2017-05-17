using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace WhatToWatch
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WhatToWatch.MainPage();
        }

        protected override void OnStart()
        {
            int xXamarin = 0;
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
