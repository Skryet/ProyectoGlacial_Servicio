namespace Proyecto_Glacial___Servicio.OrdenServicio.OrdenServicioBuscar
{
    partial class frm_OrdenServicioBuscar00
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
            this.components = new System.ComponentModel.Container();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.cmb_seleccionarTipo = new System.Windows.Forms.ComboBox();
            this.dtp_fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_fechaFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.grp_rangoFechas = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listar_ordenes_servicioDataGridView = new System.Windows.Forms.DataGridView();
            this.listar_ordenes_servicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glacial_servicioDataSet = new Proyecto_Glacial___Servicio.glacial_servicioDataSet();
            this.orden_servicio_infogeneralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orden_servicio_infogeneralTableAdapter = new Proyecto_Glacial___Servicio.glacial_servicioDataSetTableAdapters.orden_servicio_infogeneralTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial___Servicio.glacial_servicioDataSetTableAdapters.TableAdapterManager();
            this.listar_ordenes_servicioTableAdapter = new Proyecto_Glacial___Servicio.glacial_servicioDataSetTableAdapters.listar_ordenes_servicioTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_automovil_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_rangoFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listar_ordenes_servicioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listar_ordenes_servicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_servicioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_servicio_infogeneralBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(231, 36);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(160, 33);
            this.txt_buscar.TabIndex = 0;
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_KeyPress);
            // 
            // cmb_seleccionarTipo
            // 
            this.cmb_seleccionarTipo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_seleccionarTipo.FormattingEnabled = true;
            this.cmb_seleccionarTipo.Items.AddRange(new object[] {
            "Rango de Fechas",
            "Número de Orden",
            "Nombre/Razón Social",
            "Placas",
            "No. de Serie"});
            this.cmb_seleccionarTipo.Location = new System.Drawing.Point(27, 36);
            this.cmb_seleccionarTipo.Name = "cmb_seleccionarTipo";
            this.cmb_seleccionarTipo.Size = new System.Drawing.Size(198, 34);
            this.cmb_seleccionarTipo.TabIndex = 1;
            this.cmb_seleccionarTipo.Text = "Seleccione...";
            this.cmb_seleccionarTipo.SelectedIndexChanged += new System.EventHandler(this.cmb_seleccionarTipo_SelectedIndexChanged);
            // 
            // dtp_fechaInicio
            // 
            this.dtp_fechaInicio.Enabled = false;
            this.dtp_fechaInicio.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaInicio.Location = new System.Drawing.Point(56, 31);
            this.dtp_fechaInicio.Name = "dtp_fechaInicio";
            this.dtp_fechaInicio.Size = new System.Drawing.Size(101, 33);
            this.dtp_fechaInicio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "/";
            // 
            // dtp_fechaFin
            // 
            this.dtp_fechaFin.Enabled = false;
            this.dtp_fechaFin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaFin.Location = new System.Drawing.Point(263, 31);
            this.dtp_fechaFin.Name = "dtp_fechaFin";
            this.dtp_fechaFin.Size = new System.Drawing.Size(101, 33);
            this.dtp_fechaFin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Enabled = false;
            this.btn_buscar.Image = global::Proyecto_Glacial___Servicio.Properties.Resources.searchButtonBigger;
            this.btn_buscar.Location = new System.Drawing.Point(456, 36);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(80, 80);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // grp_rangoFechas
            // 
            this.grp_rangoFechas.Controls.Add(this.label4);
            this.grp_rangoFechas.Controls.Add(this.label3);
            this.grp_rangoFechas.Controls.Add(this.dtp_fechaInicio);
            this.grp_rangoFechas.Controls.Add(this.label1);
            this.grp_rangoFechas.Controls.Add(this.dtp_fechaFin);
            this.grp_rangoFechas.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_rangoFechas.Location = new System.Drawing.Point(27, 76);
            this.grp_rangoFechas.Name = "grp_rangoFechas";
            this.grp_rangoFechas.Size = new System.Drawing.Size(370, 70);
            this.grp_rangoFechas.TabIndex = 6;
            this.grp_rangoFechas.TabStop = false;
            this.grp_rangoFechas.Text = "Rango  de Fechas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Al:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Del:";
            // 
            // listar_ordenes_servicioDataGridView
            // 
            this.listar_ordenes_servicioDataGridView.AllowUserToAddRows = false;
            this.listar_ordenes_servicioDataGridView.AllowUserToDeleteRows = false;
            this.listar_ordenes_servicioDataGridView.AllowUserToResizeColumns = false;
            this.listar_ordenes_servicioDataGridView.AllowUserToResizeRows = false;
            this.listar_ordenes_servicioDataGridView.AutoGenerateColumns = false;
            this.listar_ordenes_servicioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listar_ordenes_servicioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.id_cliente,
            this.id_automovil_servicio,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.placas});
            this.listar_ordenes_servicioDataGridView.DataSource = this.listar_ordenes_servicioBindingSource;
            this.listar_ordenes_servicioDataGridView.Location = new System.Drawing.Point(12, 195);
            this.listar_ordenes_servicioDataGridView.Name = "listar_ordenes_servicioDataGridView";
            this.listar_ordenes_servicioDataGridView.ReadOnly = true;
            this.listar_ordenes_servicioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listar_ordenes_servicioDataGridView.Size = new System.Drawing.Size(809, 220);
            this.listar_ordenes_servicioDataGridView.TabIndex = 6;
            this.listar_ordenes_servicioDataGridView.DoubleClick += new System.EventHandler(this.listar_ordenes_servicioDataGridView_DoubleClick);
            // 
            // listar_ordenes_servicioBindingSource
            // 
            this.listar_ordenes_servicioBindingSource.DataMember = "listar_ordenes_servicio";
            this.listar_ordenes_servicioBindingSource.DataSource = this.glacial_servicioDataSet;
            // 
            // glacial_servicioDataSet
            // 
            this.glacial_servicioDataSet.DataSetName = "glacial_servicioDataSet";
            this.glacial_servicioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orden_servicio_infogeneralBindingSource
            // 
            this.orden_servicio_infogeneralBindingSource.DataMember = "orden_servicio_infogeneral";
            this.orden_servicio_infogeneralBindingSource.DataSource = this.glacial_servicioDataSet;
            // 
            // orden_servicio_infogeneralTableAdapter
            // 
            this.orden_servicio_infogeneralTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.automovil_inventarioTableAdapter = null;
            this.tableAdapterManager.automoviles_servicioTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.danos_vehiculoTableAdapter = null;
            this.tableAdapterManager.lista_orden_materialTableAdapter = null;
            this.tableAdapterManager.orden_materialTableAdapter = null;
            this.tableAdapterManager.orden_servicio_infogeneralTableAdapter = this.orden_servicio_infogeneralTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial___Servicio.glacial_servicioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listar_ordenes_servicioTableAdapter
            // 
            this.listar_ordenes_servicioTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_numero_orden";
            this.dataGridViewTextBoxColumn1.HeaderText = "Número de Orden";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // id_cliente
            // 
            this.id_cliente.DataPropertyName = "id_cliente";
            this.id_cliente.HeaderText = "id_cliente";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            this.id_cliente.Visible = false;
            // 
            // id_automovil_servicio
            // 
            this.id_automovil_servicio.DataPropertyName = "id_automovil_servicio";
            this.id_automovil_servicio.HeaderText = "id_automovil_servicio";
            this.id_automovil_servicio.Name = "id_automovil_servicio";
            this.id_automovil_servicio.ReadOnly = true;
            this.id_automovil_servicio.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombre / Razón Social";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 230;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fecha_ingreso";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha Ingreso";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fecha_entrega";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha  Entrega";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 85;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "hora_entrega";
            this.dataGridViewTextBoxColumn4.HeaderText = "Hora Entrega";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 85;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "num_serie";
            this.dataGridViewTextBoxColumn7.HeaderText = "Número de serie";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // placas
            // 
            this.placas.DataPropertyName = "placas";
            this.placas.HeaderText = "Placas";
            this.placas.Name = "placas";
            this.placas.ReadOnly = true;
            // 
            // frm_OrdenServicioBuscar00
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 521);
            this.Controls.Add(this.listar_ordenes_servicioDataGridView);
            this.Controls.Add(this.grp_rangoFechas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.cmb_seleccionarTipo);
            this.Controls.Add(this.txt_buscar);
            this.Name = "frm_OrdenServicioBuscar00";
            this.Text = "Buscar Órdenes de servicio";
            this.Load += new System.EventHandler(this.frm_OrdenServicioBuscar00_Load);
            this.grp_rangoFechas.ResumeLayout(false);
            this.grp_rangoFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listar_ordenes_servicioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listar_ordenes_servicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_servicioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_servicio_infogeneralBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.ComboBox cmb_seleccionarTipo;
        private System.Windows.Forms.DateTimePicker dtp_fechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_fechaFin;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grp_rangoFechas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private glacial_servicioDataSet glacial_servicioDataSet;
        private System.Windows.Forms.BindingSource orden_servicio_infogeneralBindingSource;
        private glacial_servicioDataSetTableAdapters.orden_servicio_infogeneralTableAdapter orden_servicio_infogeneralTableAdapter;
        private glacial_servicioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource listar_ordenes_servicioBindingSource;
        private glacial_servicioDataSetTableAdapters.listar_ordenes_servicioTableAdapter listar_ordenes_servicioTableAdapter;
        private System.Windows.Forms.DataGridView listar_ordenes_servicioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_automovil_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn placas;
    }
}