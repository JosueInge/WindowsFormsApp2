using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (radioIva.Checked)
            {              
                double iva = 1.13;
                double cantidad = Convert.ToDouble(txtCantidad.Text);
                double resultado = iva * cantidad;
                txtResultado.Text = resultado.ToString();
                {
                               
                }
              
            }else
            {
                double iva = 1.13;
                double cantidad = Convert.ToDouble(txtCantidad.Text);
                double resultado = iva * cantidad;
                double cantidadiva = cantidad + resultado;
                txtResultado.Text = cantidadiva.ToString();
            }
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
