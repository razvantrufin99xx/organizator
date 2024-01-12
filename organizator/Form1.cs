using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organizator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public organizatorul O1 = new organizatorul();
        private void Form1_Load(object sender, EventArgs e)
        {
            O1.utilizatori.Add(new utilizator("trufin", "razvan", "000"));
            O1.intrarile.Add(new intrari());
            O1.intrarile[0].intrarile.Add(new intrare("000","ziua de nastere mama","08.06.1938","ziua mamei mele Trufin Maria nascuta Trif decedata la 19 aprilie 2020","ziua lui mamica","onomastici","familie","nivel 0","24*60*60","ALARMA.wav"));


        }
    }
}
