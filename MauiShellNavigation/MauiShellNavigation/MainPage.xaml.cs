﻿using MauiShellNavigation.Pages;

namespace MauiShellNavigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await Shell.Current.GoToAsync(nameof(HomePage));

            await Shell.Current.GoToAsync($"{nameof(HomePage)}?username={txtNome.Text}");
        }

        private async void button1_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Page2));
        }
    }
}