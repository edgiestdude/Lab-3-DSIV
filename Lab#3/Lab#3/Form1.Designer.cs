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
            System.Windows.Forms.Label lbPerfectos;
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPrimos = new System.Windows.Forms.Label();
            this.Numeros = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Perfectos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Primos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lbPerfectos = new System.Windows.Forms.Label();
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numeros,
            this.Primos,
            this.Perfectos});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(247, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(273, 351);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.lbPrimos.Location = new System.Drawing.Point(600, 131);
            this.lbPrimos.Name = "lbPrimos";
            this.lbPrimos.Size = new System.Drawing.Size(188, 24);
            this.lbPrimos.TabIndex = 4;
            this.lbPrimos.Text = "Escriba un numero";
            // 
            // lbPerfectos
            // 
            lbPerfectos.AutoSize = true;
            lbPerfectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbPerfectos.Location = new System.Drawing.Point(600, 207);
            lbPerfectos.Name = "lbPerfectos";
            lbPerfectos.Size = new System.Drawing.Size(188, 24);
            lbPerfectos.TabIndex = 5;
            lbPerfectos.Text = "Escriba un numero";
            // 
            // Numeros
            // 
            this.Numeros.Text = "Numeros";
            this.Numeros.Width = 107;
            // 
            // Perfectos
            // 
            this.Perfectos.DisplayIndex = 1;
            this.Perfectos.Text = "Perfectos";
            // 
            // Primos
            // 
            this.Primos.DisplayIndex = 2;
            this.Primos.Text = "Primos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(lbPerfectos);
            this.Controls.Add(this.lbPrimos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtNumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Primos;
        private System.Windows.Forms.ColumnHeader Numeros;
        private System.Windows.Forms.ColumnHeader Perfectos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPrimos;
    }
}

