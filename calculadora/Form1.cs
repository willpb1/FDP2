using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;

        public Form1()
        {
            InitializeComponent();

        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += boton.Text;
        }

        private void BtnResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = '\0';
            txtResultado.Text = "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";
            }
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtResultado.Text);
            Numero1 *= -1;
            txtResultado.Text = Numero1.ToString();
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtResultado.Text);
            Operador = '+';
            txtResultado.Text = (Numero1 + Numero2).ToString(); ;
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtResultado.Text);
            Operador = '-';
            txtResultado.Text = (Numero1 - Numero2).ToString();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtResultado.Text);
            Operador = '*';
      
            txtResultado.Text = "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtResultado.Text);
            Operador = '/';
          
            txtResultado.Text = "0";
        }


        private void btnResultado_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(txtResultado.Text);

            switch (Operador)
            {
                case '+':
                    txtResultado.Text = (Numero1 + Numero2).ToString();
                    break;
                case '-':
                    txtResultado.Text = (Numero1 - Numero2).ToString();
                    break;
                case '*':
                    txtResultado.Text = (Numero1 * Numero2).ToString();
                    break;
                case '/':
                    if (Numero2 != 0)
                        txtResultado.Text = (Numero1 / Numero2).ToString();
                    else
                        txtResultado.Text = "Error: División por cero";
                    break;
            }
        }


        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            Numero1 = Convert.ToDouble(txtResultado.Text);
            Operador = Convert.ToChar(boton.Tag);

            if (Operador == '²')
            {
                Numero1 = Math.Pow(Numero1, 2);
                txtResultado.Text = Numero1.ToString();
            }
            else if (Operador == '√')
            {
                Numero1 = Math.Sqrt(Numero1);
                txtResultado.Text = Numero1.ToString();
            }
            else
            {
                txtResultado.Text = "0";
            }
        }
    }
}

