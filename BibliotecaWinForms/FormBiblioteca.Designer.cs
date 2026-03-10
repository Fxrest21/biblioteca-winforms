namespace BibliotecaWinForms
{
    partial class FormBiblioteca
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblIntro = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblautor = new System.Windows.Forms.Label();
            this.lblaño = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.chartLibros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrestamos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOpenForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblIntro.Location = new System.Drawing.Point(324, 23);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(399, 46);
            this.lblIntro.TabIndex = 2;
            this.lblIntro.Text = "Gestion de Biblioteca";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbltitulo.Location = new System.Drawing.Point(38, 117);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(66, 25);
            this.lbltitulo.TabIndex = 3;
            this.lbltitulo.Text = "Título:";
            // 
            // lblautor
            // 
            this.lblautor.AutoSize = true;
            this.lblautor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblautor.Location = new System.Drawing.Point(38, 162);
            this.lblautor.Name = "lblautor";
            this.lblautor.Size = new System.Drawing.Size(65, 25);
            this.lblautor.TabIndex = 4;
            this.lblautor.Text = "Autor:";
            // 
            // lblaño
            // 
            this.lblaño.AutoSize = true;
            this.lblaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblaño.Location = new System.Drawing.Point(38, 212);
            this.lblaño.Name = "lblaño";
            this.lblaño.Size = new System.Drawing.Size(54, 25);
            this.lblaño.TabIndex = 5;
            this.lblaño.Text = "Año:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(110, 116);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(270, 26);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(110, 163);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(270, 26);
            this.txtAutor.TabIndex = 7;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(110, 213);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 26);
            this.txtAnio.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(43, 271);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 40);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(196, 271);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(118, 40);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(342, 271);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 40);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.Location = new System.Drawing.Point(497, 271);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(183, 40);
            this.btnPrestamo.TabIndex = 12;
            this.btnPrestamo.Text = "Registrar préstamo";
            this.btnPrestamo.UseVisualStyleBackColor = true;
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitulo,
            this.colAutor,
            this.colAnio,
            this.colPrestamos});
            this.dgvLibros.Location = new System.Drawing.Point(43, 382);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersWidth = 62;
            this.dgvLibros.RowTemplate.Height = 28;
            this.dgvLibros.Size = new System.Drawing.Size(647, 351);
            this.dgvLibros.TabIndex = 13;
            this.dgvLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(816, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "Libros más prestados";
            // 
            // chartLibros
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLibros.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLibros.Legends.Add(legend1);
            this.chartLibros.Location = new System.Drawing.Point(734, 152);
            this.chartLibros.Name = "chartLibros";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartLibros.Series.Add(series1);
            this.chartLibros.Size = new System.Drawing.Size(658, 360);
            this.chartLibros.TabIndex = 15;
            this.chartLibros.Text = "chart1";
            // 
            // colTitulo
            // 
            this.colTitulo.HeaderText = "Título";
            this.colTitulo.MinimumWidth = 8;
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.Width = 150;
            // 
            // colAutor
            // 
            this.colAutor.HeaderText = "Autor";
            this.colAutor.MinimumWidth = 8;
            this.colAutor.Name = "colAutor";
            this.colAutor.Width = 150;
            // 
            // colAnio
            // 
            this.colAnio.HeaderText = "Año";
            this.colAnio.MinimumWidth = 8;
            this.colAnio.Name = "colAnio";
            this.colAnio.Width = 150;
            // 
            // colPrestamos
            // 
            this.colPrestamos.HeaderText = "Prestamos";
            this.colPrestamos.MinimumWidth = 8;
            this.colPrestamos.Name = "colPrestamos";
            this.colPrestamos.Width = 150;
            // 
            // btnOpenForm
            // 
            this.btnOpenForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOpenForm.Location = new System.Drawing.Point(884, 580);
            this.btnOpenForm.Name = "btnOpenForm";
            this.btnOpenForm.Size = new System.Drawing.Size(294, 115);
            this.btnOpenForm.TabIndex = 16;
            this.btnOpenForm.Text = "Gestionar usuarios";
            this.btnOpenForm.UseVisualStyleBackColor = true;
            // 
            // FormBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 784);
            this.Controls.Add(this.btnOpenForm);
            this.Controls.Add(this.chartLibros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.btnPrestamo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblaño);
            this.Controls.Add(this.lblautor);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.lblIntro);
            this.Name = "FormBiblioteca";
            this.Text = "lblLibrosPrestados";
            this.Load += new System.EventHandler(this.FormBiblioteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblautor;
        private System.Windows.Forms.Label lblaño;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrestamos;
        private System.Windows.Forms.Button btnOpenForm;
    }
}

