using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double yazili1=Convert.ToDouble(txtYazili1.Text);
            double yazili2=Convert.ToDouble(txtYazili2.Text);
            Ders ders = new Ders(yazili1, yazili2);
            txtOrtalama.Text = ders.Ortalama().ToString();

        }

        private void txtOrtalama_TextChanged(object sender, EventArgs e)
        {
            txtOrtalama.Enabled = false;

        }
    }
}
