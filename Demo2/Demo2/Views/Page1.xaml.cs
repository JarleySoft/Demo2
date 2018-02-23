using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace Demo2.Views
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            Analytics.TrackEvent("PAGE1 Viewed");

            badButton.Clicked += BadButton_Clicked;
        }

        void BadButton_Clicked(object sender, System.EventArgs e)
        {
            var num = 0;

            var test = 7 / num;
        }
    }
}