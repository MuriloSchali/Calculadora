using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v3_Janaine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Limpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            label1.Text = (" ");
            
        }

        private void Soma_Click(object sender, EventArgs e)
        {
            double valor1;
            double valor2;
            double resultado;

            valor1 = double.Parse(textBox1.Text);
            valor2 = double.Parse(textBox2.Text);
            //Conversão = String para Double

            resultado = valor1 + valor2;
            label1.Text = resultado.ToString();
            // Conversão Double para String
        }

        private void Subtração_Click(object sender, EventArgs e)
        {
            double valor1;
            double valor2;
            double resultado;

            valor1 = double.Parse(textBox1.Text);
            valor2 = double.Parse(textBox2.Text);

            resultado = valor1 - valor2;
            label1.Text = resultado.ToString();

        }

        private void Multiplicação_Click(object sender, EventArgs e)
        {
            double valor1;
            double valor2;
            double resultado;

            valor1 = double.Parse(textBox1.Text);
            valor2 = double.Parse(textBox2.Text);

            resultado = valor1 * valor2;
            label1.Text = resultado.ToString();

        }

        private void Divisão_Click(object sender, EventArgs e)
        {
            double valor1;
            double valor2;
            double resultado;

            valor1 = double.Parse(textBox1.Text);
            valor2 = double.Parse(textBox2.Text);

            resultado = valor1 / valor2;
            label1.Text = resultado.ToString();

            if (valor2 == 0)
            {

                MessageBox.Show("Não é possível dividir por Zero :( ");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            
















        }
    }
}
