namespace Parador
{
    partial class frm_Historial
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
            this.dgv_Historial = new System.Windows.Forms.DataGridView();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaHistorialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parador_SanTiagoDataSet = new Parador.Parador_SanTiagoDataSet();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btn_Estado = new System.Windows.Forms.Button();
            this.vista_HistorialTableAdapter = new Parador.Parador_SanTiagoDataSetTableAdapters.Vista_HistorialTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Historial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaHistorialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parador_SanTiagoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Historial
            // 
            this.dgv_Historial.AutoGenerateColumns = false;
            this.dgv_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Historial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcionDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dgv_Historial.DataSource = this.vistaHistorialBindingSource;
            this.dgv_Historial.Location = new System.Drawing.Point(104, 139);
            this.dgv_Historial.Name = "dgv_Historial";
            this.dgv_Historial.Size = new System.Drawing.Size(243, 333);
            this.dgv_Historial.TabIndex = 0;
            this.dgv_Historial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Historial_CellContentClick);
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // vistaHistorialBindingSource
            // 
            this.vistaHistorialBindingSource.DataMember = "Vista_Historial";
            this.vistaHistorialBindingSource.DataSource = this.parador_SanTiagoDataSet;
            // 
            // parador_SanTiagoDataSet
            // 
            this.parador_SanTiagoDataSet.DataSetName = "Parador_SanTiagoDataSet";
            this.parador_SanTiagoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(104, 76);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(243, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(208, 60);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Buscar";
            // 
            // btn_Estado
            // 
            this.btn_Estado.Location = new System.Drawing.Point(190, 102);
            this.btn_Estado.Name = "btn_Estado";
            this.btn_Estado.Size = new System.Drawing.Size(75, 23);
            this.btn_Estado.TabIndex = 4;
            this.btn_Estado.Text = "Cambiar";
            this.btn_Estado.UseVisualStyleBackColor = true;
            // 
            // vista_HistorialTableAdapter
            // 
            this.vista_HistorialTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 539);
            this.Controls.Add(this.btn_Estado);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgv_Historial);
            this.Name = "frm_Historial";
            this.Text = "frm_Historial";
            this.Load += new System.EventHandler(this.frm_Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Historial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaHistorialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parador_SanTiagoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Historial;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btn_Estado;
        private Parador_SanTiagoDataSet parador_SanTiagoDataSet;
        private System.Windows.Forms.BindingSource vistaHistorialBindingSource;
        private Parador_SanTiagoDataSetTableAdapters.Vista_HistorialTableAdapter vista_HistorialTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}