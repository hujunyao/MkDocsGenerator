namespace MkDocsGenerator
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuildPage = new System.Windows.Forms.Button();
            this.btnGenerateMd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Controls.Add(this.pbMinimize);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 91);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::MkDocsGenerator.Properties.Resources.close;
            this.pbClose.Location = new System.Drawing.Point(612, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(24, 24);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbClose.TabIndex = 6;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimize.Image = global::MkDocsGenerator.Properties.Resources.minimize;
            this.pbMinimize.Location = new System.Drawing.Point(582, 12);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(23, 23);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMinimize.TabIndex = 5;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MkDocsGenerator.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(25, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(113, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Panel de Documentación FE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBuildPage
            // 
            this.btnBuildPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnBuildPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuildPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuildPage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this.btnBuildPage.ForeColor = System.Drawing.Color.White;
            this.btnBuildPage.Location = new System.Drawing.Point(25, 169);
            this.btnBuildPage.Name = "btnBuildPage";
            this.btnBuildPage.Size = new System.Drawing.Size(280, 78);
            this.btnBuildPage.TabIndex = 1;
            this.btnBuildPage.Text = "Generar página";
            this.btnBuildPage.UseVisualStyleBackColor = false;
            this.btnBuildPage.Click += new System.EventHandler(this.btnBuildPage_Click);
            // 
            // btnGenerateMd
            // 
            this.btnGenerateMd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnGenerateMd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateMd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateMd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this.btnGenerateMd.ForeColor = System.Drawing.Color.White;
            this.btnGenerateMd.Location = new System.Drawing.Point(337, 169);
            this.btnGenerateMd.Name = "btnGenerateMd";
            this.btnGenerateMd.Size = new System.Drawing.Size(280, 78);
            this.btnGenerateMd.TabIndex = 2;
            this.btnGenerateMd.Text = "Generar .md";
            this.btnGenerateMd.UseVisualStyleBackColor = false;
            this.btnGenerateMd.Click += new System.EventHandler(this.btnGenerateMd_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 329);
            this.Controls.Add(this.btnGenerateMd);
            this.Controls.Add(this.btnBuildPage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.Button btnBuildPage;
        private System.Windows.Forms.Button btnGenerateMd;
    }
}