using System;
using System.Windows.Forms;

namespace juego_tragamonedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonGirar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int ganador = random.Next(1, 4);

            if (ganador == 1)
            {
                imagenBox1.Image = Properties.Resources.moneda_ganadora;
            }
            else if (ganador == 2)
            {
                imagenBox2.Image = Properties.Resources.moneda_ganadora;
            }
            else if (ganador == 3)
            {
                imagenBox3.Image = Properties.Resources.moneda_ganadora;
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imagenBox1.Image == Properties.Resources.moneda_ganadora)
            {
                imagenBox1.Image = Properties.Resources.moneda;
            }
            else if (imagenBox2.Image == Properties.Resources.moneda_ganadora)
            {
                imagenBox2.Image = Properties.Resources.moneda;
            }
            else if (imagenBox3.Image == Properties.Resources.moneda_ganadora)
            {
                imagenBox3.Image = Properties.Resources.moneda;
            }

            timer1.Stop();
        }


        private void imagenBox1_Click(object sender, EventArgs e)
        {
            
        }


    }
}