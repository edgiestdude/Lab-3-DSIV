namespace Lab_3
{
    partial class Form3
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbIngreso = new System.Windows.Forms.Label();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.btAgregarPalabra = new System.Windows.Forms.Button();
            this.listPalabras = new System.Windows.Forms.ListBox();
            this.lbCantPalabras = new System.Windows.Forms.Label();
            this.lbPalabraLarga = new System.Windows.Forms.Label();
            this.lbPalabraCorta = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(283, 28);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(266, 30);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Registro de Palabras";
            this.lbTitulo.Click += new System.EventHandler(this.btAgregarPalabra_Click);
            // 
            // lbIngreso
            // 
            this.lbIngreso.AutoSize = true;
            this.lbIngreso.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngreso.Location = new System.Drawing.Point(121, 94);
            this.lbIngreso.Name = "lbIngreso";
            this.lbIngreso.Size = new System.Drawing.Size(197, 25);
            this.lbIngreso.TabIndex = 1;
            this.lbIngreso.Text = "Ingrese una palabra";
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(382, 81);
            this.txtPalabra.MaxLength = 50;
            this.txtPalabra.Multiline = true;
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(344, 50);
            this.txtPalabra.TabIndex = 2;
            this.txtPalabra.TextChanged += new System.EventHandler(this.txtPalabra_TextChanged);
            // 
            // btAgregarPalabra
            // 
            this.btAgregarPalabra.BackColor = System.Drawing.Color.SteelBlue;
            this.btAgregarPalabra.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarPalabra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAgregarPalabra.Location = new System.Drawing.Point(288, 157);
            this.btAgregarPalabra.Name = "btAgregarPalabra";
            this.btAgregarPalabra.Size = new System.Drawing.Size(234, 61);
            this.btAgregarPalabra.TabIndex = 4;
            this.btAgregarPalabra.Text = "Agregar Palabra";
            this.btAgregarPalabra.UseVisualStyleBackColor = false;
            this.btAgregarPalabra.Click += new System.EventHandler(this.btAgregarPalabra_Click);


            // 
            // listPalabras
            // 
            this.listPalabras.FormattingEnabled = true;
            this.listPalabras.ItemHeight = 16;
            this.listPalabras.Location = new System.Drawing.Point(34, 253);
            this.listPalabras.Name = "listPalabras";
            this.listPalabras.Size = new System.Drawing.Size(382, 356);
            this.listPalabras.TabIndex = 5;
            // 
            // lbCantPalabras
            // 
            this.lbCantPalabras.AutoSize = true;
            this.lbCantPalabras.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantPalabras.Location = new System.Drawing.Point(470, 269);
            this.lbCantPalabras.Name = "lbCantPalabras";
            this.lbCantPalabras.Size = new System.Drawing.Size(210, 25);
            this.lbCantPalabras.TabIndex = 6;
            this.lbCantPalabras.Text = "Cantidad de Palabras";
            // 
            // lbPalabraLarga
            // 
            this.lbPalabraLarga.AutoSize = true;
            this.lbPalabraLarga.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPalabraLarga.Location = new System.Drawing.Point(472, 317);
            this.lbPalabraLarga.Name = "lbPalabraLarga";
            this.lbPalabraLarga.Size = new System.Drawing.Size(192, 25);
            this.lbPalabraLarga.TabIndex = 7;
            this.lbPalabraLarga.Text = "Palabra mas Larga";
            // 
            // lbPalabraCorta
            // 
            this.lbPalabraCorta.AutoSize = true;
            this.lbPalabraCorta.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPalabraCorta.Location = new System.Drawing.Point(472, 367);
            this.lbPalabraCorta.Name = "lbPalabraCorta";
            this.lbPalabraCorta.Size = new System.Drawing.Size(181, 25);
            this.lbPalabraCorta.TabIndex = 8;
            this.lbPalabraCorta.Text = "Palabra mas corta";
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackColor = System.Drawing.Color.DimGray;
            this.btLimpiar.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btLimpiar.Location = new System.Drawing.Point(475, 485);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(178, 51);
            this.btLimpiar.TabIndex = 9;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = false;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btCerrar.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCerrar.Location = new System.Drawing.Point(475, 558);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(178, 51);
            this.btCerrar.TabIndex = 10;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = false;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 662);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.lbPalabraCorta);
            this.Controls.Add(this.lbPalabraLarga);
            this.Controls.Add(this.lbCantPalabras);
            this.Controls.Add(this.listPalabras);
            this.Controls.Add(this.btAgregarPalabra);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.lbIngreso);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Form3";
            this.Text = "Análisis de Palabras";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbIngreso;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Button btAgregarPalabra;
        private System.Windows.Forms.ListBox listPalabras;
        private System.Windows.Forms.Label lbCantPalabras;
        private System.Windows.Forms.Label lbPalabraLarga;
        private System.Windows.Forms.Label lbPalabraCorta;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btCerrar;
    }
}