using System;
using System.Web.UI;
using static Operation.Operation;

namespace Calculadora
{
    public partial class _Default : Page
    {
        Operation.Operation op = new Operation.Operation();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sumar_Click(object sender, EventArgs e)
        {
            try
            {
                Resultado.Text = op.Suma(Numero1.Text, Numero2.Text).ToString();
            }
            catch
            {
                Resultado.Text = "";
                ErrorMessage.Text = "No se puede realizar la operacion";
            }
        }

        protected void Dividir_Click(object sender, EventArgs e)
        {
            try
            {
                Resultado.Text = op.Dividir(Numero1.Text, Numero2.Text).ToString();
            }
            catch
            {
                Resultado.Text = "";
                ErrorMessage.Text = "No se puede realizar la operacion";
            }
        }

        protected void Multiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                Resultado.Text = op.Multiplicar(Numero1.Text, Numero2.Text).ToString();
            }
            catch
            {
                Resultado.Text = "";
                ErrorMessage.Text = "No se puede realizar la operacion";
            }
        }

        protected void Restar_Click(object sender, EventArgs e)
        {
            try
            {
                Resultado.Text = op.Resta(Numero1.Text, Numero2.Text).ToString();
            }
            catch
            {
                Resultado.Text = "";
                ErrorMessage.Text = "No se puede realizar la operacion";
            }
        }
    }
}