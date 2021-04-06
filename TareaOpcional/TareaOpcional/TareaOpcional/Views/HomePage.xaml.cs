using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaOpc.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaOpc.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

         async void Music01_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetailPage(), true);
        }
    }
}