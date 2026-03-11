namespace BibliotecaAppUDB.Forms
{
    partial class EstadisticasForm
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
            dgvEstadisticas = new DataGridView();
            Libro = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEstadisticas).BeginInit();
            SuspendLayout();
            // 
            // dgvEstadisticas
            // 
            dgvEstadisticas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstadisticas.Columns.AddRange(new DataGridViewColumn[] { Libro, Cantidad });
            dgvEstadisticas.Location = new Point(181, 116);
            dgvEstadisticas.Name = "dgvEstadisticas";
            dgvEstadisticas.RowHeadersWidth = 51;
            dgvEstadisticas.Size = new Size(300, 188);
            dgvEstadisticas.TabIndex = 0;
            // 
            // Libro
            // 
            Libro.DataPropertyName = "Libro";
            Libro.HeaderText = "Libro";
            Libro.MinimumWidth = 6;
            Libro.Name = "Libro";
            Libro.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.HeaderText = "Prestamos";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // EstadisticasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvEstadisticas);
            Name = "EstadisticasForm";
            Text = "EstadisticasForm";
            Load += EstadisticasForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvEstadisticas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEstadisticas;
        private DataGridViewTextBoxColumn Libro;
        private DataGridViewTextBoxColumn Cantidad;
    }
}