namespace StudentSystem
{
    partial class frmAsignaturas
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            nombreAsignatura = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            txtNombreAsig = new TextBox();
            txtAreaAsig = new TextBox();
            txtTitulacionAsig = new TextBox();
            txtTipoAsig = new TextBox();
            txtCursoAsig = new TextBox();
            txtCreditTeoAsig = new TextBox();
            txtCreditLabAsig = new TextBox();
            txtConfigAsig = new TextBox();
            txtEquivAsig = new TextBox();
            txtGrupoLabAsig = new TextBox();
            txtGrupoTeoAsig = new TextBox();
            txtConfOptAsig = new TextBox();
            txtOptAsig = new TextBox();
            txtAdmAsig = new TextBox();
            txtDuracionAsig = new TextBox();
            txtIncompatibleAsig = new TextBox();
            dataGridView1 = new DataGridView();
            IdAsig = new Label();
            txtIdAsig = new TextBox();
            consultarAsig = new Button();
            agregarAsig = new Button();
            EditarAsig = new Button();
            EliminarAsig = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1066, 90);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(505, 20);
            label1.Name = "label1";
            label1.Size = new Size(225, 45);
            label1.TabIndex = 1;
            label1.Text = "Asignaturas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.libros;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // nombreAsignatura
            // 
            nombreAsignatura.AutoSize = true;
            nombreAsignatura.Location = new Point(41, 114);
            nombreAsignatura.Name = "nombreAsignatura";
            nombreAsignatura.Size = new Size(67, 20);
            nombreAsignatura.TabIndex = 1;
            nombreAsignatura.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 151);
            label4.Name = "label4";
            label4.Size = new Size(159, 20);
            label4.TabIndex = 3;
            label4.Text = "Area de conocimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 260);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 6;
            label5.Text = "Curso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 224);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 5;
            label6.Text = "Tipo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 187);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 4;
            label7.Text = "Titulacion:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 370);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 9;
            label8.Text = "Configuracion:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 334);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 8;
            label9.Text = "Creditos(Lab):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 297);
            label10.Name = "label10";
            label10.Size = new Size(118, 20);
            label10.TabIndex = 7;
            label10.Text = "Creditos(Teoria):";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(530, 370);
            label12.Name = "label12";
            label12.Size = new Size(95, 20);
            label12.TabIndex = 17;
            label12.Text = "Equivalentes:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(530, 333);
            label13.Name = "label13";
            label13.Size = new Size(97, 20);
            label13.TabIndex = 16;
            label13.Text = "Grupos (Lab):";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(530, 296);
            label14.Name = "label14";
            label14.Size = new Size(114, 20);
            label14.TabIndex = 15;
            label14.Text = "Grupos (Teoria):";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(530, 260);
            label15.Name = "label15";
            label15.Size = new Size(140, 20);
            label15.TabIndex = 14;
            label15.Text = "Configuracion(Opt):";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(530, 223);
            label16.Name = "label16";
            label16.Size = new Size(69, 20);
            label16.TabIndex = 13;
            label16.Text = "Optativa:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(530, 187);
            label17.Name = "label17";
            label17.Size = new Size(112, 20);
            label17.TabIndex = 12;
            label17.Text = "Administracion:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(530, 151);
            label18.Name = "label18";
            label18.Size = new Size(72, 20);
            label18.TabIndex = 11;
            label18.Text = "Duracion:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(530, 117);
            label19.Name = "label19";
            label19.Size = new Size(128, 20);
            label19.TabIndex = 10;
            label19.Text = "Incompatible con:";
            // 
            // txtNombreAsig
            // 
            txtNombreAsig.Location = new Point(202, 114);
            txtNombreAsig.Name = "txtNombreAsig";
            txtNombreAsig.Size = new Size(269, 27);
            txtNombreAsig.TabIndex = 19;
            // 
            // txtAreaAsig
            // 
            txtAreaAsig.Location = new Point(202, 151);
            txtAreaAsig.Name = "txtAreaAsig";
            txtAreaAsig.Size = new Size(269, 27);
            txtAreaAsig.TabIndex = 21;
            // 
            // txtTitulacionAsig
            // 
            txtTitulacionAsig.Location = new Point(202, 187);
            txtTitulacionAsig.Name = "txtTitulacionAsig";
            txtTitulacionAsig.Size = new Size(269, 27);
            txtTitulacionAsig.TabIndex = 22;
            // 
            // txtTipoAsig
            // 
            txtTipoAsig.Location = new Point(202, 224);
            txtTipoAsig.Name = "txtTipoAsig";
            txtTipoAsig.Size = new Size(269, 27);
            txtTipoAsig.TabIndex = 23;
            // 
            // txtCursoAsig
            // 
            txtCursoAsig.Location = new Point(202, 260);
            txtCursoAsig.Name = "txtCursoAsig";
            txtCursoAsig.Size = new Size(269, 27);
            txtCursoAsig.TabIndex = 24;
            // 
            // txtCreditTeoAsig
            // 
            txtCreditTeoAsig.Location = new Point(202, 297);
            txtCreditTeoAsig.Name = "txtCreditTeoAsig";
            txtCreditTeoAsig.Size = new Size(269, 27);
            txtCreditTeoAsig.TabIndex = 25;
            // 
            // txtCreditLabAsig
            // 
            txtCreditLabAsig.Location = new Point(202, 334);
            txtCreditLabAsig.Name = "txtCreditLabAsig";
            txtCreditLabAsig.Size = new Size(269, 27);
            txtCreditLabAsig.TabIndex = 26;
            // 
            // txtConfigAsig
            // 
            txtConfigAsig.Location = new Point(202, 370);
            txtConfigAsig.Name = "txtConfigAsig";
            txtConfigAsig.Size = new Size(269, 27);
            txtConfigAsig.TabIndex = 27;
            // 
            // txtEquivAsig
            // 
            txtEquivAsig.Location = new Point(695, 370);
            txtEquivAsig.Name = "txtEquivAsig";
            txtEquivAsig.Size = new Size(269, 27);
            txtEquivAsig.TabIndex = 35;
            // 
            // txtGrupoLabAsig
            // 
            txtGrupoLabAsig.Location = new Point(695, 333);
            txtGrupoLabAsig.Name = "txtGrupoLabAsig";
            txtGrupoLabAsig.Size = new Size(269, 27);
            txtGrupoLabAsig.TabIndex = 34;
            // 
            // txtGrupoTeoAsig
            // 
            txtGrupoTeoAsig.Location = new Point(695, 296);
            txtGrupoTeoAsig.Name = "txtGrupoTeoAsig";
            txtGrupoTeoAsig.Size = new Size(269, 27);
            txtGrupoTeoAsig.TabIndex = 33;
            // 
            // txtConfOptAsig
            // 
            txtConfOptAsig.Location = new Point(695, 260);
            txtConfOptAsig.Name = "txtConfOptAsig";
            txtConfOptAsig.Size = new Size(269, 27);
            txtConfOptAsig.TabIndex = 32;
            // 
            // txtOptAsig
            // 
            txtOptAsig.Location = new Point(695, 223);
            txtOptAsig.Name = "txtOptAsig";
            txtOptAsig.Size = new Size(269, 27);
            txtOptAsig.TabIndex = 31;
            // 
            // txtAdmAsig
            // 
            txtAdmAsig.Location = new Point(695, 187);
            txtAdmAsig.Name = "txtAdmAsig";
            txtAdmAsig.Size = new Size(269, 27);
            txtAdmAsig.TabIndex = 30;
            // 
            // txtDuracionAsig
            // 
            txtDuracionAsig.Location = new Point(695, 151);
            txtDuracionAsig.Name = "txtDuracionAsig";
            txtDuracionAsig.Size = new Size(269, 27);
            txtDuracionAsig.TabIndex = 29;
            // 
            // txtIncompatibleAsig
            // 
            txtIncompatibleAsig.Location = new Point(695, 114);
            txtIncompatibleAsig.Name = "txtIncompatibleAsig";
            txtIncompatibleAsig.Size = new Size(269, 27);
            txtIncompatibleAsig.TabIndex = 28;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(89, 417);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(875, 188);
            dataGridView1.TabIndex = 36;
            // 
            // IdAsig
            // 
            IdAsig.AutoSize = true;
            IdAsig.Location = new Point(117, 617);
            IdAsig.Name = "IdAsig";
            IdAsig.Size = new Size(25, 20);
            IdAsig.TabIndex = 37;
            IdAsig.Text = "Id:";
            // 
            // txtIdAsig
            // 
            txtIdAsig.Location = new Point(148, 617);
            txtIdAsig.Name = "txtIdAsig";
            txtIdAsig.Size = new Size(182, 27);
            txtIdAsig.TabIndex = 38;
            // 
            // consultarAsig
            // 
            consultarAsig.Location = new Point(433, 620);
            consultarAsig.Name = "consultarAsig";
            consultarAsig.Size = new Size(169, 29);
            consultarAsig.TabIndex = 39;
            consultarAsig.Text = "Consultar";
            consultarAsig.UseVisualStyleBackColor = true;
            consultarAsig.Click += consultarAsig_Click;
            // 
            // agregarAsig
            // 
            agregarAsig.Location = new Point(608, 620);
            agregarAsig.Name = "agregarAsig";
            agregarAsig.Size = new Size(169, 29);
            agregarAsig.TabIndex = 40;
            agregarAsig.Text = "Agregar";
            agregarAsig.UseVisualStyleBackColor = true;
            agregarAsig.Click += agregarAsig_Click;
            // 
            // EditarAsig
            // 
            EditarAsig.Location = new Point(433, 664);
            EditarAsig.Name = "EditarAsig";
            EditarAsig.Size = new Size(169, 29);
            EditarAsig.TabIndex = 41;
            EditarAsig.Text = "Editar";
            EditarAsig.UseVisualStyleBackColor = true;
            EditarAsig.Click += EditarAsig_Click;
            // 
            // EliminarAsig
            // 
            EliminarAsig.Location = new Point(608, 664);
            EliminarAsig.Name = "EliminarAsig";
            EliminarAsig.Size = new Size(169, 29);
            EliminarAsig.TabIndex = 42;
            EliminarAsig.Text = "Eliminar";
            EliminarAsig.UseVisualStyleBackColor = true;
            EliminarAsig.Click += EliminarAsig_Click;
            // 
            // button1
            // 
            button1.Location = new Point(89, 693);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 43;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmAsignaturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 745);
            Controls.Add(button1);
            Controls.Add(EliminarAsig);
            Controls.Add(EditarAsig);
            Controls.Add(agregarAsig);
            Controls.Add(consultarAsig);
            Controls.Add(txtIdAsig);
            Controls.Add(IdAsig);
            Controls.Add(dataGridView1);
            Controls.Add(txtEquivAsig);
            Controls.Add(txtGrupoLabAsig);
            Controls.Add(txtGrupoTeoAsig);
            Controls.Add(txtConfOptAsig);
            Controls.Add(txtOptAsig);
            Controls.Add(txtAdmAsig);
            Controls.Add(txtDuracionAsig);
            Controls.Add(txtIncompatibleAsig);
            Controls.Add(txtConfigAsig);
            Controls.Add(txtCreditLabAsig);
            Controls.Add(txtCreditTeoAsig);
            Controls.Add(txtCursoAsig);
            Controls.Add(txtTipoAsig);
            Controls.Add(txtTitulacionAsig);
            Controls.Add(txtAreaAsig);
            Controls.Add(txtNombreAsig);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(nombreAsignatura);
            Controls.Add(panel1);
            Name = "frmAsignaturas";
            Text = "Asignaturas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label nombreAsignatura;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox txtNombreAsig;
        private TextBox txtAreaAsig;
        private TextBox txtTitulacionAsig;
        private TextBox txtTipoAsig;
        private TextBox txtCursoAsig;
        private TextBox txtCreditTeoAsig;
        private TextBox txtCreditLabAsig;
        private TextBox txtConfigAsig;
        private TextBox txtEquivAsig;
        private TextBox txtGrupoLabAsig;
        private TextBox txtGrupoTeoAsig;
        private TextBox txtConfOptAsig;
        private TextBox txtOptAsig;
        private TextBox txtAdmAsig;
        private TextBox txtDuracionAsig;
        private TextBox txtIncompatibleAsig;
        private DataGridView dataGridView1;
        private Label IdAsig;
        private TextBox txtIdAsig;
        private Button consultarAsig;
        private Button agregarAsig;
        private Button EditarAsig;
        private Button EliminarAsig;
        private Button button1;
    }
}