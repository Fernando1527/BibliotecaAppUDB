namespace BibliotecaAppUDB
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLibros = new Button();
            btnUsuarios = new Button();
            btnPrestamos = new Button();
            btnEstadisticas = new Button();
            SuspendLayout();
            // 
            // btnLibros
            // 
            btnLibros.Location = new Point(575, 75);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(189, 29);
            btnLibros.TabIndex = 0;
            btnLibros.Text = "Gestionar Libros";
            btnLibros.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(575, 120);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(189, 29);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Gestionar Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnPrestamos
            // 
            btnPrestamos.Location = new Point(575, 170);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(189, 29);
            btnPrestamos.TabIndex = 2;
            btnPrestamos.Text = "Prestamos";
            btnPrestamos.UseVisualStyleBackColor = true;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Location = new Point(575, 228);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(189, 29);
            btnEstadisticas.TabIndex = 3;
            btnEstadisticas.Text = "Estadisticas";
            btnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 453);
            Controls.Add(btnEstadisticas);
            Controls.Add(btnPrestamos);
            Controls.Add(btnUsuarios);
            Controls.Add(btnLibros);
            Name = "MainForm";
            Text = "Sistema de Biblioteca";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnLibros;
        private Button btnUsuarios;
        private Button btnPrestamos;
        private Button btnEstadisticas;
    }
}
