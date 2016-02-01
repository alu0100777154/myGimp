namespace myGimp
{
    partial class FormPrincipal
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeGrisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rOIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramaAcumulativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espejoVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espejoHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traspuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotacion90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotacion180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotacion270ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vecinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilinealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rotacionXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Seleccionar un archivo de imagen";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.transformacionesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.zoomToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarImagenToolStripMenuItem,
            this.guardarImagenToolStripMenuItem,
            this.cerrarToolStripMenuItem,
            this.borrarImagenToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.fileToolStripMenuItem.Text = "Archivo";
            // 
            // cargarImagenToolStripMenuItem
            // 
            this.cargarImagenToolStripMenuItem.Name = "cargarImagenToolStripMenuItem";
            this.cargarImagenToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cargarImagenToolStripMenuItem.Text = "Cargar imagen";
            this.cargarImagenToolStripMenuItem.Click += new System.EventHandler(this.cargarImagenToolStripMenuItem_Click);
            // 
            // guardarImagenToolStripMenuItem
            // 
            this.guardarImagenToolStripMenuItem.Name = "guardarImagenToolStripMenuItem";
            this.guardarImagenToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.guardarImagenToolStripMenuItem.Text = "Guardar imagen";
            this.guardarImagenToolStripMenuItem.Click += new System.EventHandler(this.guardarImagenToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // borrarImagenToolStripMenuItem
            // 
            this.borrarImagenToolStripMenuItem.Name = "borrarImagenToolStripMenuItem";
            this.borrarImagenToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.borrarImagenToolStripMenuItem.Text = "Borrar Imagen";
            this.borrarImagenToolStripMenuItem.Click += new System.EventHandler(this.borrarImagenToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramaToolStripMenuItem,
            this.escalaDeGrisesToolStripMenuItem,
            this.rOIToolStripMenuItem,
            this.histogramaAcumulativoToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // histogramaToolStripMenuItem
            // 
            this.histogramaToolStripMenuItem.Name = "histogramaToolStripMenuItem";
            this.histogramaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.histogramaToolStripMenuItem.Text = "Histograma";
            this.histogramaToolStripMenuItem.Click += new System.EventHandler(this.histogramaToolStripMenuItem_Click);
            // 
            // escalaDeGrisesToolStripMenuItem
            // 
            this.escalaDeGrisesToolStripMenuItem.Name = "escalaDeGrisesToolStripMenuItem";
            this.escalaDeGrisesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.escalaDeGrisesToolStripMenuItem.Text = "Escala de grises";
            this.escalaDeGrisesToolStripMenuItem.Click += new System.EventHandler(this.escalaDeGrisesToolStripMenuItem_Click);
            // 
            // rOIToolStripMenuItem
            // 
            this.rOIToolStripMenuItem.Name = "rOIToolStripMenuItem";
            this.rOIToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.rOIToolStripMenuItem.Text = "ROI";
            this.rOIToolStripMenuItem.Click += new System.EventHandler(this.rOIToolStripMenuItem_Click);
            // 
            // histogramaAcumulativoToolStripMenuItem
            // 
            this.histogramaAcumulativoToolStripMenuItem.Name = "histogramaAcumulativoToolStripMenuItem";
            this.histogramaAcumulativoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.histogramaAcumulativoToolStripMenuItem.Text = "Histograma acumulativo";
            this.histogramaAcumulativoToolStripMenuItem.Click += new System.EventHandler(this.histogramaAcumulativoToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // transformacionesToolStripMenuItem
            // 
            this.transformacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linealToolStripMenuItem,
            this.brilloToolStripMenuItem,
            this.gammaToolStripMenuItem,
            this.ecualizarToolStripMenuItem,
            this.espejoVerticalToolStripMenuItem,
            this.espejoHorizontalToolStripMenuItem,
            this.traspuestaToolStripMenuItem,
            this.rotacion90ToolStripMenuItem,
            this.rotacion180ToolStripMenuItem,
            this.rotacion270ToolStripMenuItem,
            this.rotacionXToolStripMenuItem});
            this.transformacionesToolStripMenuItem.Name = "transformacionesToolStripMenuItem";
            this.transformacionesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.transformacionesToolStripMenuItem.Text = "Transformaciones";
            // 
            // linealToolStripMenuItem
            // 
            this.linealToolStripMenuItem.Name = "linealToolStripMenuItem";
            this.linealToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.linealToolStripMenuItem.Text = "Lineal";
            this.linealToolStripMenuItem.Click += new System.EventHandler(this.linealToolStripMenuItem_Click);
            // 
            // brilloToolStripMenuItem
            // 
            this.brilloToolStripMenuItem.Name = "brilloToolStripMenuItem";
            this.brilloToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.brilloToolStripMenuItem.Text = "Brillo";
            this.brilloToolStripMenuItem.Click += new System.EventHandler(this.brilloToolStripMenuItem_Click);
            // 
            // gammaToolStripMenuItem
            // 
            this.gammaToolStripMenuItem.Name = "gammaToolStripMenuItem";
            this.gammaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.gammaToolStripMenuItem.Text = "Gamma";
            this.gammaToolStripMenuItem.Click += new System.EventHandler(this.gammaToolStripMenuItem_Click);
            // 
            // ecualizarToolStripMenuItem
            // 
            this.ecualizarToolStripMenuItem.Name = "ecualizarToolStripMenuItem";
            this.ecualizarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ecualizarToolStripMenuItem.Text = "Ecualizar";
            this.ecualizarToolStripMenuItem.Click += new System.EventHandler(this.ecualizarToolStripMenuItem_Click);
            // 
            // espejoVerticalToolStripMenuItem
            // 
            this.espejoVerticalToolStripMenuItem.Name = "espejoVerticalToolStripMenuItem";
            this.espejoVerticalToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.espejoVerticalToolStripMenuItem.Text = "EspejoVertical";
            this.espejoVerticalToolStripMenuItem.Click += new System.EventHandler(this.espejoVerticalToolStripMenuItem_Click);
            // 
            // espejoHorizontalToolStripMenuItem
            // 
            this.espejoHorizontalToolStripMenuItem.Name = "espejoHorizontalToolStripMenuItem";
            this.espejoHorizontalToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.espejoHorizontalToolStripMenuItem.Text = "EspejoHorizontal";
            this.espejoHorizontalToolStripMenuItem.Click += new System.EventHandler(this.espejoHorizontalToolStripMenuItem_Click);
            // 
            // traspuestaToolStripMenuItem
            // 
            this.traspuestaToolStripMenuItem.Name = "traspuestaToolStripMenuItem";
            this.traspuestaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.traspuestaToolStripMenuItem.Text = "Traspuesta";
            this.traspuestaToolStripMenuItem.Click += new System.EventHandler(this.traspuestaToolStripMenuItem_Click);
            // 
            // rotacion90ToolStripMenuItem
            // 
            this.rotacion90ToolStripMenuItem.Name = "rotacion90ToolStripMenuItem";
            this.rotacion90ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.rotacion90ToolStripMenuItem.Text = "Rotacion90";
            this.rotacion90ToolStripMenuItem.Click += new System.EventHandler(this.rotacionToolStripMenuItem_Click);
            // 
            // rotacion180ToolStripMenuItem
            // 
            this.rotacion180ToolStripMenuItem.Name = "rotacion180ToolStripMenuItem";
            this.rotacion180ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.rotacion180ToolStripMenuItem.Text = "Rotacion180";
            this.rotacion180ToolStripMenuItem.Click += new System.EventHandler(this.rotacion180ToolStripMenuItem_Click);
            // 
            // rotacion270ToolStripMenuItem
            // 
            this.rotacion270ToolStripMenuItem.Name = "rotacion270ToolStripMenuItem";
            this.rotacion270ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.rotacion270ToolStripMenuItem.Text = "Rotacion270";
            this.rotacion270ToolStripMenuItem.Click += new System.EventHandler(this.rotacion270ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vecinoToolStripMenuItem,
            this.bilinealToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // vecinoToolStripMenuItem
            // 
            this.vecinoToolStripMenuItem.Name = "vecinoToolStripMenuItem";
            this.vecinoToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.vecinoToolStripMenuItem.Text = "Vecino";
            this.vecinoToolStripMenuItem.Click += new System.EventHandler(this.vecinoToolStripMenuItem_Click_1);
            // 
            // bilinealToolStripMenuItem
            // 
            this.bilinealToolStripMenuItem.Name = "bilinealToolStripMenuItem";
            this.bilinealToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.bilinealToolStripMenuItem.Text = "Bilineal";
            this.bilinealToolStripMenuItem.Click += new System.EventHandler(this.bilinealToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // rotacionXToolStripMenuItem
            // 
            this.rotacionXToolStripMenuItem.Name = "rotacionXToolStripMenuItem";
            this.rotacionXToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.rotacionXToolStripMenuItem.Text = "RotacionX";
            this.rotacionXToolStripMenuItem.Click += new System.EventHandler(this.rotacionXToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 371);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarImagenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guardarImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaDeGrisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rOIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramaAcumulativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brilloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espejoVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espejoHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traspuestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotacion90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotacion180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotacion270ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vecinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilinealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotacionXToolStripMenuItem;
    }
}

