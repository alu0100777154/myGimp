namespace myGimp
{
    partial class Vecino
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
            this.label5 = new System.Windows.Forms.Label();
            this.ancho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.alto = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ancho";
            // 
            // ancho
            // 
            this.ancho.Location = new System.Drawing.Point(154, 69);
            this.ancho.Name = "ancho";
            this.ancho.Size = new System.Drawing.Size(100, 20);
            this.ancho.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Alto";
            // 
            // alto
            // 
            this.alto.Location = new System.Drawing.Point(36, 69);
            this.alto.Name = "alto";
            this.alto.Size = new System.Drawing.Size(100, 20);
            this.alto.TabIndex = 18;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(36, 117);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 17;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Location = new System.Drawing.Point(154, 122);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(62, 17);
            this.percent.TabIndex = 22;
            this.percent.Text = "percent";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.CheckedChanged += new System.EventHandler(this.percent_CheckedChanged);
            // 
            // Vecino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ancho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.alto);
            this.Controls.Add(this.btnEnviar);
            this.Name = "Vecino";
            this.Text = "Vecino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ancho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox alto;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.CheckBox percent;
    }
}