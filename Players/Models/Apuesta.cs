using System;
using Realms;

namespace Players.Models
{
    public class Apuesta :RealmObject
    {
        public string user { get; set; }
        public int resultadoLocal { get; set; }
        public int resultadoVisitante { get; set; }
    }
}
