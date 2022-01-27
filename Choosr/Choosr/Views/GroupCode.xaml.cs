using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using Choosr.Services;

namespace Choosr.Views
{
    public partial class GroupCode : ContentPage
    {
        SessionsRestService mongoDB = new SessionsRestService();

        public GroupCode()
        {
            InitializeComponent();
            //var dbBase = dbClient.ListDatabaseNames().ToList();

            // Task<IMongoCollection<BsonDocument>> myDoc =  mongoDB.GetSessionsHistory();

            string randString = "Test";

            //foreach(var thing in dbBase)
            //{
            //    randString += thing.ToString();
            //}

            testing.Text = randString;

            Random rnd = new Random();
            string myGroupCode = "";
            for (int i = 0; i < 5; i++)
            {
                char letter = (char)rnd.Next(65, 91);
                myGroupCode += letter.ToString();
            }

            fileImage.Source = (Device.RuntimePlatform == Device.Android) ? ImageSource.FromFile("ChoosrLogo.png") : ImageSource.FromFile("ChoosrLogo.png");
            myCode.Text = myGroupCode;
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(CategorySelection)}");

        }
    }
}