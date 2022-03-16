using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Players.Models;
using Players.Repositories;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Players.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AltaView : ContentPage
    {
        RepositoryApuesta repositoryApuesta;
        public ObservableCollection<Subasta> subasta { get; set; }

        public AltaView()
        {
            InitializeComponent();
            /*subasta = new ObservableCollection<Subasta>();
                subasta.Add(new Subasta { name=})*/
            repositoryApuesta = new RepositoryApuesta();

            stepperLocal.ValueChanged += stepperLocal_ValueChanged;
            stepperVisitante.ValueChanged += stepperVisitante_ValueChanged;

            realizarApuesta.Clicked += realizarApuesta_Clicked;

        }

        private async void realizarApuesta_Clicked(object sender, EventArgs e)
        {
            ApuestasView apuestasView = new ApuestasView();
            await Navigation.PushAsync(apuestasView);

        }

        private void stepperVisitante_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            apuestaEquipo2.Text = e.NewValue.ToString("0");
        }

        private void stepperLocal_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            apuestaEquipo1.Text = e.NewValue.ToString("0");
        }

    }
}
