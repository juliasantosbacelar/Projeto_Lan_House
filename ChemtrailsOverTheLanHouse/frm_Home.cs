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
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void bt_Computador_Click(object sender, EventArgs e)
        {
            frm_ComputerOrder pcOrder = new frm_ComputerOrder();

            pcOrder.ShowDialog();
        }

        private void bt_EasterEgg_Click(object sender, EventArgs e)
        {
            frm_EasterEgg easterEgg = new frm_EasterEgg();

            easterEgg.ShowDialog();

        }

        private void bt_Notebook_Click(object sender, EventArgs e)
        {
            frm_NotebookOrder notebookOrder = new frm_NotebookOrder();

            notebookOrder.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_About about = new frm_About();

            about.ShowDialog();
        }
    }
}
