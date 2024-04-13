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
    public partial class frmAsignaturas : Form
    {
        public frmAsignaturas()
        {
            InitializeComponent();
        }

        private void consultarAsig_Click(object sender, EventArgs e)
        {
            try
            {
                Asignaturas asignaturas = new Asignaturas();
                DataTable dtAsignaturas = asignaturas.Consultar();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dtAsignaturas;
                MessageBox.Show("Consulta realizada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar las asignaturas: " + ex.Message);
            }
        }

        private void agregarAsig_Click(object sender, EventArgs e)
        {
            try
            {
                Asignaturas asignaturas = new Asignaturas();
                asignaturas.Nombre = txtNombreAsig.Text;
                asignaturas.AreaConocimiento = txtAreaAsig.Text;
                asignaturas.Titulacion = txtTitulacionAsig.Text;
                asignaturas.Tipo = txtTipoAsig.Text;
                asignaturas.Curso = int.Parse(txtCursoAsig.Text);
                asignaturas.CreditosTeoricos = int.Parse(txtCreditTeoAsig.Text);
                asignaturas.CreditosLaboratorio = int.Parse(txtCreditLabAsig.Text);
                asignaturas.LibreConfiguracion = txtConfigAsig.Text;
                asignaturas.IncompatibleCon = txtIncompatibleAsig.Text;
                asignaturas.Duracion = int.Parse(txtDuracionAsig.Text);
                asignaturas.LimiteAdmisionOpt = string.IsNullOrEmpty(txtAdmAsig.Text) ? null : (int?)int.Parse(txtAdmAsig.Text);
                asignaturas.AsignaturaOptativa = bool.Parse(txtOptAsig.Text);
                asignaturas.LibreConfiguracionOpt = bool.Parse(txtConfOptAsig.Text);
                asignaturas.GruposTeoria = txtGrupoTeoAsig.Text;
                asignaturas.GruposLaboratorio = txtGrupoLabAsig.Text;
                asignaturas.AsignaturasEquivalentes = txtEquivAsig.Text;
                asignaturas.Agregar();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = asignaturas.Consultar();
                MessageBox.Show("Asignatura agregada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la asignatura: " + ex.Message);
            }
        }

        private void EditarAsig_Click(object sender, EventArgs e)
        {
            try
            {
                Asignaturas asignaturas = new Asignaturas();
                asignaturas.Id = int.Parse(txtIdAsig.Text);
                asignaturas.Nombre = txtNombreAsig.Text;
                asignaturas.AreaConocimiento = txtAreaAsig.Text;
                asignaturas.Titulacion = txtTitulacionAsig.Text;
                asignaturas.Tipo = txtTipoAsig.Text;
                asignaturas.Curso = int.Parse(txtCursoAsig.Text);
                asignaturas.CreditosTeoricos = int.Parse(txtCreditTeoAsig.Text);
                asignaturas.CreditosLaboratorio = int.Parse(txtCreditLabAsig.Text);
                asignaturas.LibreConfiguracion = txtConfigAsig.Text;
                asignaturas.IncompatibleCon = txtIncompatibleAsig.Text;
                asignaturas.Duracion = int.Parse(txtDuracionAsig.Text);
                asignaturas.LimiteAdmisionOpt = string.IsNullOrEmpty(txtAdmAsig.Text) ? null : (int?)int.Parse(txtAdmAsig.Text);
                asignaturas.AsignaturaOptativa = bool.Parse(txtOptAsig.Text);
                asignaturas.LibreConfiguracionOpt = bool.Parse(txtConfOptAsig.Text);
                asignaturas.GruposTeoria = txtGrupoTeoAsig.Text;
                asignaturas.GruposLaboratorio = txtGrupoLabAsig.Text;
                asignaturas.AsignaturasEquivalentes = txtEquivAsig.Text;
                asignaturas.Editar();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = asignaturas.Consultar();
                MessageBox.Show("Asignatura editada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar la asignatura: " + ex.Message);
            }
        }

        private void EliminarAsig_Click(object sender, EventArgs e)
        {
            try
            {
                Asignaturas asignaturas = new Asignaturas();
                asignaturas.Id = int.Parse(txtIdAsig.Text);
                asignaturas.Eliminar();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = asignaturas.Consultar();
                MessageBox.Show("Asignatura eliminada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la asignatura: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ir al formulario Admin
            frmAdmin admin = new frmAdmin();
            admin.Show();
            this.Hide();
        }
    }
}
