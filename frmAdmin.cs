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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void Departamentos_Click(object sender, EventArgs e)
        {
            // ir al formulario Departamentos
            frmDept departamentos = new frmDept();
            departamentos.Show();
            this.Hide();
        }

        private void Registro_Click(object sender, EventArgs e)
        {
            // ir al formulario Registro
            frmRegistro registro = new frmRegistro();
            registro.Show();
            this.Hide();
        }

        private void Profesores_Click(object sender, EventArgs e)
        {
            // ir al formulario Profesores
            frmProfesores profesores = new frmProfesores();
            profesores.Show();
            this.Hide();
        }

        private void Asignaturas_Click(object sender, EventArgs e)
        {
            // ir al formulario Asignaturas
            frmAsignaturas asignaturas = new frmAsignaturas();
            asignaturas.Show();
            this.Hide();
        }

        private void estudiantes_Click(object sender, EventArgs e)
        {
            // ir a formulario DatosES
            frmDatosES datosES = new frmDatosES();
            datosES.Show();
            this.Hide();
        }
    }
}
