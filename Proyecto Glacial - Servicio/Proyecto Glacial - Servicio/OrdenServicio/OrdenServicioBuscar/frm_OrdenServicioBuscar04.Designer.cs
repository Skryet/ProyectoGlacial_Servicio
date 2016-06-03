namespace Proyecto_Glacial___Servicio.OrdenServicio.OrdenServicioBuscar
{
    partial class frm_OrdenServicioBuscar04
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
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label label4;
            this.grupo_informacion = new System.Windows.Forms.GroupBox();
            this.diagnostico_servicioTextBox = new System.Windows.Forms.TextBox();
            this.orden_servicio_infogeneralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glacial_servicioDataSet = new Proyecto_Glacial___Servicio.glacial_servicioDataSet();
            this.descripcion_servicioTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lista_orden_material = new System.Windows.Forms.TextBox();
            this.grupo_precio = new System.Windows.Forms.GroupBox();
            this.txt_totalLetra = new System.Windows.Forms.TextBox();
            this.lbl_totalLetra = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.grupo_infoAdicional = new System.Windows.Forms.GroupBox();
            this.consumidor_suministra_partesCheckBox = new System.Windows.Forms.CheckBox();
            this.consumidor_autoriza_partesCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grupo_materiales = new System.Windows.Forms.GroupBox();
            this.orden_materialDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden_materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.orden_servicio_infogeneralTableAdapter = new Proyecto_Glacial___Servicio.glacial_servicioDataSetTableAdapters.orden_servicio_infogeneralTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial___Servicio.glacial_servicioDataSetTableAdapters.TableAdapterManager();
            this.orden_materialTableAdapter = new Proyecto_Glacial___Servicio.glacial_servicioDataSetTableAdapters.orden_materialTableAdapter();
            this.btn_salir = new System.Windows.Forms.Button();
            totalLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.grupo_informacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orden_servicio_infogeneralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_servicioDataSet)).BeginInit();
            this.grupo_precio.SuspendLayout();
            this.grupo_infoAdicional.SuspendLayout();
            this.grupo_materiales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orden_materialDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_materialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(6, 22);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(51, 19);
            totalLabel.TabIndex = 0;
            totalLabel.Text = "Total:";
            // 
            // grupo_informacion
            // 
            this.grupo_informacion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grupo_informacion.Controls.Add(this.diagnostico_servicioTextBox);
            this.grupo_informacion.Controls.Add(this.descripcion_servicioTextBox);
            this.grupo_informacion.Controls.Add(this.label3);
            this.grupo_informacion.Controls.Add(this.label2);
            this.grupo_informacion.Controls.Add(this.txt_lista_orden_material);
            this.grupo_informacion.Enabled = false;
            this.grupo_informacion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.grupo_informacion.Location = new System.Drawing.Point(9, 51);
            this.grupo_informacion.Name = "grupo_informacion";
            this.grupo_informacion.Size = new System.Drawing.Size(743, 177);
            this.grupo_informacion.TabIndex = 30;
            this.grupo_informacion.TabStop = false;
            this.grupo_informacion.Text = "Información";
            // 
            // diagnostico_servicioTextBox
            // 
            this.diagnostico_servicioTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.diagnostico_servicioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_servicio_infogeneralBindingSource, "diagnostico_servicio", true));
            this.diagnostico_servicioTextBox.Location = new System.Drawing.Point(285, 44);
            this.diagnostico_servicioTextBox.Multiline = true;
            this.diagnostico_servicioTextBox.Name = "diagnostico_servicioTextBox";
            this.diagnostico_servicioTextBox.Size = new System.Drawing.Size(414, 122);
            this.diagnostico_servicioTextBox.TabIndex = 35;
            // 
            // orden_servicio_infogeneralBindingSource
            // 
            this.orden_servicio_infogeneralBindingSource.DataMember = "orden_servicio_infogeneral";
            this.orden_servicio_infogeneralBindingSource.DataSource = this.glacial_servicioDataSet;
            // 
            // glacial_servicioDataSet
            // 
            this.glacial_servicioDataSet.DataSetName = "glacial_servicioDataSet";
            this.glacial_servicioDataSet.EnforceConstraints = false;
            this.glacial_servicioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // descripcion_servicioTextBox
            // 
            this.descripcion_servicioTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.descripcion_servicioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_servicio_infogeneralBindingSource, "descripcion_servicio", true));
            this.descripcion_servicioTextBox.Enabled = false;
            this.descripcion_servicioTextBox.Location = new System.Drawing.Point(16, 44);
            this.descripcion_servicioTextBox.Multiline = true;
            this.descripcion_servicioTextBox.Name = "descripcion_servicioTextBox";
            this.descripcion_servicioTextBox.Size = new System.Drawing.Size(245, 122);
            this.descripcion_servicioTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Diagnóstico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción del servicio solicitado:";
            // 
            // txt_lista_orden_material
            // 
            this.txt_lista_orden_material.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_servicio_infogeneralBindingSource, "id_lista_orden_material", true));
            this.txt_lista_orden_material.Location = new System.Drawing.Point(586, 98);
            this.txt_lista_orden_material.Name = "txt_lista_orden_material";
            this.txt_lista_orden_material.Size = new System.Drawing.Size(100, 26);
            this.txt_lista_orden_material.TabIndex = 34;
            // 
            // grupo_precio
            // 
            this.grupo_precio.BackColor = System.Drawing.Color.LightGreen;
            this.grupo_precio.Controls.Add(this.txt_totalLetra);
            this.grupo_precio.Controls.Add(this.lbl_totalLetra);
            this.grupo_precio.Controls.Add(totalLabel);
            this.grupo_precio.Controls.Add(this.totalTextBox);
            this.grupo_precio.Enabled = false;
            this.grupo_precio.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.grupo_precio.Location = new System.Drawing.Point(511, 424);
            this.grupo_precio.Name = "grupo_precio";
            this.grupo_precio.Size = new System.Drawing.Size(240, 149);
            this.grupo_precio.TabIndex = 31;
            this.grupo_precio.TabStop = false;
            this.grupo_precio.Text = "$";
            // 
            // txt_totalLetra
            // 
            this.txt_totalLetra.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.txt_totalLetra.Location = new System.Drawing.Point(6, 76);
            this.txt_totalLetra.Multiline = true;
            this.txt_totalLetra.Name = "txt_totalLetra";
            this.txt_totalLetra.Size = new System.Drawing.Size(221, 52);
            this.txt_totalLetra.TabIndex = 3;
            // 
            // lbl_totalLetra
            // 
            this.lbl_totalLetra.AutoSize = true;
            this.lbl_totalLetra.Location = new System.Drawing.Point(6, 91);
            this.lbl_totalLetra.Name = "lbl_totalLetra";
            this.lbl_totalLetra.Size = new System.Drawing.Size(0, 19);
            this.lbl_totalLetra.TabIndex = 2;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_servicio_infogeneralBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(6, 44);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(221, 26);
            this.totalTextBox.TabIndex = 1;
            // 
            // grupo_infoAdicional
            // 
            this.grupo_infoAdicional.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grupo_infoAdicional.Controls.Add(this.consumidor_suministra_partesCheckBox);
            this.grupo_infoAdicional.Controls.Add(this.consumidor_autoriza_partesCheckBox);
            this.grupo_infoAdicional.Controls.Add(this.label6);
            this.grupo_infoAdicional.Controls.Add(this.label5);
            this.grupo_infoAdicional.Enabled = false;
            this.grupo_infoAdicional.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.grupo_infoAdicional.Location = new System.Drawing.Point(9, 424);
            this.grupo_infoAdicional.Name = "grupo_infoAdicional";
            this.grupo_infoAdicional.Size = new System.Drawing.Size(490, 207);
            this.grupo_infoAdicional.TabIndex = 32;
            this.grupo_infoAdicional.TabStop = false;
            this.grupo_infoAdicional.Text = "Información adicional";
            // 
            // consumidor_suministra_partesCheckBox
            // 
            this.consumidor_suministra_partesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.orden_servicio_infogeneralBindingSource, "consumidor_suministra_partes", true));
            this.consumidor_suministra_partesCheckBox.Location = new System.Drawing.Point(11, 162);
            this.consumidor_suministra_partesCheckBox.Name = "consumidor_suministra_partesCheckBox";
            this.consumidor_suministra_partesCheckBox.Size = new System.Drawing.Size(43, 24);
            this.consumidor_suministra_partesCheckBox.TabIndex = 8;
            this.consumidor_suministra_partesCheckBox.Text = "Sí";
            this.consumidor_suministra_partesCheckBox.UseVisualStyleBackColor = true;
            // 
            // consumidor_autoriza_partesCheckBox
            // 
            this.consumidor_autoriza_partesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.orden_servicio_infogeneralBindingSource, "consumidor_autoriza_partes", true));
            this.consumidor_autoriza_partesCheckBox.Location = new System.Drawing.Point(11, 91);
            this.consumidor_autoriza_partesCheckBox.Name = "consumidor_autoriza_partesCheckBox";
            this.consumidor_autoriza_partesCheckBox.Size = new System.Drawing.Size(42, 24);
            this.consumidor_autoriza_partesCheckBox.TabIndex = 7;
            this.consumidor_autoriza_partesCheckBox.Text = "Sí";
            this.consumidor_autoriza_partesCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(417, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Suministra partes, refacciones o  matariales el consumidor:";
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
            // grupo_materiales
            // 
            this.grupo_materiales.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grupo_materiales.Controls.Add(this.orden_materialDataGridView);
            this.grupo_materiales.Enabled = false;
            this.grupo_materiales.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.grupo_materiales.Location = new System.Drawing.Point(8, 234);
            this.grupo_materiales.Name = "grupo_materiales";
            this.grupo_materiales.Size = new System.Drawing.Size(744, 184);
            this.grupo_materiales.TabIndex = 33;
            this.grupo_materiales.TabStop = false;
            this.grupo_materiales.Text = "Materiales";
            // 
            // orden_materialDataGridView
            // 
            this.orden_materialDataGridView.AutoGenerateColumns = false;
            this.orden_materialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orden_materialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.orden_materialDataGridView.DataSource = this.orden_materialBindingSource;
            this.orden_materialDataGridView.Location = new System.Drawing.Point(11, 25);
            this.orden_materialDataGridView.Name = "orden_materialDataGridView";
            this.orden_materialDataGridView.Size = new System.Drawing.Size(689, 153);
            this.orden_materialDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_orden_material";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_orden_material";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_lista_orden_material";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_lista_orden_material";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Código";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "unidad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Unidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "precioUnitario";
            this.dataGridViewTextBoxColumn7.HeaderText = "Precio Unitario";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "precioTotal";
            this.dataGridViewTextBoxColumn8.HeaderText = "Precio Total";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // orden_materialBindingSource
            // 
            this.orden_materialBindingSource.DataMember = "orden_material";
            this.orden_materialBindingSource.DataSource = this.glacial_servicioDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.label1.Location = new System.Drawing.Point(288, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 36);
            this.label1.TabIndex = 29;
            this.label1.Text = "Orden de servicio";
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
            // orden_materialTableAdapter
            // 
            this.orden_materialTableAdapter.ClearBeforeFill = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::Proyecto_Glacial___Servicio.Properties.Resources.Close;
            this.btn_salir.Location = new System.Drawing.Point(676, 578);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 76);
            this.btn_salir.TabIndex = 35;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(598, 615);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 39);
            label4.TabIndex = 0;
            label4.Text = "Salir";
            // 
            // frm_OrdenServicioBuscar04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 663);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(label4);
            this.Controls.Add(this.grupo_informacion);
            this.Controls.Add(this.grupo_precio);
            this.Controls.Add(this.grupo_infoAdicional);
            this.Controls.Add(this.grupo_materiales);
            this.Controls.Add(this.label1);
            this.Name = "frm_OrdenServicioBuscar04";
            this.Text = "Buscar Orden de Servicio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_OrdenServicioBuscar04_FormClosed);
            this.Load += new System.EventHandler(this.frm_OrdenServicioBuscar04_Load);
            this.grupo_informacion.ResumeLayout(false);
            this.grupo_informacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orden_servicio_infogeneralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_servicioDataSet)).EndInit();
            this.grupo_precio.ResumeLayout(false);
            this.grupo_precio.PerformLayout();
            this.grupo_infoAdicional.ResumeLayout(false);
            this.grupo_infoAdicional.PerformLayout();
            this.grupo_materiales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orden_materialDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_materialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grupo_informacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grupo_precio;
        private System.Windows.Forms.GroupBox grupo_infoAdicional;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grupo_materiales;
        private System.Windows.Forms.Label label1;
        private glacial_servicioDataSet glacial_servicioDataSet;
        private System.Windows.Forms.BindingSource orden_servicio_infogeneralBindingSource;
        private glacial_servicioDataSetTableAdapters.orden_servicio_infogeneralTableAdapter orden_servicio_infogeneralTableAdapter;
        private glacial_servicioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox consumidor_suministra_partesCheckBox;
        private System.Windows.Forms.CheckBox consumidor_autoriza_partesCheckBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox descripcion_servicioTextBox;
        private System.Windows.Forms.Label lbl_totalLetra;
        private System.Windows.Forms.TextBox txt_totalLetra;
        private System.Windows.Forms.BindingSource orden_materialBindingSource;
        private glacial_servicioDataSetTableAdapters.orden_materialTableAdapter orden_materialTableAdapter;
        private System.Windows.Forms.DataGridView orden_materialDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox txt_lista_orden_material;
        private System.Windows.Forms.TextBox diagnostico_servicioTextBox;
        private System.Windows.Forms.Button btn_salir;
    }
}