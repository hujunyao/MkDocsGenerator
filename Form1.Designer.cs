namespace MkDocsGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtEstructura = new System.Windows.Forms.TextBox();
            this.btnEstructura = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listboxResultados = new System.Windows.Forms.ListBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la ruta de la estructura:";
            // 
            // txtEstructura
            // 
            this.txtEstructura.Enabled = false;
            this.txtEstructura.Location = new System.Drawing.Point(34, 55);
            this.txtEstructura.Name = "txtEstructura";
            this.txtEstructura.Size = new System.Drawing.Size(214, 20);
            this.txtEstructura.TabIndex = 1;
            // 
            // btnEstructura
            // 
            this.btnEstructura.Location = new System.Drawing.Point(266, 53);
            this.btnEstructura.Name = "btnEstructura";
            this.btnEstructura.Size = new System.Drawing.Size(75, 23);
            this.btnEstructura.TabIndex = 2;
            this.btnEstructura.Text = "button1";
            this.btnEstructura.UseVisualStyleBackColor = true;
            this.btnEstructura.Click += new System.EventHandler(this.btnEstructura_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(266, 124);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(75, 23);
            this.btnSalida.TabIndex = 5;
            this.btnSalida.Text = "button2";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // txtSalida
            // 
            this.txtSalida.Enabled = false;
            this.txtSalida.Location = new System.Drawing.Point(34, 126);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(214, 20);
            this.txtSalida.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione la ruta de salida:";
            // 
            // listboxResultados
            // 
            this.listboxResultados.FormattingEnabled = true;
            this.listboxResultados.Location = new System.Drawing.Point(34, 226);
            this.listboxResultados.Name = "listboxResultados";
            this.listboxResultados.Size = new System.Drawing.Size(307, 134);
            this.listboxResultados.TabIndex = 6;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(34, 169);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(307, 36);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 385);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.listboxResultados);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEstructura);
            this.Controls.Add(this.txtEstructura);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtEstructura;
        private System.Windows.Forms.Button btnEstructura;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox listboxResultados;
        private System.Windows.Forms.Button btnGenerar;
    }
}

