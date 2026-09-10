namespace Lab_3
{
    partial class Form1
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
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.lvNumeros = new System.Windows.Forms.ListView();
            this.Numeros = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Primos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Perfectos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPrimos = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lbPerfectos = new System.Windows.Forms.Label();
            this.btNext = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumeros
            // 
            this.txtNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeros.Location = new System.Drawing.Point(46, 101);
            this.txtNumeros.MaxLength = 30;
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(100, 29);
            this.txtNumeros.TabIndex = 0;
            // 
            // lvNumeros
            // 
            this.lvNumeros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numeros,
            this.Primos,
            this.Perfectos});
            this.lvNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvNumeros.HideSelection = false;
            this.lvNumeros.Location = new System.Drawing.Point(260, 68);
            this.lvNumeros.Name = "lvNumeros";
            this.lvNumeros.Size = new System.Drawing.Size(273, 351);
            this.lvNumeros.TabIndex = 1;
            this.lvNumeros.UseCompatibleStateImageBehavior = false;
            this.lvNumeros.View = System.Windows.Forms.View.Details;
            // 
            // Numeros
            // 
            this.Numeros.Text = "Numeros";
            this.Numeros.Width = 107;
            // 
            // Primos
            // 
            this.Primos.DisplayIndex = 2;
            this.Primos.Text = "Primos";
            // 
            // Perfectos
            // 
            this.Perfectos.DisplayIndex = 1;
            this.Perfectos.Text = "Perfectos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Primos y Perfectos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Escriba un numero";
            // 
            // lbPrimos
            // 
            this.lbPrimos.AutoSize = true;
            this.lbPrimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrimos.Location = new System.Drawing.Point(557, 143);
            this.lbPrimos.Name = "lbPrimos";
            this.lbPrimos.Size = new System.Drawing.Size(74, 24);
            this.lbPrimos.TabIndex = 4;
            this.lbPrimos.Text = "Primos";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(41, 166);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(115, 51);
            this.btCalcular.TabIndex = 6;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lbPerfectos
            // 
            this.lbPerfectos.AutoSize = true;
            this.lbPerfectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerfectos.Location = new System.Drawing.Point(557, 211);
            this.lbPerfectos.Name = "lbPerfectos";
            this.lbPerfectos.Size = new System.Drawing.Size(74, 24);
            this.lbPerfectos.TabIndex = 7;
            this.lbPerfectos.Text = "Primos";
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.SteelBlue;
            this.btNext.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btNext.Location = new System.Drawing.Point(41, 249);
            this.btNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(134, 41);
            this.btNext.TabIndex = 8;
            this.btNext.Text = "Siguiente";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackColor = System.Drawing.Color.DimGray;
            this.btLimpiar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btLimpiar.Location = new System.Drawing.Point(41, 318);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(134, 44);
            this.btLimpiar.TabIndex = 9;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = false;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.lbPerfectos);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbPrimos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvNumeros);
            this.Controls.Add(this.txtNumeros);
            this.Name = "Form1";
            this.Text = "Primos y Perfectos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.ListView lvNumeros;
        private System.Windows.Forms.ColumnHeader Primos;
        private System.Windows.Forms.ColumnHeader Numeros;
        private System.Windows.Forms.ColumnHeader Perfectos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPrimos;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lbPerfectos;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btLimpiar;
    }
}

