namespace StudentSystem
{
    partial class frmLogin
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
            login = new Button();
            pictureBox1 = new PictureBox();
            nombre = new Label();
            contrasena = new Label();
            txtnombre = new TextBox();
            txtcontrasena = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // login
            // 
            login.BackColor = SystemColors.Highlight;
            login.BackgroundImageLayout = ImageLayout.None;
            login.Cursor = Cursors.Hand;
            login.ForeColor = SystemColors.ControlText;
            login.Location = new Point(410, 147);
            login.Margin = new Padding(4, 3, 4, 3);
            login.Name = "login";
            login.Size = new Size(197, 26);
            login.TabIndex = 0;
            login.Text = "Iniciar Sesion";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.InactiveCaption;
            pictureBox1.Image = Properties.Resources.estudiantes;
            pictureBox1.Location = new Point(-4, -1);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Location = new Point(323, 50);
            nombre.Margin = new Padding(4, 0, 4, 0);
            nombre.Name = "nombre";
            nombre.Size = new Size(63, 18);
            nombre.TabIndex = 2;
            nombre.Text = "Nombre:";
            // 
            // contrasena
            // 
            contrasena.AutoSize = true;
            contrasena.Location = new Point(323, 88);
            contrasena.Margin = new Padding(4, 0, 4, 0);
            contrasena.Name = "contrasena";
            contrasena.Size = new Size(85, 18);
            contrasena.TabIndex = 3;
            contrasena.Text = "Contraseña:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(428, 43);
            txtnombre.Margin = new Padding(4, 3, 4, 3);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(247, 25);
            txtnombre.TabIndex = 4;
            // 
            // txtcontrasena
            // 
            txtcontrasena.Location = new Point(428, 82);
            txtcontrasena.Margin = new Padding(4, 3, 4, 3);
            txtcontrasena.Name = "txtcontrasena";
            txtcontrasena.PasswordChar = '*';
            txtcontrasena.Size = new Size(247, 25);
            txtcontrasena.TabIndex = 5;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(900, 183);
            Controls.Add(txtcontrasena);
            Controls.Add(txtnombre);
            Controls.Add(contrasena);
            Controls.Add(nombre);
            Controls.Add(pictureBox1);
            Controls.Add(login);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private PictureBox pictureBox1;
        private Label nombre;
        private Label contrasena;
        private TextBox txtnombre;
        private TextBox txtcontrasena;
    }
}