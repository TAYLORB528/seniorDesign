using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Choosr.Views;
using Xamarin.Forms;

namespace Choosr
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Home), typeof(Home));
            Routing.RegisterRoute(nameof(ModeSelection), typeof(ModeSelection));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        }
    }
}
