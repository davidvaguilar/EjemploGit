using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string numeroCredito = txtNumeroCredito.Text;
            int numero = 0;
            try
            {
                numero = Convert.ToInt32(numeroCredito);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtNumeroCredito.Text = "";
            }

            lblNumeroCredito.Text = numero.ToString();

            string nombre = txtNombre.Text;
            if( nombre.Length > 0)
            {
                MessageBox.Show("Debe ingresar un nombre valido");
            }

            string sueldo = txtSueldo.Text;
            double sueldo_dou = 0;
            try
            {
                sueldo_dou = Convert.ToDouble(sueldo);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtSueldo.Text = "";
                txtSueldo.BackColor = Color.Red;
            }

            string montoCredito = txtMonto.Text;
            double monto = 0;
            try
            {
                monto = Convert.ToInt32(montoCredito);
            }catch(Exception ex)
            {
                MessageBox.Show("Monto debe ser valor de tipo Numerico");
                txtMonto.Text = "";
                txtMonto.BackColor = Color.Red;
            }

            string cuota = txtCuota.Text;
            int cuota_int = 0;
            try
            {
                cuota_int = Convert.ToInt32(cuota);
            }catch(Exception ex)
            {
                MessageBox.Show("valor debe ser numero");
                txtCuota.Text = "";
                txtCuota.BackColor = Color.Red;
            }

            double maximoCredito = sueldo_dou * 1.5;


            if( monto <= maximoCredito)
            {
                if( cuota_int >= 6)
                {
                    float tasaInteres = 0;
                    double valorMensual = 0;
                    if( cuota_int <= 48)
                    {
                        tasaInteres = 1.85f / 12;
                    }
                    else
                    {
                        tasaInteres = 3.0f / 12;
                    }
                    valorMensual = monto * tasaInteres;

                    lblValorMensual.Text = Math.Round(valorMensual).ToString();
                    lblValorTotal.Text = (Math.Round(valorMensual * cuota_int)).ToString();

                }
                else
                {
                    MessageBox.Show("La cantidad de Cuota no puede ser menor a 6");
                }

            } else
            {
                MessageBox.Show("Ud no puede solicitar un monto tan grande");
            }
        }
    }
}
