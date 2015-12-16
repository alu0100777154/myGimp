namespace myGimp
{
    partial class FormLineal
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
            this.components = new System.ComponentModel.Container();
            this.xAxis1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yAxis1 = new System.Windows.Forms.TextBox();
            this.eRecta = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.xAxis2 = new System.Windows.Forms.TextBox();
            this.yAxis2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkCrear = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // xAxis1
            // 
            this.xAxis1.Location = new System.Drawing.Point(45, 105);
            this.xAxis1.Name = "xAxis1";
            this.xAxis1.Size = new System.Drawing.Size(100, 20);
            this.xAxis1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // yAxis1
            // 
            this.yAxis1.Location = new System.Drawing.Point(165, 105);
            this.yAxis1.Name = "yAxis1";
            this.yAxis1.Size = new System.Drawing.Size(100, 20);
            this.yAxis1.TabIndex = 2;
            // 
            // eRecta
            // 
            this.eRecta.Location = new System.Drawing.Point(45, 45);
            this.eRecta.Name = "eRecta";
            this.eRecta.Size = new System.Drawing.Size(100, 20);
            this.eRecta.TabIndex = 3;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(190, 226);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // xAxis2
            // 
            this.xAxis2.Location = new System.Drawing.Point(45, 146);
            this.xAxis2.Name = "xAxis2";
            this.xAxis2.Size = new System.Drawing.Size(100, 20);
            this.xAxis2.TabIndex = 5;
            // 
            // yAxis2
            // 
            this.yAxis2.Location = new System.Drawing.Point(165, 146);
            this.yAxis2.Name = "yAxis2";
            this.yAxis2.Size = new System.Drawing.Size(100, 20);
            this.yAxis2.TabIndex = 6;
            this.yAxis2.TextChanged += new System.EventHandler(this.yAxis2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "x2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "y2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "eRecta";
            // 
            // checkCrear
            // 
            this.checkCrear.AutoSize = true;
            this.checkCrear.Location = new System.Drawing.Point(45, 195);
            this.checkCrear.Name = "checkCrear";
            this.checkCrear.Size = new System.Drawing.Size(80, 17);
            this.checkCrear.TabIndex = 13;
            this.checkCrear.Text = "checkBox1";
            this.checkCrear.UseVisualStyleBackColor = true;
            this.checkCrear.CheckedChanged += new System.EventHandler(this.checkCrear_CheckedChanged);
            // 
            // FormLineal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.checkCrear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yAxis2);
            this.Controls.Add(this.xAxis2);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.eRecta);
            this.Controls.Add(this.yAxis1);
            this.Controls.Add(this.xAxis1);
            this.Name = "FormLineal";
            this.Text = "FormLineal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xAxis1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox yAxis1;
        private System.Windows.Forms.TextBox eRecta;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox xAxis2;
        private System.Windows.Forms.TextBox yAxis2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkCrear;
    }
}