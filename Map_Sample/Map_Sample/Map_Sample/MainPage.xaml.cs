
namespace Map_Sample
{
    using Syncfusion.SfMaps.XForms;
    using System;
    using System.ComponentModel;
    using Xamarin.Forms;

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Ok_Clicked(object sender, EventArgs e)
        {
            // It will be triggered when click the OK button.
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            // It will be triggered when click the Cancel button.
        }
    }

    public class CustomMarker: MapMarker
    {
        public string Country { get; set; }

        public string Population { get; set; }
    }
}
