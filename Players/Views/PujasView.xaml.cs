using System;
using System.Collections.Generic;
using Players.Models;
using Xamarin.Forms;

namespace Players.Views
{
    public partial class PujasView : ContentPage
    {
        public List<listadoSubasta> Subastas = new List<listadoSubasta>();
        public PujasView()
        {
            InitializeComponent();
            Subastas = new List<listadoSubasta>();
            listadoSubasta subasta = new listadoSubasta()
            {
                fotoPuja = "santo.jpg"
            };
            Subastas.Add(subasta);
            subasta = new listadoSubasta()
            {
                fotoPuja = "delorean.jpg"
            };
            Subastas.Add(subasta);
            subasta = new listadoSubasta()
            {
                fotoPuja = "espadaBraveheart.png"
            };
            Subastas.Add(subasta);
            subasta = new listadoSubasta()
            {
                fotoPuja = "mechonbruce.jpg"
            };
            Subastas.Add(subasta);
            subasta = new listadoSubasta()
            {
                fotoPuja = "sableluke.jpg"
            };
            Subastas.Add(subasta);
            subasta = new listadoSubasta()
            {
                fotoPuja = "silicona.jpg"
            };
            Subastas.Add(subasta);
            subasta = new listadoSubasta()
            {
                fotoPuja = "varitaWillow.jpg"
            };
            Subastas.Add(subasta);
            listadoSubastas.ItemsSource = Subastas;
        }
    }
}
