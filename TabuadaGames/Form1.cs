using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabuadaGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Contador = 0;
        int primeironumero = 0;
        int segundonumero  = 0;

        int acertos = 0;
        int erros = 0;

        int somatoria = 0;

        Random rdn = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            txtprimeiroNum.Enabled = false;
            txtsegundoNum.Enabled = false;
            txtResultado.Enabled = false;
            
            btnIniciar.Focus();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(btnIniciar.Text == "Iniciar")
            {
                timer1.Enabled = true;

                btnIniciar.Text = "Pause";
                txtResultado.Enabled = true;
                Ramdomica();
           
                txtResultado.Focus();
            }
            else
            {
                timer1.Enabled = false;
                btnIniciar.Text = "Iniciar";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval == 1000)
            {
                Contador = Contador + 1;
                lblTempo.Text = Convert.ToString(Contador);
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            txtprimeiroNum.Text = "";
            txtsegundoNum.Text = "";

            lblTempo.Text = Convert.ToString(0);
        }

        private void txtResultado_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Calculo();
                Ramdomica();
                txtResultado.Focus();
            }
        }
        private void Calculo()
        {
            somatoria = primeironumero * segundonumero;

            if (txtResultado.Text == Convert.ToString(somatoria))
            {
                acertos = acertos + 1;
                lblAcertos.Text = Convert.ToString(acertos);
            }
            else
            {
                erros = erros + 1;
                lblErros.Text = Convert.ToString(erros);
            }
            txtResultado.Text = "";
        }
        private void Ramdomica()
        {
            primeironumero = rdn.Next(1, 10);
            segundonumero = rdn.Next(1, 10);

            txtprimeiroNum.Text = Convert.ToString(primeironumero);
            txtsegundoNum.Text = Convert.ToString(segundonumero);
        }
    }
}
