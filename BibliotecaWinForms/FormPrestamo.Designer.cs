namespace BibliotecaWinForms
{
    partial class FormPrestamo
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
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.lblSeleccionarUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarPrestamo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(101, 126);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(356, 28);
            this.cmbUsuario.TabIndex = 0;
            // 
            // cmbLibros
            // 
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Location = new System.Drawing.Point(101, 200);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(356, 28);
            this.cmbLibros.TabIndex = 1;
            // 
            // lblSeleccionarUsuario
            // 
            this.lblSeleccionarUsuario.AutoSize = true;
            this.lblSeleccionarUsuario.Location = new System.Drawing.Point(97, 92);
            this.lblSeleccionarUsuario.Name = "lblSeleccionarUsuario";
            this.lblSeleccionarUsuario.Size = new System.Drawing.Size(152, 20);
            this.lblSeleccionarUsuario.TabIndex = 2;
            this.lblSeleccionarUsuario.Text = "Seleccionar usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccionar libro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(151, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registrar préstamo";
            // 
            // btnRegistrarPrestamo
            // 
            this.btnRegistrarPrestamo.Location = new System.Drawing.Point(310, 265);
            this.btnRegistrarPrestamo.Name = "btnRegistrarPrestamo";
            this.btnRegistrarPrestamo.Size = new System.Drawing.Size(147, 49);
            this.btnRegistrarPrestamo.TabIndex = 5;
            this.btnRegistrarPrestamo.Text = "Registrar";
            this.btnRegistrarPrestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarPrestamo.UseVisualStyleBackColor = false;
            // 
            // FormPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 338);
            this.Controls.Add(this.btnRegistrarPrestamo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSeleccionarUsuario);
            this.Controls.Add(this.cmbLibros);
            this.Controls.Add(this.cmbUsuario);
            this.Name = "FormPrestamo";
            this.Text = "FormPrestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.Label lblSeleccionarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarPrestamo;
    }
}