namespace StudentSystem
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Departamentos = new Button();
            Profesores = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            estudiantes = new Button();
            pictureBox2 = new PictureBox();
            Registro = new Button();
            Asignaturas = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Departamentos
            // 
            Departamentos.BackColor = SystemColors.MenuBar;
            Departamentos.Location = new Point(38, 124);
            Departamentos.Name = "Departamentos";
            Departamentos.Size = new Size(176, 49);
            Departamentos.TabIndex = 0;
            Departamentos.Text = "Departamentos";
            Departamentos.UseVisualStyleBackColor = false;
            Departamentos.Click += Departamentos_Click;
            // 
            // Profesores
            // 
            Profesores.BackColor = SystemColors.MenuBar;
            Profesores.Location = new Point(38, 236);
            Profesores.Name = "Profesores";
            Profesores.Size = new Size(176, 52);
            Profesores.TabIndex = 1;
            Profesores.Text = "Profesores";
            Profesores.UseVisualStyleBackColor = false;
            Profesores.Click += Profesores_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(estudiantes);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(Registro);
            panel1.Controls.Add(Asignaturas);
            panel1.Controls.Add(Departamentos);
            panel1.Controls.Add(Profesores);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 450);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 402);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 48);
            panel2.TabIndex = 6;
            // 
            // estudiantes
            // 
            estudiantes.Location = new Point(38, 348);
            estudiantes.Name = "estudiantes";
            estudiantes.Size = new Size(176, 48);
            estudiantes.TabIndex = 5;
            estudiantes.Text = "Estudiantes";
            estudiantes.UseVisualStyleBackColor = true;
            estudiantes.Click += estudiantes_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Logo;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(249, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Registro
            // 
            Registro.Location = new Point(38, 179);
            Registro.Name = "Registro";
            Registro.Size = new Size(176, 51);
            Registro.TabIndex = 3;
            Registro.Text = "Registro";
            Registro.UseVisualStyleBackColor = true;
            Registro.Click += Registro_Click;
            // 
            // Asignaturas
            // 
            Asignaturas.Location = new Point(38, 294);
            Asignaturas.Name = "Asignaturas";
            Asignaturas.Size = new Size(176, 48);
            Asignaturas.TabIndex = 2;
            Asignaturas.Text = "Asignaturas";
            Asignaturas.UseVisualStyleBackColor = true;
            Asignaturas.Click += Asignaturas_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.estudiantes__1_;
            pictureBox1.Location = new Point(246, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(557, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "frmAdmin";
            Text = "Panel Principal (Administracion)";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Departamentos;
        private Button Profesores;
        private Panel panel1;
        private Button Asignaturas;
        private PictureBox pictureBox1;
        private Button Registro;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button estudiantes;
    }
}