namespace StudentSystem
{
    partial class frmDept
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
            EditarDept = new Button();
            dataGridView1 = new DataGridView();
            txtNombre = new TextBox();
            nombreDept = new Label();
            idDept = new Label();
            txtId = new TextBox();
            eliminarDept = new Button();
            txtDescripcion = new TextBox();
            descripcionDept = new Label();
            consultarDept = new Button();
            panel1 = new Panel();
            agregarDept = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // EditarDept
            // 
            EditarDept.Location = new Point(58, 328);
            EditarDept.Name = "EditarDept";
            EditarDept.Size = new Size(157, 29);
            EditarDept.TabIndex = 0;
            EditarDept.Text = "Editar";
            EditarDept.UseVisualStyleBackColor = true;
            EditarDept.Click += consultarDept_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(268, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(520, 212);
            dataGridView1.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(364, 253);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(424, 27);
            txtNombre.TabIndex = 2;
            // 
            // nombreDept
            // 
            nombreDept.AutoSize = true;
            nombreDept.Location = new Point(268, 260);
            nombreDept.Name = "nombreDept";
            nombreDept.Size = new Size(67, 20);
            nombreDept.TabIndex = 3;
            nombreDept.Text = "Nombre:";
            // 
            // idDept
            // 
            idDept.AutoSize = true;
            idDept.Location = new Point(268, 304);
            idDept.Name = "idDept";
            idDept.Size = new Size(25, 20);
            idDept.TabIndex = 4;
            idDept.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(364, 297);
            txtId.Name = "txtId";
            txtId.Size = new Size(424, 27);
            txtId.TabIndex = 5;
            // 
            // eliminarDept
            // 
            eliminarDept.Location = new Point(58, 379);
            eliminarDept.Name = "eliminarDept";
            eliminarDept.Size = new Size(157, 29);
            eliminarDept.TabIndex = 6;
            eliminarDept.Text = "Eliminar";
            eliminarDept.UseVisualStyleBackColor = true;
            eliminarDept.Click += eliminarDept_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(364, 348);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(424, 27);
            txtDescripcion.TabIndex = 7;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // descripcionDept
            // 
            descripcionDept.AutoSize = true;
            descripcionDept.Location = new Point(268, 355);
            descripcionDept.Name = "descripcionDept";
            descripcionDept.Size = new Size(90, 20);
            descripcionDept.TabIndex = 8;
            descripcionDept.Text = "Descripcion:";
            // 
            // consultarDept
            // 
            consultarDept.Location = new Point(58, 223);
            consultarDept.Name = "consultarDept";
            consultarDept.Size = new Size(157, 29);
            consultarDept.TabIndex = 9;
            consultarDept.Text = "Consultar";
            consultarDept.UseVisualStyleBackColor = true;
            consultarDept.Click += consultarDept_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(agregarDept);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(consultarDept);
            panel1.Controls.Add(EditarDept);
            panel1.Controls.Add(eliminarDept);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 450);
            panel1.TabIndex = 10;
            // 
            // agregarDept
            // 
            agregarDept.Location = new Point(58, 275);
            agregarDept.Name = "agregarDept";
            agregarDept.Size = new Size(157, 29);
            agregarDept.TabIndex = 11;
            agregarDept.Text = "Agregar";
            agregarDept.UseVisualStyleBackColor = true;
            agregarDept.Click += agregarDept_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.departamento;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(368, 14);
            button1.Name = "button1";
            button1.Size = new Size(157, 29);
            button1.TabIndex = 11;
            button1.Text = "Volver ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(263, 395);
            panel2.Name = "panel2";
            panel2.Size = new Size(537, 55);
            panel2.TabIndex = 11;
            // 
            // frmDept
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(descripcionDept);
            Controls.Add(txtDescripcion);
            Controls.Add(txtId);
            Controls.Add(idDept);
            Controls.Add(nombreDept);
            Controls.Add(txtNombre);
            Controls.Add(dataGridView1);
            Name = "frmDept";
            Text = "frmDept";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditarDept;
        private DataGridView dataGridView1;
        private TextBox txtNombre;
        private Label nombreDept;
        private Label idDept;
        private TextBox txtId;
        private Button eliminarDept;
        private TextBox txtDescripcion;
        private Label descripcionDept;
        private Button consultarDept;
        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button agregarDept;
    }
}