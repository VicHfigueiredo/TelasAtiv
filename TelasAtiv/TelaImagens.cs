using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasAtiv
{
    public partial class TelaImagens : Form
    {
        public TelaImagens()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivos png |*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pnl1.ImageLocation = openFileDialog1.FileName;
                
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivos png |*png";
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                pnl2.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivos png |*png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pnl3.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void pnl1_Click(object sender, EventArgs e)
        {

        }
    }
}
