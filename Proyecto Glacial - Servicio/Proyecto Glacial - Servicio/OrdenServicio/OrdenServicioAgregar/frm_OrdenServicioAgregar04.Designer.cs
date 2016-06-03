namespace Proyecto_Glacial___Servicio.OrdenServicio
{
    partial class frm_OrdenServicioAgregar04
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
            System.Windows.Forms.Label descripcion_servicioLabel;
            System.Windows.Forms.Label diagnostico_servicioLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.grupo_materiales = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_borrarRegistro = new System.Windows.Forms.Button();
            this.table_piezasNecesitadas = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupo_informacion = new System.Windows.Forms.GroupBox();
            this.txt_diagnostico_servicio = new System.Windows.Forms.TextBox();
            this.txt_descripcionServicio = new System.Windows.Forms.TextBox();
            this.orden_servicio_infogeneralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glacial_servicioDataSet = new Proyecto_Glacial___Servicio.glacial_servicioDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.grupo_infoAdicional = new System.Windows.Forms.GroupBox();
            this.check_suministra_partes = new System.Windows.Forms.CheckBox();
            this.check_consumidor_autoriza = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grupo_precio = new System.Windows.Forms.GroupBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_IVA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_descuentoNumero = new System.Windows.Forms.TextBox();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_cantidadLetra = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lista_orden_materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_orden_materialTableAdapter = new Proyecto_Glacial___Servicio.glacial_servicioDataSetTableAdapters.lista_orden_materialTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial___Servicio.glacial_servicioDataSetTableAdapters.TableAdapterManager();
            this.orden_materialTableAdapter = new Proyecto_Glacial___Servicio.glacial_servicioDataSetTableAdapters.orden_materialTableAdapter();
            this.orden_materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orden_servicio_infogeneralTableAdapter = new Proyecto_Glacial___Servicio.glacial_servicioDataSetTableAdapters.orden_servicio_infogeneralTableAdapter();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            descripcion_servicioLabel = new System.Windows.Forms.Label();
            diagnostico_servicioLabel = new System.Windows.Forms.Label();
            this.grupo_materiales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_piezasNecesitadas)).BeginInit();
            this.grupo_informacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orden_servicio_infogeneralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_servicioDataSet)).BeginInit();
            this.grupo_infoAdicional.SuspendLayout();
            this.grupo_precio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista_orden_materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_materialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcion_servicioLabel
            // 
            descripcion_servicioLabel.AutoSize = true;
            descripcion_servicioLabel.Location = new System.Drawing.Point(16, 22);
            descripcion_servicioLabel.Name = "descripcion_servicioLabel";
            descripcion_servicioLabel.Size = new System.Drawing.Size(266, 19);
            descripcion_servicioLabel.TabIndex = 0;
            descripcion_servicioLabel.Text = "Descripción del servicio solicitado:";
            // 
            // diagnostico_servicioLabel
            // 
            diagnostico_servicioLabel.AutoSize = true;
            diagnostico_servicioLabel.Location = new System.Drawing.Point(399, 22);
            diagnostico_servicioLabel.Name = "diagnostico_servicioLabel";
            diagnostico_servicioLabel.Size = new System.Drawing.Size(100, 19);
            diagnostico_servicioLabel.TabIndex = 2;
            diagnostico_servicioLabel.Text = "Diagnóstico:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.label1.Location = new System.Drawing.Point(292, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "Orden de servicio";
            // 
            // grupo_materiales
            // 
            this.grupo_materiales.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grupo_materiales.Controls.Add(this.btn_guardar);
            this.grupo_materiales.Controls.Add(this.btn_borrarRegistro);
            this.grupo_materiales.Controls.Add(this.table_piezasNecesitadas);
            this.grupo_materiales.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.grupo_materiales.Location = new System.Drawing.Point(12, 224);
            this.grupo_materiales.Name = "grupo_materiales";
            this.grupo_materiales.Size = new System.Drawing.Size(555, 184);
            this.grupo_materiales.TabIndex = 26;
            this.grupo_materiales.TabStop = false;
            this.grupo_materiales.Text = "Materiales";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Enabled = false;
            this.btn_guardar.Image = global::Proyecto_Glacial___Servicio.Properties.Resources.save_blacl;
            this.btn_guardar.Location = new System.Drawing.Point(512, 108);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(35, 46);
            this.btn_guardar.TabIndex = 27;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_borrarRegistro
            // 
            this.btn_borrarRegistro.Enabled = false;
            this.btn_borrarRegistro.Image = global::Proyecto_Glacial___Servicio.Properties.Resources.trashCan;
            this.btn_borrarRegistro.Location = new System.Drawing.Point(512, 25);
            this.btn_borrarRegistro.Name = "btn_borrarRegistro";
            this.btn_borrarRegistro.Size = new System.Drawing.Size(35, 50);
            this.btn_borrarRegistro.TabIndex = 27;
            this.btn_borrarRegistro.UseVisualStyleBackColor = true;
            this.btn_borrarRegistro.Click += new System.EventHandler(this.btn_borrarRegistro_Click);
            // 
            // table_piezasNecesitadas
            // 
            this.table_piezasNecesitadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_piezasNecesitadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_piezasNecesitadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.btnAgregar,
            this.cantidad,
            this.unidad,
            this.descripcion,
            this.precioUnitario,
            this.precioTotal});
            this.table_piezasNecesitadas.Location = new System.Drawing.Point(17, 22);
            this.table_piezasNecesitadas.Name = "table_piezasNecesitadas";
            this.table_piezasNecesitadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_piezasNecesitadas.Size = new System.Drawing.Size(489, 150);
            this.table_piezasNecesitadas.TabIndex = 0;
            this.table_piezasNecesitadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_piezasNecesitadas_CellContentClick);
            this.table_piezasNecesitadas.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_piezasNecesitadas_CellValidated);
            this.table_piezasNecesitadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.table_piezasNecesitadas_KeyPress);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.HeaderText = "";
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Width = 20;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad";
            this.unidad.Name = "unidad";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // precioUnitario
            // 
            this.precioUnitario.HeaderText = "Precio Unitario";
            this.precioUnitario.Name = "precioUnitario";
            this.precioUnitario.Visible = false;
            // 
            // precioTotal
            // 
            this.precioTotal.HeaderText = "Precio Total";
            this.precioTotal.Name = "precioTotal";
            this.precioTotal.Visible = false;
            // 
            // grupo_informacion
            // 
            this.grupo_informacion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grupo_informacion.Controls.Add(this.txt_diagnostico_servicio);
            this.grupo_informacion.Controls.Add(this.txt_descripcionServicio);
            this.grupo_informacion.Controls.Add(diagnostico_servicioLabel);
            this.grupo_informacion.Controls.Add(descripcion_servicioLabel);
            this.grupo_informacion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.grupo_informacion.Location = new System.Drawing.Point(13, 41);
            this.grupo_informacion.Name = "grupo_informacion";
            this.grupo_informacion.Size = new System.Drawing.Size(959, 177);
            this.grupo_informacion.TabIndex = 26;
            this.grupo_informacion.TabStop = false;
            this.grupo_informacion.Text = "Información";
            // 
            // txt_diagnostico_servicio
            // 
            this.txt_diagnostico_servicio.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_diagnostico_servicio.Font = new System.Drawing.Font("Cambria", 12F);
            this.txt_diagnostico_servicio.Location = new System.Drawing.Point(402, 44);
            this.txt_diagnostico_servicio.Multiline = true;
            this.txt_diagnostico_servicio.Name = "txt_diagnostico_servicio";
            this.txt_diagnostico_servicio.Size = new System.Drawing.Size(551, 109);
            this.txt_diagnostico_servicio.TabIndex = 6;
            // 
            // txt_descripcionServicio
            // 
            this.txt_descripcionServicio.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_descripcionServicio.Font = new System.Drawing.Font("Cambria", 12F);
            this.txt_descripcionServicio.Location = new System.Drawing.Point(17, 44);
            this.txt_descripcionServicio.Multiline = true;
            this.txt_descripcionServicio.Name = "txt_descripcionServicio";
            this.txt_descripcionServicio.Size = new System.Drawing.Size(379, 109);
            this.txt_descripcionServicio.TabIndex = 5;
            // 
            // orden_servicio_infogeneralBindingSource
            // 
            this.orden_servicio_infogeneralBindingSource.DataMember = "orden_servicio_infogeneral";
            this.orden_servicio_infogeneralBindingSource.DataSource = this.glacial_servicioDataSet;
            // 
            // glacial_servicioDataSet
            // 
            this.glacial_servicioDataSet.DataSetName = "glacial_servicioDataSet";
            this.glacial_servicioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subtotal:";
            // 
            // grupo_infoAdicional
            // 
            this.grupo_infoAdicional.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grupo_infoAdicional.Controls.Add(this.check_suministra_partes);
            this.grupo_infoAdicional.Controls.Add(this.check_consumidor_autoriza);
            this.grupo_infoAdicional.Controls.Add(this.label6);
            this.grupo_infoAdicional.Controls.Add(this.label5);
            this.grupo_infoAdicional.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.grupo_infoAdicional.Location = new System.Drawing.Point(12, 414);
            this.grupo_infoAdicional.Name = "grupo_infoAdicional";
            this.grupo_infoAdicional.Size = new System.Drawing.Size(497, 237);
            this.grupo_infoAdicional.TabIndex = 26;
            this.grupo_infoAdicional.TabStop = false;
            this.grupo_infoAdicional.Text = "Información adicional";
            // 
            // check_suministra_partes
            // 
            this.check_suministra_partes.AutoSize = true;
            this.check_suministra_partes.Location = new System.Drawing.Point(17, 184);
            this.check_suministra_partes.Name = "check_suministra_partes";
            this.check_suministra_partes.Size = new System.Drawing.Size(41, 23);
            this.check_suministra_partes.TabIndex = 7;
            this.check_suministra_partes.Text = "Sí";
            this.check_suministra_partes.UseVisualStyleBackColor = true;
            // 
            // check_consumidor_autoriza
            // 
            this.check_consumidor_autoriza.AutoSize = true;
            this.check_consumidor_autoriza.Location = new System.Drawing.Point(17, 91);
            this.check_consumidor_autoriza.Name = "check_consumidor_autoriza";
            this.check_consumidor_autoriza.Size = new System.Drawing.Size(41, 23);
            this.check_consumidor_autoriza.TabIndex = 7;
            this.check_consumidor_autoriza.Text = "Sí";
            this.check_consumidor_autoriza.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 38);
            this.label6.TabIndex = 6;
            this.label6.Text = "Suministra partes, refacciones o \r\nmatariales el consumidor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(477, 38);
            this.label5.TabIndex = 3;
            this.label5.Text = "El consumidor autoriza que se  utilicen partes o refacciones usadas \r\no reconstru" +
    "idas:";
            // 
            // grupo_precio
            // 
            this.grupo_precio.BackColor = System.Drawing.Color.LightGreen;
            this.grupo_precio.Controls.Add(this.txt_total);
            this.grupo_precio.Controls.Add(this.label8);
            this.grupo_precio.Controls.Add(this.txt_IVA);
            this.grupo_precio.Controls.Add(this.label9);
            this.grupo_precio.Controls.Add(this.txt_descuentoNumero);
            this.grupo_precio.Controls.Add(this.txt_descuento);
            this.grupo_precio.Controls.Add(this.label11);
            this.grupo_precio.Controls.Add(this.label7);
            this.grupo_precio.Controls.Add(this.txt_subtotal);
            this.grupo_precio.Controls.Add(this.label4);
            this.grupo_precio.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.grupo_precio.Location = new System.Drawing.Point(573, 224);
            this.grupo_precio.Name = "grupo_precio";
            this.grupo_precio.Size = new System.Drawing.Size(393, 253);
            this.grupo_precio.TabIndex = 26;
            this.grupo_precio.TabStop = false;
            this.grupo_precio.Text = "Precio";
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(183, 202);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(204, 31);
            this.txt_total.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(126, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Total:";
            // 
            // txt_IVA
            // 
            this.txt_IVA.Enabled = false;
            this.txt_IVA.Location = new System.Drawing.Point(183, 159);
            this.txt_IVA.Name = "txt_IVA";
            this.txt_IVA.Size = new System.Drawing.Size(204, 26);
            this.txt_IVA.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(136, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "IVA:";
            // 
            // txt_descuentoNumero
            // 
            this.txt_descuentoNumero.Enabled = false;
            this.txt_descuentoNumero.Location = new System.Drawing.Point(183, 117);
            this.txt_descuentoNumero.Name = "txt_descuentoNumero";
            this.txt_descuentoNumero.Size = new System.Drawing.Size(204, 26);
            this.txt_descuentoNumero.TabIndex = 2;
            // 
            // txt_descuento
            // 
            this.txt_descuento.Enabled = false;
            this.txt_descuento.Location = new System.Drawing.Point(183, 72);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(204, 26);
            this.txt_descuento.TabIndex = 2;
            this.txt_descuento.Leave += new System.EventHandler(this.txt_descuento_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(156, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 19);
            this.label11.TabIndex = 3;
            this.label11.Text = "$:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Descuento:";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(183, 28);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(204, 26);
            this.txt_subtotal.TabIndex = 1;
            this.txt_subtotal.TextChanged += new System.EventHandler(this.txt_subtotal_TextChanged);
            this.txt_subtotal.Leave += new System.EventHandler(this.txt_subtotal_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(527, 489);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 19);
            this.label12.TabIndex = 3;
            this.label12.Text = "Cantidad en letra:";
            // 
            // txt_cantidadLetra
            // 
            this.txt_cantidadLetra.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_cantidadLetra.Enabled = false;
            this.txt_cantidadLetra.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidadLetra.Location = new System.Drawing.Point(515, 511);
            this.txt_cantidadLetra.Name = "txt_cantidadLetra";
            this.txt_cantidadLetra.Size = new System.Drawing.Size(445, 31);
            this.txt_cantidadLetra.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(895, 598);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 23);
            this.label17.TabIndex = 30;
            this.label17.Text = "Finalizar";
            // 
            // lista_orden_materialBindingSource
            // 
            this.lista_orden_materialBindingSource.DataMember = "lista_orden_material";
            this.lista_orden_materialBindingSource.DataSource = this.glacial_servicioDataSet;
            // 
            // lista_orden_materialTableAdapter
            // 
            this.lista_orden_materialTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.automovil_inventarioTableAdapter = null;
            this.tableAdapterManager.automoviles_servicioTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.danos_vehiculoTableAdapter = null;
            this.tableAdapterManager.lista_orden_materialTableAdapter = this.lista_orden_materialTableAdapter;
            this.tableAdapterManager.lista_presupuestoTableAdapter = null;
            this.tableAdapterManager.orden_materialTableAdapter = this.orden_materialTableAdapter;
            this.tableAdapterManager.orden_servicio_infogeneralTableAdapter = null;
            this.tableAdapterManager.presupuesto_generalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial___Servicio.glacial_servicioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // orden_materialTableAdapter
            // 
            this.orden_materialTableAdapter.ClearBeforeFill = true;
            // 
            // orden_materialBindingSource
            // 
            this.orden_materialBindingSource.DataMember = "orden_material";
            this.orden_materialBindingSource.DataSource = this.glacial_servicioDataSet;
            // 
            // orden_servicio_infogeneralTableAdapter
            // 
            this.orden_servicio_infogeneralTableAdapter.ClearBeforeFill = true;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Image = global::Proyecto_Glacial___Servicio.Properties.Resources.DeleteRegister;
            this.btn_cerrar.Location = new System.Drawing.Point(937, 3);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(35, 35);
            this.btn_cerrar.TabIndex = 27;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Enabled = false;
            this.btn_siguiente.Image = global::Proyecto_Glacial___Servicio.Properties.Resources.checked_mark;
            this.btn_siguiente.Location = new System.Drawing.Point(703, 560);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(95, 73);
            this.btn_siguiente.TabIndex = 29;
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(813, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Finalizar";
            // 
            // frm_OrdenServicioAgregar04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(984, 664);
            this.ControlBox = false;
            this.Controls.Add(this.grupo_informacion);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_cantidadLetra);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grupo_precio);
            this.Controls.Add(this.grupo_infoAdicional);
            this.Controls.Add(this.grupo_materiales);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_OrdenServicioAgregar04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de servicio";
            this.Activated += new System.EventHandler(this.frm_OrdenServicioAgregar04_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_OrdenServicioAgregar04_FormClosed);
            this.Load += new System.EventHandler(this.frm_OrdenServicioAgregar03_Load);
            this.grupo_materiales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_piezasNecesitadas)).EndInit();
            this.grupo_informacion.ResumeLayout(false);
            this.grupo_informacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orden_servicio_infogeneralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_servicioDataSet)).EndInit();
            this.grupo_infoAdicional.ResumeLayout(false);
            this.grupo_infoAdicional.PerformLayout();
            this.grupo_precio.ResumeLayout(false);
            this.grupo_precio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista_orden_materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_materialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grupo_materiales;
        private System.Windows.Forms.DataGridView table_piezasNecesitadas;
        private System.Windows.Forms.GroupBox grupo_informacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grupo_infoAdicional;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grupo_precio;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_IVA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_borrarRegistro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_descuentoNumero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_cantidadLetra;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_guardar;
        private glacial_servicioDataSet glacial_servicioDataSet;
        private System.Windows.Forms.BindingSource lista_orden_materialBindingSource;
        private glacial_servicioDataSetTableAdapters.lista_orden_materialTableAdapter lista_orden_materialTableAdapter;
        private glacial_servicioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private glacial_servicioDataSetTableAdapters.orden_materialTableAdapter orden_materialTableAdapter;
        private System.Windows.Forms.BindingSource orden_materialBindingSource;
        private System.Windows.Forms.BindingSource orden_servicio_infogeneralBindingSource;
        private glacial_servicioDataSetTableAdapters.orden_servicio_infogeneralTableAdapter orden_servicio_infogeneralTableAdapter;
        private System.Windows.Forms.CheckBox check_suministra_partes;
        private System.Windows.Forms.CheckBox check_consumidor_autoriza;
        private System.Windows.Forms.TextBox txt_diagnostico_servicio;
        private System.Windows.Forms.TextBox txt_descripcionServicio;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewButtonColumn btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotal;
        private System.Windows.Forms.Label label2;
    }
}