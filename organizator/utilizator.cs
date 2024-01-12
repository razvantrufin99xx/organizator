using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organizator
{
    public class utilizator
    {
        public string nume = "numele";
        public string prenume = "prenumele";
        public string id = "001";

        public utilizator() { }

        public utilizator(string pnume, string pprenume, string pid) 
        { 
            this.nume = pnume;
            this.prenume = pprenume;
            this.id = pid;  
        }
    }
}
