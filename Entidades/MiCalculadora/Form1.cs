using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.lblResultado.Text ="" ;
            this.cmbOperador.Text ="" ;
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static double Operar(string numero1,string numero2,string operador)
        {
            double resultado;
            Calculadora calcu = new Calculadora();
            Numero n1= new Numero(numero1);
            Numero n2 = new Numero(numero2);

            resultado = calcu.Operar(n1,n2,operador);
            return resultado;

        }
        private  void btnOperar_Click(object sender, EventArgs e)
        {
            string num1 = txtNumero1.Text;
            string num2 = txtNumero2.Text;
            string operador = cmbOperador.Text;
            double resultado = LaCalculadora.Operar(num1, num2, operador);
            lblResultado.Visible = true;
            lblResultado.Text = resultado.ToString();

        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
             string resultado = Numero.DecimalBinario(Convert.ToDouble(lblResultado.Text));
             lblResultado.Text = resultado;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
              string resultado = Numero.BinarioDecimal(lblResultado.Text);
              lblResultado.Text = resultado;
         }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
