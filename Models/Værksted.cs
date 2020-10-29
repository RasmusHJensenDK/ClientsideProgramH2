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

        public string[] work = { "Service", "Reperation", "Syn", "Hjulskift", "Undervognsbehandling", "Andet" };

        public void InsertIntoDB()
        {
            DatabaseWrapper wrapper = new DatabaseWrapper("Server=01BIBME14RHJ;Database=ClientSideDB;Integrated Security=SSPI;persist security info=True;");
            wrapper.ExecuteQuery($"INSERT INTO dbo.arbejdskort (Navn,Email,Mobil,Nummerplads,Koert,Model,Afdeling,Arbejde) VALUES({Navn},{Email},{tlf},{NrPlader},{kilometer},{Model},{Afdeling},{workorder});");
        }
    }
}
