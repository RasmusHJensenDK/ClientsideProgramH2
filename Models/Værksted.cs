using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ClientsideH2.Repositories;
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
        public string tlf { get; set; }
        public string NrPlader { get; set; }
        public string kilometer { get; set; }
        public string workorder { get; set; }
        public string consense { get; set; }

        public string psdpt { get; set; }

        public string[] work = { "Service", "Reperation", "Syn", "Hjulskift", "Undervognsbehandling", "Andet" };
    }
}
