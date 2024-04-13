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
    public partial class frmProfesores : Form
    {
        public frmProfesores()
        {
            InitializeComponent();
        }

        private void consultarProf_Click(object sender, EventArgs e)
        {
            try
            {
                Profesores profesores = new Profesores();
                DataTable dtprofesores = profesores.Consultar();
                dataGridView1.DataSource = dtprofesores;
                MessageBox.Show("Profesores consultados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los profesores: " + ex.Message);
            }
        }

        private void agregarProf_Click(object sender, EventArgs e)
        {
            try
            {
                Profesores profesores = new Profesores();
                
                if(string.IsNullOrEmpty(txtNombreProf.Text))
                {
                    MessageBox.Show("Por favor ingrese el nombre del profesor.");
                    return;
                }

                profesores.Nombre = txtNombreProf.Text;
                profesores.Despacho = txtDespachoProf.Text;
                profesores.Agregar();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = profesores.Consultar();

                MessageBox.Show("Profesor agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el profesor: " + ex.Message);
            }
        }

            private void editarProf_Click(object sender, EventArgs e)
        {
            try
            {
                Profesores profesores = new Profesores();

                if (string.IsNullOrEmpty(txtIdProf.Text))
                {
                    MessageBox.Show("Por favor seleccione un profesor para editarlo.");
                    return;
                }

                profesores.Id = int.Parse(txtIdProf.Text);
                profesores.Nombre = txtNombreProf.Text;
                profesores.Despacho = txtDespachoProf.Text;
                profesores.Editar();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = profesores.Consultar();

                MessageBox.Show("Profesor editado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el profesor: " + ex.Message);
            }
        }

        private void eliminarProf_Click(object sender, EventArgs e)
        {
            try
            {
                Profesores profesores = new Profesores();

                // Verificar si el Id del profesor está vacío
                if (string.IsNullOrEmpty(txtIdProf.Text))
                {
                    MessageBox.Show("Por favor seleccione un profesor para eliminarlo.");
                    return; // Salir del método sin eliminar el profesor
                }

                // Eliminar el profesor
                profesores.Id = int.Parse(txtIdProf.Text);
                profesores.Eliminar();

                // Actualizar el DataGridView con los profesores
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = profesores.Consultar();

                MessageBox.Show("Profesor eliminado correctamente.");

                // Limpiar las cajas de texto
                txtIdProf.Text = "";
                txtNombreProf.Text = "";
                txtDespachoProf.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el profesor: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // ir al formulario Admin
            frmAdmin admin = new frmAdmin();
            admin.Show();
            this.Hide();
        }
    }
}
