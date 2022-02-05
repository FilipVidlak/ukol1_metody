using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_1_metody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Obsah(double a)
        {
            return a * a;
        }
        public double Obsah(double a, double b)
        {
            return a * b;
        }
        public double Objem(double a)
        {
            return a * a * a;
        }
        public double Objem(double a, double b, double c)
        {
            return a * b * c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Double.Parse(textBox1.Text);
                double b = Double.Parse(textBox2.Text);
                double c = Double.Parse(textBox3.Text);
                label10.Text = Obsah(a).ToString();
                label11.Text = Obsah(a, b).ToString();
                label12.Text = Objem(a).ToString();
                label13.Text = Objem(a, b, c).ToString();
            }
            catch {
                MessageBox.Show("Zadal jsi špatnou, žádnou nebo velkou hodnotu!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
   
}
