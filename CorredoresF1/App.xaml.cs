using CorredoresF1.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorredoresF1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DriverView();
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
