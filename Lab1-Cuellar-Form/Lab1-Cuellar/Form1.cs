using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Cuellar
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string fecha = dateTimePicker1.Text;
            string depa = cmbDepa.Text;
            string cargo =cmbCargo.Text;
            dgvUsuarios.Rows.Add("U10023", nombre, apellido,direccion,telefono,email,fecha,depa,
                cargo,dni);

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
