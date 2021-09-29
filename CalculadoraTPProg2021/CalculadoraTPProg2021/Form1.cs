using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTPProg2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double valor1;
        private double valor2;
        private double resultado;
        private int operacion;

        private void btnCero_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + ",";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(tbDisplay.Text);

            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    resultado = valor1 / valor2;
                    break;
                default:
                    break;
            }

            tbDisplay.Text = resultado.ToString();
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "9";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = 1;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = 2;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = 3;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operacion = 4;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "";
        }
    }
}
/*public Form1()
        {
            InitializeComponent();
        }

        private double valor1;
        private double valor2;
        private double resultado;
        private int operacion;

        private void button16_Click(object sender, EventArgs e)
        {
            //Boton Igual
            valor2 = Convert.ToDouble(tbDisplay.Text);

            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    resultado = valor1 / valor2;
                    break;
                default:
                    break;
            }

            tbDisplay.Text = resultado.ToString();
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "0";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = 1;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = 2;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";

        }

        private void btnMultriplicacion_Click(object sender, EventArgs e)
        {
            operacion = 3;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operacion = 4;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + ".";
        }
*/
