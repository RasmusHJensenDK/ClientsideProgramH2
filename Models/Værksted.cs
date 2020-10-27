using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientsideH2.Models
{
    public class Værksted
    {
        public string Navn { get; set; }
        public string Model { get; set; }
        public string Afdeling { get; set; }
        public string Email { get; set; }
        public int tlf { get; set; }
        public string NrPlader { get; set; }
        public int kilometer { get; set; }
        public string workorder { get; set; }
        public bool consense { get; set; }
        public bool psdpt { get; set; }

        public string[] work = { "Service", "Reperation", "Syn", "Hjulskift", "Undervognsbehandling", "Andet" };
    }
}
