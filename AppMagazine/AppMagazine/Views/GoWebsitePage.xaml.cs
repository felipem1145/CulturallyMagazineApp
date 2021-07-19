using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace AppMagazine.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoWebsitePage : ContentPage
    {
        public GoWebsitePage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await Browser.OpenAsync("https://www.culturallyarts.com");
        }
    }
}