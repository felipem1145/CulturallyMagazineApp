using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMagazine.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GetInvolvedPage : ContentPage
    {
        public GetInvolvedPage()
        {
            InitializeComponent();
        }

        private async void GoToSubmit(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://docs.google.com/forms/d/e/1FAIpQLSd92PQVgBUP2x5Fd905s-uLz_6msksidZql4TXoMp1xv8VNXA/viewform");
        }
    }
}