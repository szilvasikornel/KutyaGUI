using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyaGUI
{
    internal class Kutya
    {
        public DateTime ChipDatum { get; set; }
        public Fajta Fajta { get; set; }
        public Gazda Gazda { get; set; }
        public int Id { get; set; }
        public bool Kan { get; set; }
        public string KepUrl { get; set; }
        public int Kor { get; set; }
        public string Nev { get; set; }

        public Kutya(int id, string nev, bool kan, int kor, DateTime chipDatum, string kepUrl, Fajta fajta, Gazda gazda)
        {
            ChipDatum = chipDatum;
            Fajta = fajta;
            Gazda = gazda;
            Id = id;
            Kan = kan;
            KepUrl = kepUrl;
            Kor = kor;
            Nev = nev;
        }

        public override string ToString()
        {
            string valami = string.Empty;
            if (Kan) {
                valami = "Kan";
            }
            else
            {
                valami = "Szuka";
            }

            return $"{valami}\n"
                +  $"Fajta: {Fajta.FajtaNev}\n"
                +  $"Gazda: {Gazda.GazdaNev}\n"
                +  $"Telefon: {Gazda.GazdaTel}\n"
                +  $"Kor: {Kor} éves\n"
                +  $"Chippelés: {ChipDatum.Year}.{ChipDatum.Month}.{ChipDatum.Day}.";
        }
    }
}
