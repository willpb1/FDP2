using System;

namespace loteria
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            String dinero = txtJugada.Text;
            int money = int.Parse(dinero);

            Random random = new Random();
            int numero1 = random.Next(1, 5);
            int numero2 = random.Next(1, 5);
            int numero3 = random.Next(1, 5);


            int valorJugada1 = int.Parse(txtJugada1.Text);
            int valorJugada2 = int.Parse(txtJugada2.Text);
            int valorJugada3 = int.Parse(txtJugada3.Text);

            int ganancias = 0;


            if (rbDosNumeros.Checked)
            {
                List<int> misnumeros = new List<int> { numero1, numero2 };
                List<int> misaciertos = new List<int> { valorJugada1, valorJugada2 };

                int acertados = misnumeros.Intersect(misaciertos).Count();
                ganancias = (money * acertados) * 1000;
            }
            else if (rbUnNumero.Checked)
            {
                if (numero3 == valorJugada3)
                {
                    ganancias = money * 1000;
                }
            }

            //Imprimir mensajes
            string mensajeNumeros = $"Números generados: {numero1}, {numero2},{numero3}";
            MessageBox.Show(mensajeNumeros);
            string mensajeGanancias = $"Ganancias totales: ${ganancias}";
            MessageBox.Show(mensajeGanancias);

            //Limpiar campos
            txtJugada1.Text = " ";
            txtJugada2.Text = " ";
            txtJugada3.Text = " ";
            txtJugada.Text = " ";
        }
    }
}