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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void guardarRegs_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de la clase Estudiantes
                Estudiantes estudiante = new Estudiantes();

                // Obtener los valores de los campos de estudiante
                string nombreEstudiante = txtNombreRegs.Text;
                string apellidoEstudiante = txtApellidoRegs.Text;
                int edadEstudiante = Convert.ToInt32(txtEdadRegs.Text);
                DateTime fechaNacimientoEstudiante = txtDateRegs.Value;
                char sexoEstudiante = Convert.ToChar(txtSexoRegs.Text);
                string correoEstudiante = txtCorreoRegs.Text;

                // Asignar los valores a la instancia de Estudiantes
                estudiante.Nombre = nombreEstudiante;
                estudiante.Apellido = apellidoEstudiante;
                estudiante.Edad = edadEstudiante;
                estudiante.FechaNacimiento = fechaNacimientoEstudiante;
                estudiante.Sexo = sexoEstudiante;
                estudiante.Correo = correoEstudiante;

                // Llamar al método Agregar de Estudiantes para guardar el estudiante en la base de datos
                estudiante.Agregar();

                // Crear una instancia de la clase Students
                Students student = new Students();

                // Obtener los valores de los campos de usuario
                string nombreUsuario = txtUsuarioRegs.Text;
                string contraseñaUsuario = txtContraseñaRegs.Text;

                // Asignar los valores a la instancia de Students
                student.Name = nombreUsuario;
                student.Password = contraseñaUsuario;

                // Llamar al método Agregar de Students para guardar el usuario en la base de datos
                student.Agregar();

                MessageBox.Show("Estudiante y usuario agregados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar estudiante y usuario: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ir a formulario Admin
            frmAdmin admin = new frmAdmin();
            admin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ir a formulario DatosES
            frmDatosES datosES = new frmDatosES();
            datosES.Show();
            this.Hide();
        }
    }
}
