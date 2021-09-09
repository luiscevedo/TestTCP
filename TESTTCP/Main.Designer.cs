
namespace TESTTCP
{
    partial class Main
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
            this.gridclients = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.Filtro = new System.Windows.Forms.Button();
            this.textsearchCab = new System.Windows.Forms.TextBox();
            this.btsearchCab = new System.Windows.Forms.Button();
            this.btnaddCab = new System.Windows.Forms.Button();
            this.gridcabecera = new System.Windows.Forms.DataGridView();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewLinkColumn2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabeceraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.razonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deshabilitadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridclients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcabecera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabeceraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridclients
            // 
            this.gridclients.AutoGenerateColumns = false;
            this.gridclients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridclients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.razonSocialDataGridViewTextBoxColumn,
            this.cuitDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.deshabilitadoDataGridViewCheckBoxColumn,
            this.Edit,
            this.Delete});
            this.gridclients.DataSource = this.clientsBindingSource;
            this.gridclients.Location = new System.Drawing.Point(12, 135);
            this.gridclients.Name = "gridclients";
            this.gridclients.Size = new System.Drawing.Size(776, 288);
            this.gridclients.TabIndex = 0;
            this.gridclients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridclients_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Clients";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(705, 75);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(66, 25);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btsearch
            // 
            this.btsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsearch.Location = new System.Drawing.Point(617, 75);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(72, 25);
            this.btsearch.TabIndex = 5;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // textsearch
            // 
            this.textsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsearch.Location = new System.Drawing.Point(118, 75);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(493, 26);
            this.textsearch.TabIndex = 6;
            // 
            // Filtro
            // 
            this.Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtro.Location = new System.Drawing.Point(695, 25);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(72, 25);
            this.Filtro.TabIndex = 7;
            this.Filtro.Text = "filtro";
            this.Filtro.UseVisualStyleBackColor = true;
            this.Filtro.Click += new System.EventHandler(this.Filtro_Click);
            // 
            // textsearchCab
            // 
            this.textsearchCab.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textsearchCab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsearchCab.Location = new System.Drawing.Point(107, 466);
            this.textsearchCab.Name = "textsearchCab";
            this.textsearchCab.Size = new System.Drawing.Size(493, 26);
            this.textsearchCab.TabIndex = 8;
            // 
            // btsearchCab
            // 
            this.btsearchCab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsearchCab.Location = new System.Drawing.Point(617, 453);
            this.btsearchCab.Name = "btsearchCab";
            this.btsearchCab.Size = new System.Drawing.Size(72, 25);
            this.btsearchCab.TabIndex = 9;
            this.btsearchCab.Text = "Search";
            this.btsearchCab.UseVisualStyleBackColor = true;
            // 
            // btnaddCab
            // 
            this.btnaddCab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddCab.Location = new System.Drawing.Point(695, 453);
            this.btnaddCab.Name = "btnaddCab";
            this.btnaddCab.Size = new System.Drawing.Size(66, 25);
            this.btnaddCab.TabIndex = 10;
            this.btnaddCab.Text = "Add";
            this.btnaddCab.UseVisualStyleBackColor = true;
            this.btnaddCab.Click += new System.EventHandler(this.btnaddCab_Click_1);
            // 
            // gridcabecera
            // 
            this.gridcabecera.AutoGenerateColumns = false;
            this.gridcabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcabecera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fechaAltaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.estadoDataGridViewTextBoxColumn,
            this.dataGridViewLinkColumn1,
            this.dataGridViewLinkColumn2});
            this.gridcabecera.DataSource = this.cabeceraBindingSource;
            this.gridcabecera.Location = new System.Drawing.Point(56, 519);
            this.gridcabecera.Name = "gridcabecera";
            this.gridcabecera.Size = new System.Drawing.Size(776, 288);
            this.gridcabecera.TabIndex = 11;
            this.gridcabecera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridcabecera_CellContentClick_1);
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.HeaderText = "Edit";
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.ReadOnly = true;
            this.dataGridViewLinkColumn1.Text = "Edit";
            this.dataGridViewLinkColumn1.UseColumnTextForLinkValue = true;
            // 
            // dataGridViewLinkColumn2
            // 
            this.dataGridViewLinkColumn2.HeaderText = "Delete";
            this.dataGridViewLinkColumn2.Name = "dataGridViewLinkColumn2";
            this.dataGridViewLinkColumn2.ReadOnly = true;
            this.dataGridViewLinkColumn2.Text = "Delete";
            this.dataGridViewLinkColumn2.UseColumnTextForLinkValue = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // fechaAltaDataGridViewTextBoxColumn
            // 
            this.fechaAltaDataGridViewTextBoxColumn.DataPropertyName = "FechaAlta";
            this.fechaAltaDataGridViewTextBoxColumn.HeaderText = "FechaAlta";
            this.fechaAltaDataGridViewTextBoxColumn.Name = "fechaAltaDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cli_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cli_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // cabeceraBindingSource
            // 
            this.cabeceraBindingSource.DataSource = typeof(TESTTCP.Cabecera);
            // 
            // razonSocialDataGridViewTextBoxColumn
            // 
            this.razonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial";
            this.razonSocialDataGridViewTextBoxColumn.HeaderText = "RazonSocial";
            this.razonSocialDataGridViewTextBoxColumn.Name = "razonSocialDataGridViewTextBoxColumn";
            // 
            // cuitDataGridViewTextBoxColumn
            // 
            this.cuitDataGridViewTextBoxColumn.DataPropertyName = "Cuit";
            this.cuitDataGridViewTextBoxColumn.HeaderText = "Cuit";
            this.cuitDataGridViewTextBoxColumn.Name = "cuitDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // deshabilitadoDataGridViewCheckBoxColumn
            // 
            this.deshabilitadoDataGridViewCheckBoxColumn.DataPropertyName = "Deshabilitado";
            this.deshabilitadoDataGridViewCheckBoxColumn.HeaderText = "Deshabilitado";
            this.deshabilitadoDataGridViewCheckBoxColumn.Name = "deshabilitadoDataGridViewCheckBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(TESTTCP.Clients);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(531, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filtrar ultimo dijo Cuit 8";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 502);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridcabecera);
            this.Controls.Add(this.btnaddCab);
            this.Controls.Add(this.btsearchCab);
            this.Controls.Add(this.textsearchCab);
            this.Controls.Add(this.Filtro);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridclients);
            this.Name = "Main";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridclients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcabecera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabeceraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridclients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Button Filtro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deshabilitadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.TextBox textsearchCab;
        private System.Windows.Forms.Button btsearchCab;
        private System.Windows.Forms.Button btnaddCab;
        private System.Windows.Forms.DataGridView gridcabecera;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn2;
        private System.Windows.Forms.BindingSource cabeceraBindingSource;
        private System.Windows.Forms.Label label2;
    }
}

