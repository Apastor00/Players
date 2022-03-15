using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Players.Models;
using Players.Repositories;
using Players.ViewModels.Base;

namespace ExamenIosX.ViewModels
{
    public class ApuestasViewModel : ViewModelBase
    {
        private RepositoryApuesta repositoryApuesta;

        public ApuestasViewModel()
        {
            repositoryApuesta = new RepositoryApuesta();
            List<Apuesta> lista = repositoryApuesta.GetApuestas();
            Apuesta = new ObservableCollection<Apuesta>(lista);
        }


        private ObservableCollection<Apuesta> _apuesta;
        public ObservableCollection<Apuesta> Apuesta
        {
            get { return this._apuesta; }
            set
            {
                _apuesta= value;
                OnPropertyChanged("Apuesta");
            }
        }
    }
}
