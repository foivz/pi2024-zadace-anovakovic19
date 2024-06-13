using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Zadaca.models
{
    public class PovratnaInformacija
    {
        public int PovratnaInformacijaID { get; set; }
        public int JeloID { get; set; }
        public int OcjenaJela { get; set; }
        public int OcjenaKolicine { get; set; }
        public string Komentar { get; set; }
    }
}
