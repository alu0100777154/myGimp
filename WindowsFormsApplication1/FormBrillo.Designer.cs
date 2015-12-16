namespace myGimp
{
    partial class FormBrillo
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
            this.label4 = new System.Windows.Forms.Label();
            this.brillo = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.contraste = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Brillo";
            // 
            // brillo
            // 
            this.brillo.Location = new System.Drawing.Point(41, 64);
            this.brillo.Name = "brillo";
            this.brillo.Size = new System.Drawing.Size(100, 20);
            this.brillo.TabIndex = 13;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(41, 112);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 12;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Contraste";
            // 
            // contraste
            // 
            this.contraste.Location = new System.Drawing.Point(159, 64);
            this.contraste.Name = "contraste";
            this.contraste.Size = new System.Drawing.Size(100, 20);
            this.contraste.TabIndex = 15;
            // 
            // FormBrillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contraste);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.brillo);
            this.Controls.Add(this.btnEnviar);
            this.Name = "FormBrillo";
            this.Text = "FormBrillo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox brillo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contraste;
    }
}