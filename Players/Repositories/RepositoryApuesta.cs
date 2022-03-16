using System;
using System.Collections.Generic;
using System.Linq;
using Players.Models;
using Realms;

namespace Players.Repositories
{
    public class RepositoryApuesta
    {
        private Realm conexionRealm;
        Transaction transaction;
        public RepositoryApuesta()
        {
            conexionRealm = Realm.GetInstance();
        }
        public List<Apuesta> GetApuestas()
        {
            List<Apuesta> lista = conexionRealm.All<Apuesta>().ToList();
            return lista;
        }

        internal List<Subasta> GetSubastas()
        {
            throw new NotImplementedException();
        }

        public void InsertarApuesta (Apuesta apuesta)
        {
            transaction = conexionRealm.BeginWrite();
            var entry = conexionRealm.Add(apuesta);
            transaction.Commit();
        }

        internal void InsertarSubasta(Subasta subasta)
        {
            throw new NotImplementedException();
        }
    }
}