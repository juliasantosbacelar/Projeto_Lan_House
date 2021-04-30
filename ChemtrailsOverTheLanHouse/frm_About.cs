using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemtrailsOverTheLanHouse
{
    public partial class frm_About : Form
    {
        public frm_About()
        {
            InitializeComponent();
        }

        private void bt_EasterEgg2_Click(object sender, EventArgs e)
        {
            frm_EasterEgg2 easterEgg = new frm_EasterEgg2();

            easterEgg.ShowDialog();
        }
    }
}
