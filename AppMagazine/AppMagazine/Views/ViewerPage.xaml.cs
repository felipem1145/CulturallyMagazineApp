using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Reflection;


namespace AppMagazine.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewerPage : ContentPage
    {
        Stream fileStream;
        public ViewerPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {            
            base.OnAppearing();
            fileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("AppMagazine.Resources.Issues.Fauna Universal.pdf");
            //Load the PDF
            pdfViewerControl.LoadDocument(fileStream);
        }
    }
}