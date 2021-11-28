﻿using System;
using Xamarin.Forms;

namespace Choosr.Views
{
    public partial class ModeSelection : ContentPage
    {
        public ModeSelection()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(CategorySelection)}");
        }
    }
}
