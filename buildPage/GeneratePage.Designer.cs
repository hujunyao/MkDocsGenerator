namespace MkDocsGenerator
{
    partial class BuildPage
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
            this.txtEstructura = new System.Windows.Forms.TextBox();
            this.btnEstructura = new System.Windows.Forms.Button();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listboxResultados = new System.Windows.Forms.ListBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "1) Seleccione la ruta de la estructura:";
            // 
            // txtEstructura
            // 
            this.txtEstructura.Enabled = false;
            this.txtEstructura.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstructura.Location = new System.Drawing.Point(125, 51);
            this.txtEstructura.Name = "txtEstructura";
            this.txtEstructura.Size = new System.Drawing.Size(439, 28);
            this.txtEstructura.TabIndex = 1;
            // 
            // btnEstructura
            // 
            this.btnEstructura.BackColor = System.Drawing.Color.White;
            this.btnEstructura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEstructura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstructura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstructura.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstructura.ForeColor = System.Drawing.Color.Black;
            this.btnEstructura.Location = new System.Drawing.Point(584, 51);
            this.btnEstructura.Name = "btnEstructura";
            this.btnEstructura.Size = new System.Drawing.Size(149, 28);
            this.btnEstructura.TabIndex = 2;
            this.btnEstructura.Text = "Examinar...";
            this.btnEstructura.UseVisualStyleBackColor = false;
            this.btnEstructura.Click += new System.EventHandler(this.btnEstructura_Click);
            // 
            // txtSalida
            // 
            this.txtSalida.Enabled = false;
            this.txtSalida.Font = new System.Drawing.Font("Consolas", 13F);
            this.txtSalida.Location = new System.Drawing.Point(125, 138);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(608, 28);
            this.txtSalida.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.label2.Location = new System.Drawing.Point(17, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "2) Ruta de salida:";
            // 
            // listboxResultados
            // 
            this.listboxResultados.FormattingEnabled = true;
            this.listboxResultados.Location = new System.Drawing.Point(12, 269);
            this.listboxResultados.Name = "listboxResultados";
            this.listboxResultados.Size = new System.Drawing.Size(721, 147);
            this.listboxResultados.TabIndex = 6;
            this.listboxResultados.SizeChanged += new System.EventHandler(this.listboxResultados_SizeChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(40, 205);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(663, 39);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.listboxResultados);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEstructura);
            this.panel1.Controls.Add(this.btnEstructura);
            this.panel1.Controls.Add(this.txtSalida);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 426);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Generador .md a html";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::MkDocsGenerator.Properties.Resources.close;
            this.pbClose.Location = new System.Drawing.Point(735, 9);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(24, 24);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbClose.TabIndex = 4;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimize.Image = global::MkDocsGenerator.Properties.Resources.minimize;
            this.pbMinimize.Location = new System.Drawing.Point(705, 9);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(23, 23);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMinimize.TabIndex = 3;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MkDocsGenerator.Properties.Resources.buildPage;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BuildPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(771, 508);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.pbMinimize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuildPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentación FE";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BuildPage_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstructura;
        private System.Windows.Forms.Button btnEstructura;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox listboxResultados;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbClose;
    }
}

