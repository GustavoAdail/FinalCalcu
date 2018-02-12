namespace PRACTICANDO
{
    partial class Form2
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnpromedio = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.lstpromedio = new System.Windows.Forms.ListBox();
            this.btnsuma = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un numero:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(126, 13);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 2;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            this.txt1.Validating += new System.ComponentModel.CancelEventHandler(this.txt1_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese un numero:";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(126, 63);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 4;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2_KeyPress);
            this.txt2.Validating += new System.ComponentModel.CancelEventHandler(this.txt2_Validating);
            // 
            // btnpromedio
            // 
            this.btnpromedio.Location = new System.Drawing.Point(12, 156);
            this.btnpromedio.Name = "btnpromedio";
            this.btnpromedio.Size = new System.Drawing.Size(75, 23);
            this.btnpromedio.TabIndex = 5;
            this.btnpromedio.Text = "Promedio";
            this.btnpromedio.UseVisualStyleBackColor = true;
            this.btnpromedio.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.Location = new System.Drawing.Point(93, 156);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(75, 23);
            this.btnmulti.TabIndex = 6;
            this.btnmulti.Text = "Multiplicar";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(184, 156);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(75, 23);
            this.btnresta.TabIndex = 7;
            this.btnresta.Text = "Restar";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // lstpromedio
            // 
            this.lstpromedio.FormattingEnabled = true;
            this.lstpromedio.Location = new System.Drawing.Point(267, 53);
            this.lstpromedio.Name = "lstpromedio";
            this.lstpromedio.Size = new System.Drawing.Size(98, 56);
            this.lstpromedio.TabIndex = 9;
            this.lstpromedio.SelectedIndexChanged += new System.EventHandler(this.lstpromedio_SelectedIndexChanged);
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(281, 156);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(75, 23);
            this.btnsuma.TabIndex = 10;
            this.btnsuma.Text = "Suma";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click_1);
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(267, 13);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(98, 20);
            this.txtresultado.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(410, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.lstpromedio);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btnpromedio);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRACTICANDO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnpromedio;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.ListBox lstpromedio;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button button1;
    }
}

