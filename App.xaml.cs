using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;


namespace TareaOpc
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.HomePage();
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
