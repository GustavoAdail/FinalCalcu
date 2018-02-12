namespace PRACTICANDO
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumeros = new System.Windows.Forms.TextBox();
            this.txtletras = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOLO NUMEROS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOLO LETRAS:";
            // 
            // txtnumeros
            // 
            this.txtnumeros.AccessibleDescription = "";
            this.txtnumeros.Location = new System.Drawing.Point(116, 35);
            this.txtnumeros.MaxLength = 5;
            this.txtnumeros.Name = "txtnumeros";
            this.txtnumeros.Size = new System.Drawing.Size(175, 20);
            this.txtnumeros.TabIndex = 2;
            this.txtnumeros.TextChanged += new System.EventHandler(this.txtnumeros_TextChanged);
            this.txtnumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumeros_KeyPress);
            // 
            // txtletras
            // 
            this.txtletras.Location = new System.Drawing.Point(116, 110);
            this.txtletras.Name = "txtletras";
            this.txtletras.Size = new System.Drawing.Size(175, 20);
            this.txtletras.TabIndex = 3;
            this.txtletras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtletras_KeyPress);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 261);
            this.Controls.Add(this.txtletras);
            this.Controls.Add(this.txtnumeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumeros;
        private System.Windows.Forms.TextBox txtletras;
    }
}