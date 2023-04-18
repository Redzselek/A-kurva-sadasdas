using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Txt2Srt
{
    class IdozitettFelirat
    {
        private string idozites;
        private string felirat;

        public IdozitettFelirat(string idozites, string felirat)
        {
            this.idozites = idozites;
            this.felirat = felirat;
        }

        public int SzavakSzama(string fi)
        {
            string[] st = fi.Split(' ');
            return st.Length;
        }

        public string Idozites { get => idozites; set => idozites = value; }
        public string Felirat { get => felirat; set => felirat = value; }

        public string SrtIdozites(string fi)
        {
            string kezd = fi.Substring(0, 5);
            string veg = fi.Substring(8, 5);
            int kperc = Convert.ToInt32(kezd.Substring(0, 2));
            int vperc = Convert.ToInt32(veg.Substring(0, 2));
            string ujkora, ujkperc, ujkmp, ujvora, ujvperc, ujvmp;

            if (kperc > 59)
            {
                ujkora = "01";
                if ((kperc - 60) < 10)
                {
                    ujkperc = "0" + kperc.ToString();
                }
                else
                {
                    ujkperc = kperc.ToString();
                }
            }
            else
            {
                ujkora = "00";
                ujkperc = kperc.ToString();
            }

            ujkmp = veg.Substring(3, 2);

            if (vperc > 59)
            {
                ujvora = "01";
                if ((vperc - 60) < 10)
                {
                    ujvperc = "0" + vperc.ToString();
                }
                else
                {
                    ujvperc = vperc.ToString();
                }
            }
            else
            {
                ujvora = "00";
                ujvperc = vperc.ToString();
            }
            ujvmp = veg.Substring(3, 2);

            string ujido = ujkora + ":" + ujkperc + ":" + ujkmp + "--->" + ujvora + ":" + ujvperc + ":" + ujvmp;
            return ujido;
        }
}       
