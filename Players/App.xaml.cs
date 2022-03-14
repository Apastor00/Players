using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using firebasesample.Services.FirebaseAuth;

namespace Players
{
    public partial class App : Application
    {
        public IFirebaseAuthService auth;

        public App(IFirebaseAuthService auth)
        {
            InitializeComponent();
            this.auth = auth;
            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {
        }

        internal void login(Entry user, Entry password)
        {
            throw new NotImplementedException();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
