namespace InterfazActualizadaNuGet_WinForm.Formularios
{
    partial class Actualizar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Actualiza = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.text_cliente = new System.Windows.Forms.TextBox();
            this.list_Todos_clientes = new System.Windows.Forms.ListBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.btnSeleccionar);
            this.panel1.Controls.Add(this.btn_Actualiza);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.text_cliente);
            this.panel1.Controls.Add(this.list_Todos_clientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // btn_Actualiza
            // 
            this.btn_Actualiza.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Actualiza.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Actualiza.IconColor = System.Drawing.Color.Black;
            this.btn_Actualiza.IconSize = 16;
            this.btn_Actualiza.Location = new System.Drawing.Point(429, 180);
            this.btn_Actualiza.Name = "btn_Actualiza";
            this.btn_Actualiza.Rotation = 0D;
            this.btn_Actualiza.Size = new System.Drawing.Size(267, 61);
            this.btn_Actualiza.TabIndex = 3;
            this.btn_Actualiza.Text = "Actualizar Dato";
            this.btn_Actualiza.UseVisualStyleBackColor = true;
            this.btn_Actualiza.Click += new System.EventHandler(this.btn_Actualiza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el Cliente";
            // 
            // text_cliente
            // 
            this.text_cliente.Enabled = false;
            this.text_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_cliente.Location = new System.Drawing.Point(429, 108);
            this.text_cliente.Name = "text_cliente";
            this.text_cliente.Size = new System.Drawing.Size(267, 30);
            this.text_cliente.TabIndex = 1;
            // 
            // list_Todos_clientes
            // 
            this.list_Todos_clientes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.list_Todos_clientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Todos_clientes.FormattingEnabled = true;
            this.list_Todos_clientes.ItemHeight = 24;
            this.list_Todos_clientes.Location = new System.Drawing.Point(12, 40);
            this.list_Todos_clientes.Name = "list_Todos_clientes";
            this.list_Todos_clientes.Size = new System.Drawing.Size(271, 316);
            this.list_Todos_clientes.TabIndex = 0;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(13, 374);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(270, 45);
            this.btnSeleccionar.TabIndex = 4;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Actualizar";
            this.Text = "Ajustes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox list_Todos_clientes;
        private System.Windows.Forms.TextBox text_cliente;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_Actualiza;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}