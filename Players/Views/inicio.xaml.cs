using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Players.Views
{
    public partial class inicio : ContentPage
    {
        public inicio()
        {
            InitializeComponent();
            baseDatos.Clicked += async (sender, args) =>
            await Navigation.PushAsync(new AltaView());

            webApi.Clicked += async (sender, args) =>
            await Navigation.PushAsync(new ApuestasView());
        }
    }
}
