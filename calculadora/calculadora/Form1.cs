using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        static operacoines juan = new operacoines();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxoperaciones.Text == "suma")
                lblResultado.Text = (juan.suma(double.Parse(txtvalor1.Text), double.Parse(txtvalor2.Text))).ToString();

            if (cbxoperaciones.Text == "resta")
                lblResultado.Text = (juan.resta(double.Parse(txtvalor1.Text), double.Parse(txtvalor2.Text))).ToString();

            if (cbxoperaciones.Text == "multiplicacion")
                lblResultado.Text = (juan.multiplicacion(double.Parse(txtvalor1.Text), double.Parse(txtvalor2.Text))).ToString();

            if (cbxoperaciones.Text == "division")
                lblResultado.Text = (juan.division(double.Parse(txtvalor1.Text), double.Parse(txtvalor2.Text))).ToString();

        }
    }
}
