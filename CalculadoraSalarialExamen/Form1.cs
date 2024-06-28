using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSalarialExamen
{
    public partial class Form1 : Form
    {
        private CalculadoraSalarial calculadoraSalarial;

        public Form1()
        {
            InitializeComponent();
            calculadoraSalarial = new CalculadoraSalarial();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal salarioBruto;
            int cantidadHijos;
            bool tieneConyuge = chkTieneConyuge.Checked;

            if (decimal.TryParse(txtSalarioBruto.Text, out salarioBruto) &&
                int.TryParse(txtCantidadHijos.Text, out cantidadHijos))
            {
                decimal salarioNeto = calculadoraSalarial.CalcularSalarioNeto(salarioBruto, cantidadHijos, tieneConyuge);
                lblSalarioNeto.Text = $"Salario Neto: {salarioNeto:C}";
            }
            else
            {
                MessageBox.Show("Por favor ingrese valores válidos.");
            }
        }
    }
}
