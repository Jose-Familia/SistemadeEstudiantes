using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystem
{
    public partial class frmDatosES : Form
    {
        public frmDatosES()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ir al formulario Admin
            frmAdmin admin = new frmAdmin();
            admin.Show();
            this.Hide();
        }

        private void consultasDatosEs_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiantes estudiantes = new Estudiantes();
                DataTable dtestudiantes = estudiantes.Consultar();
                dataGridView1.DataSource = dtestudiantes;
                MessageBox.Show("Estudiantes consultados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los Estudiantes: " + ex.Message);
            }
        }
    }
}
