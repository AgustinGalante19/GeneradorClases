namespace GeneradorClases
{
    partial class Inicio
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_fbd = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ckb_detalle = new System.Windows.Forms.CheckBox();
			this.cb_lenguajes = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_nombre_clase = new System.Windows.Forms.TextBox();
			this.tb_nombre_detalle = new System.Windows.Forms.TextBox();
			this.tb_archivo_nombre = new System.Windows.Forms.TextBox();
			this.tb_archivo_path = new System.Windows.Forms.TextBox();
			this.tb_tabla_detalle = new System.Windows.Forms.TextBox();
			this.tb_nombre_tabla = new System.Windows.Forms.TextBox();
			this.btn_reset = new System.Windows.Forms.Button();
			this.dg_datos = new System.Windows.Forms.DataGridView();
			this.btn_generar = new System.Windows.Forms.Button();
			this.btn_revisar = new System.Windows.Forms.Button();
			this.fbd_archivo_path = new System.Windows.Forms.FolderBrowserDialog();
			this.campoClaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg_datos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.campoClaseBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_fbd);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.ckb_detalle);
			this.panel1.Controls.Add(this.cb_lenguajes);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.tb_nombre_clase);
			this.panel1.Controls.Add(this.tb_nombre_detalle);
			this.panel1.Controls.Add(this.tb_archivo_nombre);
			this.panel1.Controls.Add(this.tb_archivo_path);
			this.panel1.Controls.Add(this.tb_tabla_detalle);
			this.panel1.Controls.Add(this.tb_nombre_tabla);
			this.panel1.Location = new System.Drawing.Point(13, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1089, 131);
			this.panel1.TabIndex = 0;
			// 
			// btn_fbd
			// 
			this.btn_fbd.Location = new System.Drawing.Point(867, 56);
			this.btn_fbd.Name = "btn_fbd";
			this.btn_fbd.Size = new System.Drawing.Size(26, 20);
			this.btn_fbd.TabIndex = 15;
			this.btn_fbd.Text = "...";
			this.btn_fbd.UseVisualStyleBackColor = true;
			this.btn_fbd.Click += new System.EventHandler(this.btn_fbd_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(565, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Ubicación";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(270, 58);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Nombre archivo";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(565, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Tabla";
			// 
			// ckb_detalle
			// 
			this.ckb_detalle.AutoSize = true;
			this.ckb_detalle.Location = new System.Drawing.Point(271, 24);
			this.ckb_detalle.Name = "ckb_detalle";
			this.ckb_detalle.Size = new System.Drawing.Size(81, 17);
			this.ckb_detalle.TabIndex = 10;
			this.ckb_detalle.Text = "Usa Detalle";
			this.ckb_detalle.UseVisualStyleBackColor = true;
			// 
			// cb_lenguajes
			// 
			this.cb_lenguajes.FormattingEnabled = true;
			this.cb_lenguajes.Items.AddRange(new object[] {
            "C#",
            "VB.net"});
			this.cb_lenguajes.Location = new System.Drawing.Point(67, 87);
			this.cb_lenguajes.Name = "cb_lenguajes";
			this.cb_lenguajes.Size = new System.Drawing.Size(176, 21);
			this.cb_lenguajes.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(5, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Lenguaje";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(5, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Clase";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Tabla";
			// 
			// tb_nombre_clase
			// 
			this.tb_nombre_clase.Location = new System.Drawing.Point(67, 52);
			this.tb_nombre_clase.Name = "tb_nombre_clase";
			this.tb_nombre_clase.Size = new System.Drawing.Size(176, 20);
			this.tb_nombre_clase.TabIndex = 5;
			// 
			// tb_nombre_detalle
			// 
			this.tb_nombre_detalle.Location = new System.Drawing.Point(372, 24);
			this.tb_nombre_detalle.Name = "tb_nombre_detalle";
			this.tb_nombre_detalle.Size = new System.Drawing.Size(176, 20);
			this.tb_nombre_detalle.TabIndex = 4;
			// 
			// tb_archivo_nombre
			// 
			this.tb_archivo_nombre.Location = new System.Drawing.Point(372, 55);
			this.tb_archivo_nombre.Name = "tb_archivo_nombre";
			this.tb_archivo_nombre.Size = new System.Drawing.Size(176, 20);
			this.tb_archivo_nombre.TabIndex = 3;
			// 
			// tb_archivo_path
			// 
			this.tb_archivo_path.Location = new System.Drawing.Point(631, 56);
			this.tb_archivo_path.Name = "tb_archivo_path";
			this.tb_archivo_path.Size = new System.Drawing.Size(230, 20);
			this.tb_archivo_path.TabIndex = 2;
			// 
			// tb_tabla_detalle
			// 
			this.tb_tabla_detalle.Location = new System.Drawing.Point(631, 26);
			this.tb_tabla_detalle.Name = "tb_tabla_detalle";
			this.tb_tabla_detalle.Size = new System.Drawing.Size(176, 20);
			this.tb_tabla_detalle.TabIndex = 1;
			// 
			// tb_nombre_tabla
			// 
			this.tb_nombre_tabla.Location = new System.Drawing.Point(67, 22);
			this.tb_nombre_tabla.Name = "tb_nombre_tabla";
			this.tb_nombre_tabla.Size = new System.Drawing.Size(176, 20);
			this.tb_nombre_tabla.TabIndex = 0;
			// 
			// btn_reset
			// 
			this.btn_reset.Location = new System.Drawing.Point(985, 463);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(117, 56);
			this.btn_reset.TabIndex = 1;
			this.btn_reset.Text = "Reset";
			this.btn_reset.UseVisualStyleBackColor = true;
			// 
			// dg_datos
			// 
			this.dg_datos.AutoGenerateColumns = false;
			this.dg_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
			this.dg_datos.DataSource = this.campoClaseBindingSource;
			this.dg_datos.Location = new System.Drawing.Point(13, 151);
			this.dg_datos.Name = "dg_datos";
			this.dg_datos.Size = new System.Drawing.Size(1089, 296);
			this.dg_datos.TabIndex = 2;
			// 
			// btn_generar
			// 
			this.btn_generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_generar.Location = new System.Drawing.Point(13, 463);
			this.btn_generar.Name = "btn_generar";
			this.btn_generar.Size = new System.Drawing.Size(117, 56);
			this.btn_generar.TabIndex = 3;
			this.btn_generar.Text = "Generar";
			this.btn_generar.UseVisualStyleBackColor = true;
			this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
			// 
			// btn_revisar
			// 
			this.btn_revisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_revisar.Location = new System.Drawing.Point(144, 463);
			this.btn_revisar.Name = "btn_revisar";
			this.btn_revisar.Size = new System.Drawing.Size(117, 56);
			this.btn_revisar.TabIndex = 4;
			this.btn_revisar.Text = "Revisar";
			this.btn_revisar.UseVisualStyleBackColor = true;
			// 
			// campoClaseBindingSource
			// 
			this.campoClaseBindingSource.DataSource = typeof(GeneradorClases.Modelos.CampoClase);
			// 
			// dataGridViewTextBoxColumn15
			// 
			this.dataGridViewTextBoxColumn15.DataPropertyName = "nro";
			this.dataGridViewTextBoxColumn15.HeaderText = "nro";
			this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
			// 
			// dataGridViewTextBoxColumn16
			// 
			this.dataGridViewTextBoxColumn16.DataPropertyName = "descripcion";
			this.dataGridViewTextBoxColumn16.HeaderText = "descripcion";
			this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
			// 
			// dataGridViewTextBoxColumn17
			// 
			this.dataGridViewTextBoxColumn17.DataPropertyName = "campo";
			this.dataGridViewTextBoxColumn17.HeaderText = "campo";
			this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
			// 
			// dataGridViewTextBoxColumn18
			// 
			this.dataGridViewTextBoxColumn18.DataPropertyName = "tipo";
			this.dataGridViewTextBoxColumn18.HeaderText = "tipo";
			this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
			// 
			// dataGridViewTextBoxColumn19
			// 
			this.dataGridViewTextBoxColumn19.DataPropertyName = "longitud";
			this.dataGridViewTextBoxColumn19.HeaderText = "longitud";
			this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
			// 
			// dataGridViewTextBoxColumn20
			// 
			this.dataGridViewTextBoxColumn20.DataPropertyName = "dec";
			this.dataGridViewTextBoxColumn20.HeaderText = "dec";
			this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
			// 
			// dataGridViewTextBoxColumn21
			// 
			this.dataGridViewTextBoxColumn21.DataPropertyName = "clave";
			this.dataGridViewTextBoxColumn21.HeaderText = "clave";
			this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
			// 
			// dataGridViewTextBoxColumn22
			// 
			this.dataGridViewTextBoxColumn22.DataPropertyName = "req";
			this.dataGridViewTextBoxColumn22.HeaderText = "req";
			this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
			// 
			// dataGridViewTextBoxColumn23
			// 
			this.dataGridViewTextBoxColumn23.DataPropertyName = "default_value";
			this.dataGridViewTextBoxColumn23.HeaderText = "default_value";
			this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
			// 
			// dataGridViewTextBoxColumn24
			// 
			this.dataGridViewTextBoxColumn24.DataPropertyName = "Tipo_Resultado";
			this.dataGridViewTextBoxColumn24.HeaderText = "Tipo_Resultado";
			this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
			// 
			// dataGridViewTextBoxColumn25
			// 
			this.dataGridViewTextBoxColumn25.DataPropertyName = "Abr_tipo_Resultado";
			this.dataGridViewTextBoxColumn25.HeaderText = "Abr_tipo_Resultado";
			this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
			// 
			// dataGridViewTextBoxColumn26
			// 
			this.dataGridViewTextBoxColumn26.DataPropertyName = "Abr_sigla_Resultado";
			this.dataGridViewTextBoxColumn26.HeaderText = "Abr_sigla_Resultado";
			this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
			// 
			// dataGridViewTextBoxColumn27
			// 
			this.dataGridViewTextBoxColumn27.DataPropertyName = "Variable_Resultado";
			this.dataGridViewTextBoxColumn27.HeaderText = "Variable_Resultado";
			this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
			// 
			// dataGridViewTextBoxColumn28
			// 
			this.dataGridViewTextBoxColumn28.DataPropertyName = "Parametro_Resultado";
			this.dataGridViewTextBoxColumn28.HeaderText = "Parametro_Resultado";
			this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
			// 
			// Inicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1115, 540);
			this.Controls.Add(this.btn_revisar);
			this.Controls.Add(this.btn_generar);
			this.Controls.Add(this.dg_datos);
			this.Controls.Add(this.btn_reset);
			this.Controls.Add(this.panel1);
			this.Name = "Inicio";
			this.Text = "Generador de clases";
			this.Load += new System.EventHandler(this.Inicio_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg_datos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.campoClaseBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fbd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckb_detalle;
        private System.Windows.Forms.ComboBox cb_lenguajes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nombre_clase;
        private System.Windows.Forms.TextBox tb_nombre_detalle;
        private System.Windows.Forms.TextBox tb_archivo_nombre;
        private System.Windows.Forms.TextBox tb_tabla_detalle;
        private System.Windows.Forms.TextBox tb_nombre_tabla;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button btn_revisar;
        public System.Windows.Forms.FolderBrowserDialog fbd_archivo_path;
        public System.Windows.Forms.TextBox tb_archivo_path;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defaultvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoResultadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abrtipoResultadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abrsiglaResultadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn variableResultadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parametroResultadoDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dg_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
		private System.Windows.Forms.BindingSource campoClaseBindingSource;
	}
}

