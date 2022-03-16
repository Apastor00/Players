using System;
using Realms;

namespace Players.Models
    

{
    public class Subasta : RealmObject
    {
        public string user { get; set; }
        public string password { get; set; }
        public string puja { get; set; }
        public string fotoPuja { get; set; }
    }
}
