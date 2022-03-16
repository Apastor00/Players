using System;
using Players.Models;
using Players.Repositories;
using Players.ViewModels.Base;
using Xamarin.Forms;

namespace Players.ViewModels
{
    public class SubastaModel : ViewModelBase
    {
        RepositoryApuesta repositoryApuesta;

        public SubastaModel()
        {
            repositoryApuesta = new RepositoryApuesta();
            Subasta = new Subasta();
        }
        private Subasta _subasta;
        public Subasta Subasta
        {
            get { return _subasta; }
            set
            {
                _subasta = value;
                OnPropertyChanged("Subasta");
            }
        }
        public Command InsertarDato
        {
            get
            {
                return new Command(() => {
                    repositoryApuesta.InsertarSubasta(Subasta);
                });
            }
        }
    }
}
