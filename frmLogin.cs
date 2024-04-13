using DotNetEnv;
using AccesoDatos;
using LogicaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {

                // Verificar si el usuario es el administrador y mostrar un mensaje especial
                if (txtnombre.Text == "admin" && txtcontrasena.Text == "admin123")
                {
                    MessageBox.Show("Inicio de sesión exitoso como administrador");
                    // Ir al formulario Admin
                    frmAdmin admin = new frmAdmin();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    // Crear una instancia de la clase Students para acceder a la lógica de negocio
                    Students students = new Students();

                    // Obtener los usuarios de la base de datos
                    DataTable dtUsuarios = students.Consultar();

                    // Verificar si hay algún usuario con el nombre y la contraseña proporcionados
                    string nombreUsuario = txtnombre.Text;
                    string contraseña = txtcontrasena.Text;

                    bool usuarioValido = false;
                    foreach (DataRow row in dtUsuarios.Rows)
                    {
                        string nombre = row["Name"].ToString();
                        string contraseñaDB = row["Password"].ToString();
                        if (nombre == nombreUsuario && contraseña == contraseñaDB)
                        {
                            usuarioValido = true;
                            break;
                        }
                    }

                    // Verificar si el usuario es válido y mostrar un mensaje apropiado
                    if (usuarioValido)
                    {
                        MessageBox.Show("Inicio de sesión exitoso");
                        // Ir al formulario Estudiantes
                        frmEstudiantes estudiantes = new frmEstudiantes();
                        estudiantes.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");

                        // Limpiar los campos de texto solo si la autenticación falla
                        txtnombre.Text = "";
                        txtcontrasena.Text = "";
                        txtnombre.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el usuario: " + ex.Message);
            }
        }
    }
}
