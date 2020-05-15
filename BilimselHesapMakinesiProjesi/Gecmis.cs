using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilimselHesapMakinesiProjesi
{
    public partial class Gecmis : Form
    {
        public Gecmis()
        {
            InitializeComponent();
        }

        private void Gecmis_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach(string item in Genel.gecmis)
            {
                richTextBox1.Text += item+"\n\n";
            }
        }

        private void geçmişiTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.gecmis.Clear();
            richTextBox1.Clear();
        }
    }
}
