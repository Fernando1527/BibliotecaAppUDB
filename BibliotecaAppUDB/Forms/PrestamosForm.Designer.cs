namespace BibliotecaAppUDB.Forms
{
    partial class PrestamosForm
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
            label1 = new Label();
            label2 = new Label();
            cmbUsuarios = new ComboBox();
            cmbLibros = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            dgvPrestamos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Libro = new DataGridViewTextBoxColumn();
            FechaPrestamo = new DataGridViewTextBoxColumn();
            Devuelto = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 40);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 115);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "Libro";
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new Point(256, 40);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(151, 28);
            cmbUsuarios.TabIndex = 2;
            // 
            // cmbLibros
            // 
            cmbLibros.FormattingEnabled = true;
            cmbLibros.Location = new Point(256, 107);
            cmbLibros.Name = "cmbLibros";
            cmbLibros.Size = new Size(151, 28);
            cmbLibros.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(487, 47);
            button1.Name = "button1";
            button1.Size = new Size(162, 29);
            button1.TabIndex = 4;
            button1.Text = "Registrar Prestamo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRegistrarPrestamo_Click;
            // 
            // button2
            // 
            button2.Location = new Point(487, 106);
            button2.Name = "button2";
            button2.Size = new Size(162, 29);
            button2.TabIndex = 5;
            button2.Text = "Registrar Devolucion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnRegistrarDevolucion_Click;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Columns.AddRange(new DataGridViewColumn[] { Id, Usuario, Libro, FechaPrestamo, Devuelto });
            dgvPrestamos.Location = new Point(72, 232);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.RowHeadersWidth = 51;
            dgvPrestamos.Size = new Size(678, 188);
            dgvPrestamos.TabIndex = 6;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Usuario
            // 
            Usuario.DataPropertyName = "Usuario";
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 6;
            Usuario.Name = "Usuario";
            Usuario.Width = 125;
            // 
            // Libro
            // 
            Libro.DataPropertyName = "Libro";
            Libro.HeaderText = "Libro";
            Libro.MinimumWidth = 6;
            Libro.Name = "Libro";
            Libro.Width = 125;
            // 
            // FechaPrestamo
            // 
            FechaPrestamo.DataPropertyName = "FechaPrestamo";
            FechaPrestamo.HeaderText = "Fecha";
            FechaPrestamo.MinimumWidth = 6;
            FechaPrestamo.Name = "FechaPrestamo";
            FechaPrestamo.Width = 125;
            // 
            // Devuelto
            // 
            Devuelto.DataPropertyName = "Devuelto";
            Devuelto.HeaderText = "Devuelto";
            Devuelto.MinimumWidth = 6;
            Devuelto.Name = "Devuelto";
            Devuelto.Width = 125;
            // 
            // PrestamosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPrestamos);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbLibros);
            Controls.Add(cmbUsuarios);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PrestamosForm";
            Text = "PrestamosForm";
            Load += PrestamosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbUsuarios;
        private ComboBox cmbLibros;
        private Button button1;
        private Button button2;
        private DataGridView dgvPrestamos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Libro;
        private DataGridViewTextBoxColumn FechaPrestamo;
        private DataGridViewTextBoxColumn Devuelto;
    }
}