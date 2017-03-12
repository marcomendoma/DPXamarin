using Xamarin.Forms;

namespace DPXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // The root page of your application 
            var content = new View.ComicPage();

            MainPage = new DPXamarin.MainPage();
        }

        protected override void OnStart() 
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
