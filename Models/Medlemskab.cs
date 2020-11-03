using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientsideH2.Models
{
    public class Medlemskab
    {
        public string Navn { get; set; }
        public string Efternavn { get; set; }
        public string telefon { get; set; }
        public string Adresse { get; set; }
        public string CPR { get; set; }
        public string consense { get; set; }

        public string psdpt { get; set; }
    }
}
