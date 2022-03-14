using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Players
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            btnLogin.Clicked += BtnLogin_Clicked;
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            App app = (App)App.Current;
            bool selogeo = await app.auth.SignIn(user.Text, password.Text);
            Console.WriteLine("login : " + selogeo);
            await Navigation.PushAsync(new MainPage());
        }
    }
}
