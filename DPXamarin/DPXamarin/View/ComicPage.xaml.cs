using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DPXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComicPage : ContentPage
    {
        public ComicPage()
        {
            InitializeComponent();
            ListViewComics.ItemSelected += ListViewComics_ItemSelected;
        }

        private async void ListViewComics_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var SelectedComic = e.SelectedItem as Model.Comic;

            if (SelectedComic != null)
            {
                await Navigation.PushAsync(new View.DetailsComic(SelectedComic));

                ListViewComics.SelectedItem = null;
            }
        }
    }
}
