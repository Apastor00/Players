using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Players.Models;
using Players.Repositories;
using Players.ViewModels.Base;

namespace Players.ViewModels
{
    public class SubastaViewModel : ViewModelBase
    {
        private RepositoryApuesta repositoryApuesta;

        public SubastaViewModel()
        {
            repositoryApuesta = new RepositoryApuesta();
            List<Subasta> lista = repositoryApuesta.GetSubastas();
            Subasta = new ObservableCollection<Subasta>(lista);
        }


        private ObservableCollection<Subasta> _subasta;
        public ObservableCollection<Subasta> Subasta
        {
            get { return _subasta; }
            set
            {
                _subasta = value;
                OnPropertyChanged("Subasta");
            }
        }
    }
}
