﻿using MauiNavigation.Pages;

namespace MauiNavigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AlunosPage());
        }
    }
}
