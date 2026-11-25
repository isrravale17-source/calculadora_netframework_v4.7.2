using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Pasante
{
    public partial class Calculadora_basica : Form
    {
        // Definición de números
        double numero1 = 0;
        double numero2 = 0;
        string operacion = "";
        
        public Calculadora_basica()
        {
            InitializeComponent();
        }

        private void Calculadora_basica_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Text += "0";
        }

        private void button_pto_Click(object sender, EventArgs e)
        {
            if (!textBox_Pantalla.Text.Contains("."))
            {
                textBox_Pantalla.Text += ".";
            }
        }

        private void button_sum_Click(object sender, EventArgs e)
        {
            if (textBox_Pantalla.Text == "") 
            {
                MessageBox.Show("Ingrese número");
                return;
            }
            numero1 = Convert.ToDouble(textBox_Pantalla.Text);
            operacion = "+";
            textBox_Pantalla.Clear();
        }

        private void button_rest_Click(object sender, EventArgs e)
        {
            if (textBox_Pantalla.Text == "")
            {
                MessageBox.Show("Ingrese número");
                return;
            }
            numero1 = Convert.ToDouble(textBox_Pantalla.Text);
            operacion = "-";
            textBox_Pantalla.Clear();
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            if (textBox_Pantalla.Text == "")
            {
                MessageBox.Show("Ingrese número");
                return;
            }
            numero1 = Convert.ToDouble(textBox_Pantalla.Text);
            operacion = "*";
            textBox_Pantalla.Clear() ;
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            if (textBox_Pantalla.Text == "")
            {
                MessageBox.Show("Ingrese número");
                return;
            }
            numero1 = Convert.ToDouble(textBox_Pantalla.Text) ;
            operacion = "/";
            textBox_Pantalla.Clear() ;
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(textBox_Pantalla.Text);
            double resultado = 0;
            switch (operacion) 
            {
                case "+":
                    resultado = numero1 + numero2 ; 
                    break;

                case "-":
                    resultado = numero1 - numero2 ;
                    break;

                case "*":
                    resultado = (numero1 * numero2) ;
                    break;

                case "/":
                    if (numero2 == 0) 
                    {
                        MessageBox.Show("No se vuede dividir para 0");
                            return;
                    }
                    resultado = (numero2 / numero1) ;
                    break;
            }
            textBox_Pantalla.Text = resultado.ToString() ;
        }

        private void button_borrar_Click(object sender, EventArgs e)
        {
            textBox_Pantalla.Clear();

            numero1 = 0;
            numero2 = 0;
            operacion = "";
        }
    }
}
