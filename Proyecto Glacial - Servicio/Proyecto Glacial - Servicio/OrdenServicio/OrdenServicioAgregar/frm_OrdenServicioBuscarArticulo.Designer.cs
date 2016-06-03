namespace Proyecto_Glacial___Servicio.OrdenServicio
{
    partial class frm_OrdenServicioBuscarArticulo
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
            this.productosDataGridView = new System.Windows.Forms.DataGridView();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glacial_almacenDataSet = new Proyecto_Glacial___Servicio.glacial_almacenDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_busqueda = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.productosTableAdapter = new Proyecto_Glacial___Servicio.glacial_almacenDataSetTableAdapters.productosTableAdapter();
            this.tableAdapterManager = new Proyecto_Glacial___Servicio.glacial_almacenDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_especial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // productosDataGridView
            // 
            this.productosDataGridView.AutoGenerateColumns = false;
            this.productosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.nombre,
            this.unidad_medida,
            this.dataGridViewTextBoxColumn6,
            this.precio_especial});
            this.productosDataGridView.DataSource = this.productosBindingSource;
            this.productosDataGridView.Location = new System.Drawing.Point(12, 105);
            this.productosDataGridView.Name = "productosDataGridView";
            this.productosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productosDataGridView.Size = new System.Drawing.Size(745, 280);
            this.productosDataGridView.TabIndex = 1;
            this.productosDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productosDataGridView_CellDoubleClick);
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.glacial_almacenDataSet;
            // 
            // glacial_almacenDataSet
            // 
            this.glacial_almacenDataSet.DataSetName = "glacial_almacenDataSet";
            this.glacial_almacenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Búsqueda de productos";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(179, 60);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(393, 31);
            this.txt_buscar.TabIndex = 3;
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar por:";
            // 
            // cmb_busqueda
            // 
            this.cmb_busqueda.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_busqueda.FormattingEnabled = true;
            this.cmb_busqueda.Items.AddRange(new object[] {
            "Código",
            "Descripción"});
            this.cmb_busqueda.Location = new System.Drawing.Point(16, 60);
            this.cmb_busqueda.Name = "cmb_busqueda";
            this.cmb_busqueda.Size = new System.Drawing.Size(157, 31);
            this.cmb_busqueda.TabIndex = 5;
            this.cmb_busqueda.Text = "Seleccione...";
            this.cmb_busqueda.SelectedIndexChanged += new System.EventHandler(this.cmb_busqueda_SelectedIndexChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = global::Proyecto_Glacial___Servicio.Properties.Resources.searchButton;
            this.btn_buscar.Location = new System.Drawing.Point(578, 54);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(45, 45);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.productosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proyecto_Glacial___Servicio.glacial_almacenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_linea_producto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 95;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Línea";
            this.nombre.Name = "nombre";
            this.nombre.Width = 130;
            // 
            // unidad_medida
            // 
            this.unidad_medida.DataPropertyName = "unidad_medida";
            this.unidad_medida.HeaderText = "Unidad";
            this.unidad_medida.Name = "unidad_medida";
            this.unidad_medida.Width = 130;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 300;
            // 
            // precio_especial
            // 
            this.precio_especial.DataPropertyName = "precio_especial";
            this.precio_especial.HeaderText = "Precio Especial";
            this.precio_especial.Name = "precio_especial";
            // 
            // frm_OrdenServicioBuscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 397);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.cmb_busqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productosDataGridView);
            this.Name = "frm_OrdenServicioBuscarArticulo";
            this.Text = "Buscar productos";
            this.Load += new System.EventHandler(this.frm_OrdenServicioBuscarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glacial_almacenDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private glacial_almacenDataSet glacial_almacenDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private glacial_almacenDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private glacial_almacenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView productosDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_busqueda;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_especial;
    }
}