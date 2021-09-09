
namespace TESTTCP
{
    partial class CabeceraDetails
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsaveCAB = new System.Windows.Forms.Button();
            this.btncancelCAB = new System.Windows.Forms.Button();
            this.btnBuscarClients = new System.Windows.Forms.Button();
            this.txtbusClients = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Estado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha Alta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(158, 75);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(341, 26);
            this.txtEstado.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cliente ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnsaveCAB
            // 
            this.btnsaveCAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveCAB.Location = new System.Drawing.Point(233, 167);
            this.btnsaveCAB.Name = "btnsaveCAB";
            this.btnsaveCAB.Size = new System.Drawing.Size(68, 32);
            this.btnsaveCAB.TabIndex = 17;
            this.btnsaveCAB.Text = "Save";
            this.btnsaveCAB.UseVisualStyleBackColor = true;
            this.btnsaveCAB.Click += new System.EventHandler(this.btnsaveCAB_Click);
            // 
            // btncancelCAB
            // 
            this.btncancelCAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelCAB.Location = new System.Drawing.Point(316, 167);
            this.btncancelCAB.Name = "btncancelCAB";
            this.btncancelCAB.Size = new System.Drawing.Size(68, 32);
            this.btncancelCAB.TabIndex = 18;
            this.btncancelCAB.Text = "Cancel";
            this.btncancelCAB.UseVisualStyleBackColor = true;
            this.btncancelCAB.Click += new System.EventHandler(this.btncancelCAB_Click);
            // 
            // btnBuscarClients
            // 
            this.btnBuscarClients.Location = new System.Drawing.Point(307, 110);
            this.btnBuscarClients.Name = "btnBuscarClients";
            this.btnBuscarClients.Size = new System.Drawing.Size(43, 22);
            this.btnBuscarClients.TabIndex = 27;
            this.btnBuscarClients.Text = ".....";
            this.btnBuscarClients.UseVisualStyleBackColor = true;
            this.btnBuscarClients.Click += new System.EventHandler(this.btnBuscarNumCliente_Click);
            // 
            // txtbusClients
            // 
            this.txtbusClients.Location = new System.Drawing.Point(166, 112);
            this.txtbusClients.Name = "txtbusClients";
            this.txtbusClients.ReadOnly = true;
            this.txtbusClients.Size = new System.Drawing.Size(135, 20);
            this.txtbusClients.TabIndex = 26;
            this.txtbusClients.TextChanged += new System.EventHandler(this.txtNumCliente_TextChanged);
            // 
            // CabeceraDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 268);
            this.Controls.Add(this.btnBuscarClients);
            this.Controls.Add(this.txtbusClients);
            this.Controls.Add(this.btncancelCAB);
            this.Controls.Add(this.btnsaveCAB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CabeceraDetails";
            this.Text = "CabeceraDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsaveCAB;
        private System.Windows.Forms.Button btncancelCAB;
        private System.Windows.Forms.Button btnBuscarClients;
        private System.Windows.Forms.TextBox txtbusClients;
    }
}