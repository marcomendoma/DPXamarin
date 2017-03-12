using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DPXamarin.Model;
using System;

namespace DPXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsComic : ContentPage
    {
        Comic SelectedComic;

        public DetailsComic(Comic selectedComit)
        {
            InitializeComponent();

            this.SelectedComic = selectedComit;
            BindingContext = this.SelectedComic;

            ButtonWebSite.Clicked += ButtonWebSite_Clicked;
        }

        private void ButtonWebSite_Clicked(object sender, EventArgs e)
        {
            if (SelectedComic.title.StartsWith("http"))
            {
                Device.OpenUri(new Uri(SelectedComic.title));
            }
        }
    }
}
