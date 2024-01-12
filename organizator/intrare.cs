using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organizator
{
    public class intrare
    {
        public string id = "001";
        public string denumire = "intrare noua";
        public string datasiora = "ZZ.LL.AAAA HH:MM:SS";
        public string informatii = "adaugati informatiile";
        public string comentariu = "adaugati un comentariu";
        public string domeniu = "domeniul";
        public string subdomeniu = "domeniul";
        public string importanta = "nivelul0";
        public string alearteazainainte = "5 secunde";
        public string soundalarm = "ALERTA.wav";

        public intrare() { }
        public intrare(
            string pid,
            string pdenumire,
            string pdatasiora,
            string pinformatii,
            string pcomentariu,
            string pdomeniu,
            string psubdomeniu,
            string pimportanta,
            string palearteazainainte,
            string psoundalarm

            ) 
        {
            this.id = pid;
            this.denumire = pdenumire;
            this.datasiora = pdatasiora;
            this.informatii = pinformatii;
            this.comentariu = pcomentariu;
            this.domeniu = pdomeniu;
            this.subdomeniu = psubdomeniu;
            this.importanta = pimportanta;
            this.alearteazainainte = palearteazainainte;
            this.soundalarm = psoundalarm;
        }
    }
}
