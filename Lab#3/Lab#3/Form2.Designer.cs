namespace Lab_3
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.lvFrase = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btNext = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese una frase:";
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(293, 39);
            this.txtFrase.MaxLength = 200;
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(451, 28);
            this.txtFrase.TabIndex = 1;
            this.txtFrase.TextChanged += new System.EventHandler(this.txtFrase_TextChanged);
            this.txtFrase.DoubleClick += new System.EventHandler(this.txtFrase_DoubleClick);
            // 
            // lvFrase
            // 
            this.lvFrase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvFrase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvFrase.HideSelection = false;
            this.lvFrase.Location = new System.Drawing.Point(70, 99);
            this.lvFrase.Name = "lvFrase";
            this.lvFrase.Size = new System.Drawing.Size(759, 237);
            this.lvFrase.TabIndex = 2;
            this.lvFrase.UseCompatibleStateImageBehavior = false;
            this.lvFrase.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Iniciales en frase";
            this.columnHeader1.Width = 181;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Palabra mas larga";
            this.columnHeader2.Width = 196;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Max Longuitud";
            this.columnHeader3.Width = 156;
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.SteelBlue;
            this.btNext.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btNext.Location = new System.Drawing.Point(243, 355);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(178, 51);
            this.btNext.TabIndex = 3;
            this.btNext.Text = "Siguiente";
            this.btNext.UseVisualStyleBackColor = false;
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackColor = System.Drawing.Color.DimGray;
            this.btLimpiar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btLimpiar.Location = new System.Drawing.Point(455, 355);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(178, 51);
            this.btLimpiar.TabIndex = 4;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = false;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(290, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "*doble click para detalles";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(936, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.lvFrase);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Detalles de Frase";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.ListView lvFrase;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label label2;
    }
}