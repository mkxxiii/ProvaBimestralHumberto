using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace ProvaBimestral.Models
{
    public class Eleicao
    {
        public int Id { get; set; }
        
        public string NomeCanditado { get; set; }
        
        public string Partido { get; set; }
        
        public string Cargo { get; set; }

        public string Foto { get; set; }
    }
}
