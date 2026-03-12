namespace BibliotecaWinForms
{
    partial class FormUsuarios
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrestamos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblIntro.Location = new System.Drawing.Point(332, 19);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(330, 46);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = "Registrar Usuario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombre.Location = new System.Drawing.Point(50, 94);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCarnet.Location = new System.Drawing.Point(50, 142);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(77, 25);
            this.lblCarnet.TabIndex = 2;
            this.lblCarnet.Text = "Carnet:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(143, 95);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(143, 143);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(230, 26);
            this.txtCarnet.TabIndex = 4;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(55, 212);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(96, 41);
            this.btnAgregarUsuario.TabIndex = 5;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(183, 212);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 41);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(301, 212);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 41);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colCarnet,
            this.colPrestamos});
            this.dgvUsuarios.Location = new System.Drawing.Point(55, 313);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 62;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.Size = new System.Drawing.Size(518, 238);
            this.dgvUsuarios.TabIndex = 8;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 8;
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 150;
            // 
            // colCarnet
            // 
            this.colCarnet.HeaderText = "Carnet";
            this.colCarnet.MinimumWidth = 8;
            this.colCarnet.Name = "colCarnet";
            this.colCarnet.Width = 150;
            // 
            // colPrestamos
            // 
            this.colPrestamos.HeaderText = "Prestamos";
            this.colPrestamos.MinimumWidth = 8;
            this.colPrestamos.Name = "colPrestamos";
            this.colPrestamos.Width = 150;
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsuario,
            this.colLibro,
            this.colFecha});
            this.dgvPrestamos.Location = new System.Drawing.Point(55, 634);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.RowHeadersWidth = 62;
            this.dgvPrestamos.RowTemplate.Height = 28;
            this.dgvPrestamos.Size = new System.Drawing.Size(518, 252);
            this.dgvPrestamos.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(60, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Registro de préstamos";
            // 
            // colUsuario
            // 
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.MinimumWidth = 8;
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Width = 150;
            // 
            // colLibro
            // 
            this.colLibro.HeaderText = "Libro";
            this.colLibro.MinimumWidth = 8;
            this.colLibro.Name = "colLibro";
            this.colLibro.Width = 150;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 8;
            this.colFecha.Name = "colFecha";
            this.colFecha.Width = 150;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(700, 142);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(459, 262);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chartUsuario";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(742, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Usuario más activo";
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 912);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCarnet);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIntro);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrestamos;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
    }
}