namespace InterfazActualizadaNuGet_WinForm.Formularios
{
    partial class Clientes
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
            this.FondoCliente = new System.Windows.Forms.Panel();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.listBclientes = new System.Windows.Forms.ListBox();
            this.lblClientes = new System.Windows.Forms.Label();
            this.FondoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // FondoCliente
            // 
            this.FondoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.FondoCliente.Controls.Add(this.btn_Clientes);
            this.FondoCliente.Controls.Add(this.listBclientes);
            this.FondoCliente.Controls.Add(this.lblClientes);
            this.FondoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FondoCliente.Location = new System.Drawing.Point(0, 0);
            this.FondoCliente.Name = "FondoCliente";
            this.FondoCliente.Size = new System.Drawing.Size(800, 450);
            this.FondoCliente.TabIndex = 0;
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clientes.Location = new System.Drawing.Point(222, 379);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(356, 59);
            this.btn_Clientes.TabIndex = 2;
            this.btn_Clientes.Text = "Mostrar Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // listBclientes
            // 
            this.listBclientes.BackColor = System.Drawing.Color.White;
            this.listBclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBclientes.FormattingEnabled = true;
            this.listBclientes.ItemHeight = 20;
            this.listBclientes.Location = new System.Drawing.Point(222, 40);
            this.listBclientes.Name = "listBclientes";
            this.listBclientes.Size = new System.Drawing.Size(356, 324);
            this.listBclientes.TabIndex = 1;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.White;
            this.lblClientes.Location = new System.Drawing.Point(343, 9);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(109, 29);
            this.lblClientes.TabIndex = 0;
            this.lblClientes.Text = "Clientes";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FondoCliente);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.FondoCliente.ResumeLayout(false);
            this.FondoCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FondoCliente;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.ListBox listBclientes;
        private System.Windows.Forms.Button btn_Clientes;
    }
}