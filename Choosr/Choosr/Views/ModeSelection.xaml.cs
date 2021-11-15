﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Choosr.Views
{
    public partial class ModeSelection : ContentPage
    {
        public ModeSelection()
        {
            InitializeComponent();

            fileImage.Source = (Device.RuntimePlatform == Device.Android) ? ImageSource.FromFile("FavoriteProfile.png") : ImageSource.FromFile("Images/sports.jpg")
        }
    }
}
