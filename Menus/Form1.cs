using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close(); //Cierra
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa fue creado por Victor Larios","Acerca de...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarColor();
            label1.ForeColor = Color.Red;
            rojoToolStripMenuItem.Checked = true;
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarColor();
            label1.ForeColor = Color.Blue;
            azulToolStripMenuItem.Checked = true;
        }
        private void borrarColor()
        {
            rojoToolStripMenuItem.Checked = false;
            azulToolStripMenuItem.Checked = false;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comicsSansToolStripMenuItem.Checked = false;
            label1.Font = new Font("Times New Roman", 18, label1.Font.Style);
            timesNewRomanToolStripMenuItem.Checked = true;
        }

        private void comicsSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comicsSansToolStripMenuItem.Checked = true;
            label1.Font = new Font("Comic Sans MS", 18, label1.Font.Style);
            timesNewRomanToolStripMenuItem.Checked = false;
        }
    }
}
