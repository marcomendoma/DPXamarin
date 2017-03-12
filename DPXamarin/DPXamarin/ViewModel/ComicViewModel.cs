using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using System;
using System.Threading.Tasks;

using DPXamarin.Model;

namespace DPXamarin.ViewModel
{
    public class ComicViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(
            [CallerMemberName]
            string propertyName = null) =>
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(propertyName));

        private bool Busy;

        public bool IsBusy
        {
            get
            {
                return Busy;
            }

            set
            {
                Busy = value;
                OnPropertyChanged();
                GetComicsCommand.ChangeCanExecute();
            }
        }

        public ObservableCollection<Comic> Comics { get; set; }

        public Command GetComicsCommand { get; set; }

        public ComicViewModel()
        {
            Comics = new ObservableCollection<Comic>();

            GetComicsCommand = new Command(
                async () => await GetComics(),
                () => !IsBusy
            );
        }

        async Task GetComics()
        {

            if (!IsBusy)
            {
                Exception Error = null;

                try
                {
                    IsBusy = true;

                    var Repository = new Repository();
                    //var Items = await Repository.GetCatsAsAzure();
                    var Items = await Repository.GetComics();

                    Comics.Clear();

                    foreach (var comic in Items)
                    {
                        Comics.Add(comic);
                    }
                }
                catch (Exception ex)
                {
                    Error = ex;

                    if (Error != null)
                    {
                        await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Error!", Error.Message, "OK");
                    }
                }
                finally
                {
                    IsBusy = false;
                }
            }

            return;
        }
    }
}
