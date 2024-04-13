using AccesoDatos;
using System.Data;
using System.Data.SqlClient;

namespace LogicaNegocio
{
    public class Students
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }

        public void Agregar()
        {
            try
            {
                DBContext db = new DBContext();
                SqlCommand cmd = new SqlCommand();
                string sql = "INSERT INTO tbUsuarios (Name, Password) VALUES (@Name, @Password)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Password", Password);

                db.Ejecutar(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar usuario a la base de datos", ex);
            }
        }

        public DataTable Consultar()
        {
            try
            {
                DBContext db = new DBContext();
                DataTable dt = new DataTable();
                string sql = "SELECT Name, Password FROM tbUsuarios";
                SqlCommand cmd = new SqlCommand(sql);
                dt = db.Consultar(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar la base de datos", ex);
            }
        }
    }

    public class Departamentos
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }

        public DataTable Consultar()
        {
            try
            {
                DBContext db = new DBContext();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                string sql = "SELECT Id, Nombre, Descripcion FROM tbDepartamentos";
                if (Id > 0)
                {
                    sql = "SELECT Id, Nombre, Descripcion FROM tbDepartamentos Where id=@Id";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Id",Id);
                }
                else
                {
                    cmd.CommandText = sql;
                }
                dt = db.Consultar(cmd);
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar la base de datos", ex);
            }
        }

        public void Agregar()
        {
            try
            {
                DBContext db = new DBContext();
                SqlCommand cmd = new SqlCommand();
                string sql = "INSERT Into tbDepartamentos (Nombre, Descripcion) values(@Nombre, @Descripcion)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);

                db.Ejecutar(cmd);

            }

            catch (Exception ex)
            {
                throw new Exception("Error al consultar la base de datos", ex);
            }
        }

        public void Editar()
        {
            try
            {
                DBContext db = new DBContext();
                SqlCommand cmd = new SqlCommand();
                string sql = "UPDATE tbDepartamentos SET Nombre = @Nombre, Descripcion = @Descripcion WHERE Id = @Id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@Id", Id);

                db.Ejecutar(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el departamento", ex);
            }
        }

        public void Eliminar()
        {
            try
            {
                DBContext db = new DBContext();
                SqlCommand cmd = new SqlCommand();
                string sql = "Delete from tbDepartamentos WHERE Id = @Id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Id", Id);

                db.Ejecutar(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el departamento", ex);
            }
        }

    }

    public class Estudiantes
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char Sexo { get; set; }
        public string? Correo { get; set; }

        public DataTable Consultar()
        {
            try
            {
                DBContext db = new DBContext();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                string sql = "SELECT Id, Nombre, Apellido, Edad, FechaNacimiento, Sexo, Correo FROM tbEstudiantes";
                if (Id > 0)
                {
                    sql = "SELECT Id, Nombre, Apellido, Edad, FechaNacimiento, Sexo, Correo FROM tbEstudiantes WHERE Id = @Id";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Id", Id);
                }
                else
                {
                    cmd.CommandText = sql;
                }
                dt = db.Consultar(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar la base de datos", ex);
            }
        }

        public void Agregar()
        {
            try
            {
                DBContext db = new DBContext();
                SqlCommand cmd = new SqlCommand();
                string sql = "INSERT INTO tbEstudiantes (Nombre, Apellido, Edad, FechaNacimiento, Sexo, Correo) VALUES (@Nombre, @Apellido, @Edad, @FechaNacimiento, @Sexo, @Correo)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Apellido", Apellido);
                cmd.Parameters.AddWithValue("@Edad", Edad);
                cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
                cmd.Parameters.AddWithValue("@Sexo", Sexo);
                cmd.Parameters.AddWithValue("@Correo", Correo);

                db.Ejecutar(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar estudiante a la base de datos", ex);
            }
        }

        public void Editar()
        {
            try
            {
                DBContext db = new DBContext();
                SqlCommand cmd = new SqlCommand();
                string sql = "UPDATE tbEstudiantes SET Nombre = @Nombre, Apellido = @Apellido, Edad = @Edad, FechaNacimiento = @FechaNacimiento, Sexo = @Sexo, Correo = @Correo WHERE Id = @Id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Apellido", Apellido);
                cmd.Parameters.AddWithValue("@Edad", Edad);
                cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
                cmd.Parameters.AddWithValue("@Sexo", Sexo);
                cmd.Parameters.AddWithValue("@Correo", Correo);
                cmd.Parameters.AddWithValue("@Id", Id);

                db.Ejecutar(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar estudiante en la base de datos", ex);
            }
        }

        public void Eliminar()
        {
            try
            {
                DBContext db = new DBContext();
                SqlCommand cmd = new SqlCommand();
                string sql = "DELETE FROM tbEstudiantes WHERE Id = @Id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Id", Id);

                db.Ejecutar(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar estudiante de la base de datos", ex);
            }
        }
    }

    public class Profesores
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Despacho { get; set; }

        public DataTable Consultar()
        {
            try
            {
                DBContext db = new DBContext();
                DataTable dt = new DataTable();
                string sql = "SELECT Id, Nombre, Despacho FROM tbProfesores";
                if (Id > 0)
                {
                    sql += " WHERE Id = @Id";
                }
                SqlCommand cmd = new SqlCommand(sql);
                if (Id > 0)
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                }
                dt = db.Consultar(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar la base de datos", ex);
            }
        }

        public void Agregar()
        {
            try
            {
                DBContext db = new DBContext();
                SqlCommand cmd = new SqlCommand();
                string sql = "INSERT INTO tbProfesores (Nombre, Despacho) VALUES (@Nombre, @Despacho)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Despacho", Despacho);
                db.Ejecutar(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el profesor", ex);
            }
        }

        public void Editar()
        {
            try
            {
                DBContext db = new DBContext();
                SqlCommand cmd = new SqlCommand();
                string sql = "UPDATE tbProfesores SET Nombre = @Nombre, Despacho = @Despacho WHERE Id = @Id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Despacho", Despacho);
                cmd.Parameters.AddWithValue("@Id", Id);
                db.Ejecutar(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el profesor", ex);
            }
        }

        public void Eliminar()
        {
            try
            {
                DBContext db = new DBContext();
                SqlCommand cmd = new SqlCommand();
                string sql = "DELETE FROM tbProfesores WHERE Id = @Id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Id", Id);
                db.Ejecutar(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el profesor", ex);
            }
        }
    }

    public class Asignaturas
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? AreaConocimiento { get; set; }
        public string? Titulacion { get; set; }
        public string? Tipo { get; set; }
        public int Curso { get; set; }
        public int CreditosTeoricos { get; set; }
        public int CreditosLaboratorio { get; set; }
        public string? LibreConfiguracion { get; set; }
        public string? IncompatibleCon { get; set; }
        public int Duracion { get; set; }
        public int? LimiteAdmisionOpt { get; set; }
        public bool AsignaturaOptativa { get; set; }
        public bool LibreConfiguracionOpt { get; set; }
        public string? GruposTeoria { get; set; }
        public string? GruposLaboratorio { get; set; }
        public string? AsignaturasEquivalentes { get; set; }

        public DataTable Consultar()
        {
            try
            {
                DBContext db = new DBContext();
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tbAsignaturas";
                SqlCommand cmd = new SqlCommand(sql);
                dt = db.Consultar(cmd);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar la base de datos", ex);
            }
        }

        public void Agregar()
        {
            try
            {
                DBContext db = new DBContext();
                SqlCommand cmd = new SqlCommand();
                string sql = @"INSERT INTO tbAsignaturas (Nombre, AreaConocimiento, Titulacion, 
                          Tipo, Curso, CreditosTeoricos, CreditosLaboratorio, LibreConfiguracion, 
                          IncompatibleCon, Duracion, LimiteAdmisionOpt, AsignaturaOptativa, 
                          LibreConfiguracionOpt, GruposTeoria, GruposLaboratorio, AsignaturasEquivalentes) 
                          VALUES (@Nombre, @AreaConocimiento, @Titulacion, @Tipo, @Curso, 
                          @CreditosTeoricos, @CreditosLaboratorio, @LibreConfiguracion, 
                          @IncompatibleCon, @Duracion, @LimiteAdmisionOpt, @AsignaturaOptativa, 
                          @LibreConfiguracionOpt, @GruposTeoria, @GruposLaboratorio, @AsignaturasEquivalentes)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@AreaConocimiento", AreaConocimiento);
                cmd.Parameters.AddWithValue("@Titulacion", Titulacion);
                cmd.Parameters.AddWithValue("@Tipo", Tipo);
                cmd.Parameters.AddWithValue("@Curso", Curso);
                cmd.Parameters.AddWithValue("@CreditosTeoricos", CreditosTeoricos);
                cmd.Parameters.AddWithValue("@CreditosLaboratorio", CreditosLaboratorio);
                cmd.Parameters.AddWithValue("@LibreConfiguracion", LibreConfiguracion);
                cmd.Parameters.AddWithValue("@IncompatibleCon", IncompatibleCon);
                cmd.Parameters.AddWithValue("@Duracion", Duracion);
                cmd.Parameters.AddWithValue("@LimiteAdmisionOpt", LimiteAdmisionOpt ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@AsignaturaOptativa", AsignaturaOptativa);
                cmd.Parameters.AddWithValue("@LibreConfiguracionOpt", LibreConfiguracionOpt);
                cmd.Parameters.AddWithValue("@GruposTeoria", GruposTeoria);
                cmd.Parameters.AddWithValue("@GruposLaboratorio", GruposLaboratorio);
                cmd.Parameters.AddWithValue("@AsignaturasEquivalentes", AsignaturasEquivalentes);
                db.Ejecutar(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la asignatura", ex);
            }
        }

        public void Editar()
        {
            try
            {
                DBContext db = new DBContext();
                SqlCommand cmd = new SqlCommand();
                string sql = @"UPDATE tbAsignaturas SET Nombre = @Nombre, 
                          AreaConocimiento = @AreaConocimiento, Titulacion = @Titulacion, 
                          Tipo = @Tipo, Curso = @Curso, CreditosTeoricos = @CreditosTeoricos, 
                          CreditosLaboratorio = @CreditosLaboratorio, LibreConfiguracion = @LibreConfiguracion, 
                          IncompatibleCon = @IncompatibleCon, Duracion = @Duracion, LimiteAdmisionOpt = @LimiteAdmisionOpt, 
                          AsignaturaOptativa = @AsignaturaOptativa, LibreConfiguracionOpt = @LibreConfiguracionOpt, 
                          GruposTeoria = @GruposTeoria, GruposLaboratorio = @GruposLaboratorio, 
                          AsignaturasEquivalentes = @AsignaturasEquivalentes WHERE Id = @Id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@AreaConocimiento", AreaConocimiento);
                cmd.Parameters.AddWithValue("@Titulacion", Titulacion);
                cmd.Parameters.AddWithValue("@Tipo", Tipo);
                cmd.Parameters.AddWithValue("@Curso", Curso);
                cmd.Parameters.AddWithValue("@CreditosTeoricos", CreditosTeoricos);
                cmd.Parameters.AddWithValue("@CreditosLaboratorio", CreditosLaboratorio);
                cmd.Parameters.AddWithValue("@LibreConfiguracion", LibreConfiguracion);
                cmd.Parameters.AddWithValue("@IncompatibleCon", IncompatibleCon);
                cmd.Parameters.AddWithValue("@Duracion", Duracion);
                cmd.Parameters.AddWithValue("@LimiteAdmisionOpt", LimiteAdmisionOpt ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@AsignaturaOptativa", AsignaturaOptativa);
                cmd.Parameters.AddWithValue("@LibreConfiguracionOpt", LibreConfiguracionOpt);
                cmd.Parameters.AddWithValue("@GruposTeoria", GruposTeoria);
                cmd.Parameters.AddWithValue("@GruposLaboratorio", GruposLaboratorio);
                cmd.Parameters.AddWithValue("@AsignaturasEquivalentes", AsignaturasEquivalentes);
                cmd.Parameters.AddWithValue("@Id", Id);
                db.Ejecutar(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar la asignatura", ex);
            }
        }

        public void Eliminar()
        {
            try
            {
                DBContext db = new DBContext();
                SqlCommand cmd = new SqlCommand();
                string sql = "DELETE FROM tbAsignaturas WHERE Id = @Id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Id", Id);
                db.Ejecutar(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la asignatura", ex);
            }
        }
    }

}
