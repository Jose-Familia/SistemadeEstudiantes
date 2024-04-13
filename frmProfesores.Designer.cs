namespace StudentSystem
{
    partial class frmProfesores
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
            panel1 = new Panel();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            eliminarProf = new Button();
            consultarProf = new Button();
            editarProf = new Button();
            agregarProf = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            nombreProf = new Label();
            despachoProf = new Label();
            idProf = new Label();
            txtNombreProf = new TextBox();
            txtDespachoProf = new TextBox();
            txtIdProf = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(eliminarProf);
            panel1.Controls.Add(consultarProf);
            panel1.Controls.Add(editarProf);
            panel1.Controls.Add(agregarProf);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 453);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.Location = new Point(95, 410);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 5;
            button5.Text = "volver";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.formacion;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // eliminarProf
            // 
            eliminarProf.Location = new Point(62, 310);
            eliminarProf.Name = "eliminarProf";
            eliminarProf.Size = new Size(163, 47);
            eliminarProf.TabIndex = 4;
            eliminarProf.Text = "Eliminar";
            eliminarProf.UseVisualStyleBackColor = true;
            eliminarProf.Click += eliminarProf_Click;
            // 
            // consultarProf
            // 
            consultarProf.Location = new Point(62, 168);
            consultarProf.Name = "consultarProf";
            consultarProf.Size = new Size(163, 41);
            consultarProf.TabIndex = 1;
            consultarProf.Text = "Consultar";
            consultarProf.UseVisualStyleBackColor = true;
            consultarProf.Click += consultarProf_Click;
            // 
            // editarProf
            // 
            editarProf.Location = new Point(62, 263);
            editarProf.Name = "editarProf";
            editarProf.Size = new Size(163, 41);
            editarProf.TabIndex = 3;
            editarProf.Text = "Editar";
            editarProf.UseVisualStyleBackColor = true;
            editarProf.Click += editarProf_Click;
            // 
            // agregarProf
            // 
            agregarProf.Location = new Point(62, 215);
            agregarProf.Name = "agregarProf";
            agregarProf.Size = new Size(163, 42);
            agregarProf.TabIndex = 2;
            agregarProf.Text = "Agregar";
            agregarProf.UseVisualStyleBackColor = true;
            agregarProf.Click += agregarProf_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(289, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(511, 218);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(289, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(511, 63);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 10);
            label1.Name = "label1";
            label1.Size = new Size(180, 42);
            label1.TabIndex = 0;
            label1.Text = "Profesores";
            // 
            // nombreProf
            // 
            nombreProf.AutoSize = true;
            nombreProf.Location = new Point(297, 295);
            nombreProf.Name = "nombreProf";
            nombreProf.Size = new Size(67, 20);
            nombreProf.TabIndex = 3;
            nombreProf.Text = "Nombre:";
            // 
            // despachoProf
            // 
            despachoProf.AutoSize = true;
            despachoProf.Location = new Point(297, 336);
            despachoProf.Name = "despachoProf";
            despachoProf.Size = new Size(78, 20);
            despachoProf.TabIndex = 4;
            despachoProf.Text = "Despacho:";
            // 
            // idProf
            // 
            idProf.AutoSize = true;
            idProf.Location = new Point(297, 380);
            idProf.Name = "idProf";
            idProf.Size = new Size(25, 20);
            idProf.TabIndex = 6;
            idProf.Text = "Id:";
            // 
            // txtNombreProf
            // 
            txtNombreProf.Location = new Point(450, 295);
            txtNombreProf.Name = "txtNombreProf";
            txtNombreProf.Size = new Size(338, 27);
            txtNombreProf.TabIndex = 7;
            // 
            // txtDespachoProf
            // 
            txtDespachoProf.Location = new Point(449, 336);
            txtDespachoProf.Name = "txtDespachoProf";
            txtDespachoProf.Size = new Size(339, 27);
            txtDespachoProf.TabIndex = 8;
            // 
            // txtIdProf
            // 
            txtIdProf.Location = new Point(449, 380);
            txtIdProf.Name = "txtIdProf";
            txtIdProf.Size = new Size(339, 27);
            txtIdProf.TabIndex = 10;
            // 
            // frmProfesores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIdProf);
            Controls.Add(txtDespachoProf);
            Controls.Add(txtNombreProf);
            Controls.Add(idProf);
            Controls.Add(despachoProf);
            Controls.Add(nombreProf);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "frmProfesores";
            Text = "Profesores Disponibles";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button5;
        private Button eliminarProf;
        private Button consultarProf;
        private Button editarProf;
        private Button agregarProf;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label1;
        private Label nombreProf;
        private Label despachoProf;
        private Label idProf;
        private TextBox txtNombreProf;
        private TextBox txtDespachoProf;
        private TextBox txtIdProf;
    }
}