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
    public partial class frmDept : Form
    {
        public frmDept()
        {
            InitializeComponent();
        }

        private void consultarDept_Click(object sender, EventArgs e)
        {
            try
            {
                Departamentos departamentos = new Departamentos();

                // Verificar si el Id del departamento está vacío
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Por favor seleccione un departamento para editarlo.");
                    return; // Salir del método sin editar el departamento
                }

                // Editar el departamento existente
                departamentos.Id = int.Parse(txtId.Text);
                departamentos.Nombre = txtNombre.Text;
                departamentos.Descripcion = txtDescripcion.Text;
                departamentos.Editar();

                // Actualizar el DataGridView con los departamentos
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = departamentos.Consultar();

                MessageBox.Show("Departamento editado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el departamento: " + ex.Message);
            }

        }

        private void eliminarDept_Click(object sender, EventArgs e)
        {
            try
            {
                Departamentos departamentos = new Departamentos();

                if (string.IsNullOrEmpty(txtId.Text))
                {
                    departamentos.Id = -1;
                }
                else
                {
                    departamentos.Id = int.Parse(txtId.Text);
                }

                departamentos.Eliminar();
                MessageBox.Show("Departamento eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la base de datos", ex.Message);
            }
        }

        private void consultarDept_Click_1(object sender, EventArgs e)
        {
            try
            {
                Departamentos departamentos = new Departamentos();
                DataTable dtDepartamentos = departamentos.Consultar();
                dataGridView1.DataSource = dtDepartamentos;
                MessageBox.Show("Consulta realizada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la base de datos: " + ex.Message);
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ir al formulario Admin
            frmAdmin admin = new frmAdmin();
            admin.Show();
            this.Hide();
        }

        private void agregarDept_Click(object sender, EventArgs e)
        {
            try
            {
                Departamentos departamentos = new Departamentos();

                // Verificar si el nombre del departamento está vacío
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Por favor ingrese el nombre del departamento.");
                    return; // Salir del método sin agregar el departamento
                }

                // Agregar un nuevo departamento
                departamentos.Nombre = txtNombre.Text;
                departamentos.Descripcion = txtDescripcion.Text;
                departamentos.Agregar();

                // Actualizar el DataGridView con los departamentos
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = departamentos.Consultar();

                MessageBox.Show("Departamento agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el departamento: " + ex.Message);
            }
        }
    }
}



