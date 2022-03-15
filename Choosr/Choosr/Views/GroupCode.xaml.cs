﻿using System;
using System.Collections.Generic;
using Choosr.Models;
using Choosr.Services;
using Xamarin.Forms;

namespace Choosr.Views
{
    public partial class GroupCode : ContentPage
    {
        GamePlayRestService mongoDB = new GamePlayRestService();
        public GroupCode()
        {
            InitializeComponent();

            Random rnd = new Random();
            String myGroupCode = "";
            for (int i = 0; i < 5; i++)
            {
                char letter = (char)rnd.Next(65, 91);
                myGroupCode += letter.ToString();
            }

            fileImage.Source = (Device.RuntimePlatform == Device.Android) ? ImageSource.FromFile("ChoosrLogo.png") : ImageSource.FromFile("ChoosrLogo.png");
            myCode.Text = myGroupCode;
            GamePlay dataDocs = new GamePlay { UserId = 1234, SessionId = 1, JoinCode = "test" };

            mongoDB.NewSession(dataDocs);
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(CategorySelection)}");

        }
    }
}