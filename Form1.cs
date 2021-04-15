using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlasaKvadrat_SkolskiRad
{
    public partial class Form1 : Form
    {
        Color boja;
        int a;
        Kvadrat k;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox1.BackColor = colorDialog1.Color;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                a = int.Parse(textBox1.Text);
                boja = colorDialog1.Color;
                if (radioButton2.Checked)
                {
                    a = 20;
                }
                if (radioButton3.Checked)
                {
                    boja = Color.Red;
                }
                k = new Kvadrat(boja, a, e.Location);
                Refresh();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            k?.Crtaj(e.Graphics);
        }
    }
}
