using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyaGUI
{
    internal class Fajta
    {
        public int FajtaId { get; set; }
        public string FajtaNev { get; set; }

        public Fajta(int fajtaid, string fajtanev)
        {
            FajtaId = fajtaid;
            FajtaNev = fajtanev;
        }
    }
}
