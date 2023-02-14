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
            this.nroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoResultadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abrtipoResultadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abrsiglaResultadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variableResultadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parametroResultadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.nroDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.campoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.longitudDataGridViewTextBoxColumn,
            this.decDataGridViewTextBoxColumn,
            this.claveDataGridViewTextBoxColumn,
            this.reqDataGridViewTextBoxColumn,
            this.defaultvalueDataGridViewTextBoxColumn,
            this.tipoResultadoDataGridViewTextBoxColumn,
            this.abrtipoResultadoDataGridViewTextBoxColumn,
            this.abrsiglaResultadoDataGridViewTextBoxColumn,
            this.variableResultadoDataGridViewTextBoxColumn,
            this.parametroResultadoDataGridViewTextBoxColumn});
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
            // nroDataGridViewTextBoxColumn
            // 
            this.nroDataGridViewTextBoxColumn.DataPropertyName = "nro";
            this.nroDataGridViewTextBoxColumn.HeaderText = "nro";
            this.nroDataGridViewTextBoxColumn.Name = "nroDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // campoDataGridViewTextBoxColumn
            // 
            this.campoDataGridViewTextBoxColumn.DataPropertyName = "campo";
            this.campoDataGridViewTextBoxColumn.HeaderText = "campo";
            this.campoDataGridViewTextBoxColumn.Name = "campoDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // longitudDataGridViewTextBoxColumn
            // 
            this.longitudDataGridViewTextBoxColumn.DataPropertyName = "longitud";
            this.longitudDataGridViewTextBoxColumn.HeaderText = "longitud";
            this.longitudDataGridViewTextBoxColumn.Name = "longitudDataGridViewTextBoxColumn";
            // 
            // decDataGridViewTextBoxColumn
            // 
            this.decDataGridViewTextBoxColumn.DataPropertyName = "dec";
            this.decDataGridViewTextBoxColumn.HeaderText = "dec";
            this.decDataGridViewTextBoxColumn.Name = "decDataGridViewTextBoxColumn";
            // 
            // claveDataGridViewTextBoxColumn
            // 
            this.claveDataGridViewTextBoxColumn.DataPropertyName = "clave";
            this.claveDataGridViewTextBoxColumn.HeaderText = "clave";
            this.claveDataGridViewTextBoxColumn.Name = "claveDataGridViewTextBoxColumn";
            // 
            // reqDataGridViewTextBoxColumn
            // 
            this.reqDataGridViewTextBoxColumn.DataPropertyName = "req";
            this.reqDataGridViewTextBoxColumn.HeaderText = "req";
            this.reqDataGridViewTextBoxColumn.Name = "reqDataGridViewTextBoxColumn";
            // 
            // defaultvalueDataGridViewTextBoxColumn
            // 
            this.defaultvalueDataGridViewTextBoxColumn.DataPropertyName = "default_value";
            this.defaultvalueDataGridViewTextBoxColumn.HeaderText = "default_value";
            this.defaultvalueDataGridViewTextBoxColumn.Name = "defaultvalueDataGridViewTextBoxColumn";
            // 
            // tipoResultadoDataGridViewTextBoxColumn
            // 
            this.tipoResultadoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Resultado";
            this.tipoResultadoDataGridViewTextBoxColumn.HeaderText = "Tipo_Resultado";
            this.tipoResultadoDataGridViewTextBoxColumn.Name = "tipoResultadoDataGridViewTextBoxColumn";
            // 
            // abrtipoResultadoDataGridViewTextBoxColumn
            // 
            this.abrtipoResultadoDataGridViewTextBoxColumn.DataPropertyName = "Abr_tipo_Resultado";
            this.abrtipoResultadoDataGridViewTextBoxColumn.HeaderText = "Abr_tipo_Resultado";
            this.abrtipoResultadoDataGridViewTextBoxColumn.Name = "abrtipoResultadoDataGridViewTextBoxColumn";
            // 
            // abrsiglaResultadoDataGridViewTextBoxColumn
            // 
            this.abrsiglaResultadoDataGridViewTextBoxColumn.DataPropertyName = "Abr_sigla_Resultado";
            this.abrsiglaResultadoDataGridViewTextBoxColumn.HeaderText = "Abr_sigla_Resultado";
            this.abrsiglaResultadoDataGridViewTextBoxColumn.Name = "abrsiglaResultadoDataGridViewTextBoxColumn";
            // 
            // variableResultadoDataGridViewTextBoxColumn
            // 
            this.variableResultadoDataGridViewTextBoxColumn.DataPropertyName = "Variable_Resultado";
            this.variableResultadoDataGridViewTextBoxColumn.HeaderText = "Variable_Resultado";
            this.variableResultadoDataGridViewTextBoxColumn.Name = "variableResultadoDataGridViewTextBoxColumn";
            // 
            // parametroResultadoDataGridViewTextBoxColumn
            // 
            this.parametroResultadoDataGridViewTextBoxColumn.DataPropertyName = "Parametro_Resultado";
            this.parametroResultadoDataGridViewTextBoxColumn.HeaderText = "Parametro_Resultado";
            this.parametroResultadoDataGridViewTextBoxColumn.Name = "parametroResultadoDataGridViewTextBoxColumn";
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
        private System.Windows.Forms.DataGridView dg_datos;
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
        private System.Windows.Forms.BindingSource campoClaseBindingSource;
    }
}

