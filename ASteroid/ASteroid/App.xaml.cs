﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using System.Collections.Generic;
using ASteroid.Models;
using ASteroid.Pages;

namespace ASteroid
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            MainPage = new ListViewPage1();
        }

        protected override void OnStart()
        {
            

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
