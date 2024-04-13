namespace StudentSystem
{
    partial class frmRegistro
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
            guardarRegs = new Button();
            panel1 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            nombreRegs = new Label();
            apellidoRegs = new Label();
            edadRegs = new Label();
            nacimientoRegs = new Label();
            sexoRegs = new Label();
            CorreoRegs = new Label();
            txtNombreRegs = new TextBox();
            txtDateRegs = new DateTimePicker();
            txtApellidoRegs = new TextBox();
            txtEdadRegs = new TextBox();
            txtCorreoRegs = new TextBox();
            txtSexoRegs = new TextBox();
            panel4 = new Panel();
            label1 = new Label();
            userRegs = new Label();
            passwordRegs = new Label();
            txtUsuarioRegs = new TextBox();
            txtContraseñaRegs = new TextBox();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // guardarRegs
            // 
            guardarRegs.Location = new Point(32, 187);
            guardarRegs.Name = "guardarRegs";
            guardarRegs.Size = new Size(180, 49);
            guardarRegs.TabIndex = 0;
            guardarRegs.Text = "Guardar";
            guardarRegs.UseVisualStyleBackColor = true;
            guardarRegs.Click += guardarRegs_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(guardarRegs);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 452);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(76, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(249, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(555, 65);
            panel3.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.documento;
            pictureBox1.Location = new Point(0, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(249, 418);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 34);
            panel2.TabIndex = 5;
            // 
            // nombreRegs
            // 
            nombreRegs.AutoSize = true;
            nombreRegs.Location = new Point(297, 85);
            nombreRegs.Name = "nombreRegs";
            nombreRegs.Size = new Size(67, 20);
            nombreRegs.TabIndex = 6;
            nombreRegs.Text = "Nombre:";
            // 
            // apellidoRegs
            // 
            apellidoRegs.AutoSize = true;
            apellidoRegs.Location = new Point(297, 126);
            apellidoRegs.Name = "apellidoRegs";
            apellidoRegs.Size = new Size(69, 20);
            apellidoRegs.TabIndex = 7;
            apellidoRegs.Text = "Apellido:";
            // 
            // edadRegs
            // 
            edadRegs.AutoSize = true;
            edadRegs.Location = new Point(297, 170);
            edadRegs.Name = "edadRegs";
            edadRegs.Size = new Size(46, 20);
            edadRegs.TabIndex = 8;
            edadRegs.Text = "Edad:";
            // 
            // nacimientoRegs
            // 
            nacimientoRegs.AutoSize = true;
            nacimientoRegs.Location = new Point(297, 209);
            nacimientoRegs.Name = "nacimientoRegs";
            nacimientoRegs.Size = new Size(149, 20);
            nacimientoRegs.TabIndex = 9;
            nacimientoRegs.Text = "Fecha de nacimiento:";
            // 
            // sexoRegs
            // 
            sexoRegs.AutoSize = true;
            sexoRegs.Location = new Point(297, 252);
            sexoRegs.Name = "sexoRegs";
            sexoRegs.Size = new Size(44, 20);
            sexoRegs.TabIndex = 10;
            sexoRegs.Text = "Sexo:";
            // 
            // CorreoRegs
            // 
            CorreoRegs.AutoSize = true;
            CorreoRegs.Location = new Point(297, 294);
            CorreoRegs.Name = "CorreoRegs";
            CorreoRegs.Size = new Size(57, 20);
            CorreoRegs.TabIndex = 11;
            CorreoRegs.Text = "Correo:";
            // 
            // txtNombreRegs
            // 
            txtNombreRegs.Location = new Point(390, 78);
            txtNombreRegs.Name = "txtNombreRegs";
            txtNombreRegs.Size = new Size(364, 27);
            txtNombreRegs.TabIndex = 12;
            // 
            // txtDateRegs
            // 
            txtDateRegs.Location = new Point(461, 209);
            txtDateRegs.Name = "txtDateRegs";
            txtDateRegs.Size = new Size(293, 27);
            txtDateRegs.TabIndex = 13;
            // 
            // txtApellidoRegs
            // 
            txtApellidoRegs.Location = new Point(390, 126);
            txtApellidoRegs.Name = "txtApellidoRegs";
            txtApellidoRegs.Size = new Size(364, 27);
            txtApellidoRegs.TabIndex = 14;
            // 
            // txtEdadRegs
            // 
            txtEdadRegs.Location = new Point(390, 170);
            txtEdadRegs.Name = "txtEdadRegs";
            txtEdadRegs.Size = new Size(364, 27);
            txtEdadRegs.TabIndex = 15;
            // 
            // txtCorreoRegs
            // 
            txtCorreoRegs.Location = new Point(390, 291);
            txtCorreoRegs.Name = "txtCorreoRegs";
            txtCorreoRegs.Size = new Size(364, 27);
            txtCorreoRegs.TabIndex = 17;
            // 
            // txtSexoRegs
            // 
            txtSexoRegs.Location = new Point(390, 252);
            txtSexoRegs.Name = "txtSexoRegs";
            txtSexoRegs.Size = new Size(363, 27);
            txtSexoRegs.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(label1);
            panel4.Location = new Point(249, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(552, 65);
            panel4.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(170, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 53);
            label1.TabIndex = 0;
            label1.Text = "Registro";
            // 
            // userRegs
            // 
            userRegs.AutoSize = true;
            userRegs.Location = new Point(300, 333);
            userRegs.Name = "userRegs";
            userRegs.Size = new Size(62, 20);
            userRegs.TabIndex = 20;
            userRegs.Text = "Usuario:";
            // 
            // passwordRegs
            // 
            passwordRegs.AutoSize = true;
            passwordRegs.Location = new Point(300, 376);
            passwordRegs.Name = "passwordRegs";
            passwordRegs.Size = new Size(86, 20);
            passwordRegs.TabIndex = 21;
            passwordRegs.Text = "Contraseña:";
            // 
            // txtUsuarioRegs
            // 
            txtUsuarioRegs.Location = new Point(390, 333);
            txtUsuarioRegs.Name = "txtUsuarioRegs";
            txtUsuarioRegs.Size = new Size(362, 27);
            txtUsuarioRegs.TabIndex = 22;
            // 
            // txtContraseñaRegs
            // 
            txtContraseñaRegs.Location = new Point(390, 376);
            txtContraseñaRegs.Name = "txtContraseñaRegs";
            txtContraseñaRegs.Size = new Size(362, 27);
            txtContraseñaRegs.TabIndex = 23;
            // 
            // button2
            // 
            button2.Location = new Point(32, 252);
            button2.Name = "button2";
            button2.Size = new Size(180, 50);
            button2.TabIndex = 20;
            button2.Text = "Ver Datos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContraseñaRegs);
            Controls.Add(txtUsuarioRegs);
            Controls.Add(passwordRegs);
            Controls.Add(userRegs);
            Controls.Add(panel4);
            Controls.Add(txtSexoRegs);
            Controls.Add(txtCorreoRegs);
            Controls.Add(txtEdadRegs);
            Controls.Add(txtApellidoRegs);
            Controls.Add(txtDateRegs);
            Controls.Add(txtNombreRegs);
            Controls.Add(CorreoRegs);
            Controls.Add(sexoRegs);
            Controls.Add(nacimientoRegs);
            Controls.Add(edadRegs);
            Controls.Add(apellidoRegs);
            Controls.Add(nombreRegs);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmRegistro";
            Text = "Registro";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button guardarRegs;
        private Panel panel1;
        private Panel panel2;
        private Label nombreRegs;
        private Label apellidoRegs;
        private Label edadRegs;
        private Label nacimientoRegs;
        private Label sexoRegs;
        private Label CorreoRegs;
        private TextBox txtNombreRegs;
        private DateTimePicker txtDateRegs;
        private TextBox txtApellidoRegs;
        private TextBox txtEdadRegs;
        private TextBox txtCorreoRegs;
        private TextBox txtSexoRegs;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label userRegs;
        private Label passwordRegs;
        private TextBox txtUsuarioRegs;
        private TextBox txtContraseñaRegs;
        private Button button2;
    }
}