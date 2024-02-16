using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicación_Windows_2
{
    public partial class formDatosPersonales : Form
    {
        public formDatosPersonales()
        {
            InitializeComponent();
        }
        private void tboxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tboxApellido.Text == "")
            {
                MessageBox.Show("Completa todas las casillas antes de continuar");
                tboxApellido.BackColor = Color.Red;
                return;
            }
            else if (tboxNombre.Text == "")
            {
                MessageBox.Show("Completa todas las casillas antes de continuar");
                tboxNombre.BackColor = Color.Red;
                return;
            }
            else if (tboxDireccion.Text == "")
            {
                MessageBox.Show("Completa todas las casillas antes de continuar");
                tboxDireccion.BackColor = Color.Red;
                return;
            }
            else if (tboxEdad.Text == "")
            {
                MessageBox.Show("Completa todas las casillas antes de continuar");
                tboxEdad.BackColor = Color.Red;
                return;
            }

            string resultado = "Nombre completo: " + tboxNombre.Text.ToUpper() + " " + tboxApellido.Text.ToUpper() + " Edad: " + tboxEdad.Text + " Dirección: " + tboxDireccion.Text.ToUpper();
            tboxResultado.Text = resultado;
            tboxApellido.BackColor = Color.White;
            tboxNombre.BackColor= Color.White;
            tboxEdad.BackColor= Color.White;
            tboxDireccion.BackColor= Color.White;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
