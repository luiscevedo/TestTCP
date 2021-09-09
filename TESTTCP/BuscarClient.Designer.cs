
namespace TESTTCP
{
    partial class BuscarClient
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
            this.btnBuscarClients = new System.Windows.Forms.Button();
            this.txtIDclients = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelID = new System.Windows.Forms.Button();
            this.btnsaveID = new System.Windows.Forms.Button();
            this.gridclients = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deshabilitadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridclients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarClients
            // 
            this.btnBuscarClients.Location = new System.Drawing.Point(327, 23);
            this.btnBuscarClients.Name = "btnBuscarClients";
            this.btnBuscarClients.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarClients.TabIndex = 6;
            this.btnBuscarClients.Text = "Buscar";
            this.btnBuscarClients.UseVisualStyleBackColor = true;
            this.btnBuscarClients.Click += new System.EventHandler(this.btnBuscarClients_Click);
            // 
            // txtIDclients
            // 
            this.txtIDclients.Location = new System.Drawing.Point(150, 25);
            this.txtIDclients.Name = "txtIDclients";
            this.txtIDclients.Size = new System.Drawing.Size(163, 20);
            this.txtIDclients.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Cliente:";
            // 
            // btncancelID
            // 
            this.btncancelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelID.Location = new System.Drawing.Point(398, 322);
            this.btncancelID.Name = "btncancelID";
            this.btncancelID.Size = new System.Drawing.Size(68, 32);
            this.btncancelID.TabIndex = 20;
            this.btncancelID.Text = "Cancel";
            this.btncancelID.UseVisualStyleBackColor = true;
            // 
            // btnsaveID
            // 
            this.btnsaveID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveID.Location = new System.Drawing.Point(315, 322);
            this.btnsaveID.Name = "btnsaveID";
            this.btnsaveID.Size = new System.Drawing.Size(68, 32);
            this.btnsaveID.TabIndex = 19;
            this.btnsaveID.Text = "Save";
            this.btnsaveID.UseVisualStyleBackColor = true;
            this.btnsaveID.Click += new System.EventHandler(this.btnsaveID_Click);
            // 
            // gridclients
            // 
            this.gridclients.AutoGenerateColumns = false;
            this.gridclients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridclients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.razonSocialDataGridViewTextBoxColumn,
            this.cuitDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.deshabilitadoDataGridViewCheckBoxColumn,
            this.Seleccionar});
            this.gridclients.DataSource = this.clientsBindingSource;
            this.gridclients.Location = new System.Drawing.Point(12, 104);
            this.gridclients.Name = "gridclients";
            this.gridclients.Size = new System.Drawing.Size(776, 180);
            this.gridclients.TabIndex = 21;
            this.gridclients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridclients_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.DataPropertyName = "ID";
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseColumnTextForLinkValue = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
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
            // BuscarClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridclients);
            this.Controls.Add(this.btncancelID);
            this.Controls.Add(this.btnsaveID);
            this.Controls.Add(this.btnBuscarClients);
            this.Controls.Add(this.txtIDclients);
            this.Controls.Add(this.label1);
            this.Name = "BuscarClient";
            this.Text = "BuscarClient";
            ((System.ComponentModel.ISupportInitialize)(this.gridclients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarClients;
        private System.Windows.Forms.TextBox txtIDclients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancelID;
        private System.Windows.Forms.Button btnsaveID;
        private System.Windows.Forms.DataGridView gridclients;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deshabilitadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Seleccionar;
    }
}