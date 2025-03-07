using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyaGUI
{
    internal class Gazda
    {
        public int GazdaId { get; set; }
        public string GazdaNev { get; set; }
        public string GazdaTel { get; set; }

        public Gazda(int gazdaid, string gazdanev, string gazdatel)
        {
            GazdaId = gazdaid;
            GazdaNev = gazdanev;
            GazdaTel = gazdatel;
        }
    }
}
