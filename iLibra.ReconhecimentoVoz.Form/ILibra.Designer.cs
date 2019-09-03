namespace iLibra.ReconhecimentoVoz.Forms
{
    partial class ILibra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ILibra));
            this.LblFechar = new System.Windows.Forms.Label();
            this.PanelLibraBorda = new System.Windows.Forms.Panel();
            this.PanelLibraCentro = new System.Windows.Forms.Panel();
            this.ImgPalavra = new System.Windows.Forms.PictureBox();
            this.LblPalavra = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelLibraBorda.SuspendLayout();
            this.PanelLibraCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPalavra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFechar
            // 
            this.LblFechar.AutoSize = true;
            this.LblFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblFechar.Location = new System.Drawing.Point(689, 9);
            this.LblFechar.Name = "LblFechar";
            this.LblFechar.Size = new System.Drawing.Size(31, 36);
            this.LblFechar.TabIndex = 2;
            this.LblFechar.Text = "X";
            this.LblFechar.Click += new System.EventHandler(this.LblFechar_Click);
            // 
            // PanelLibraBorda
            // 
            this.PanelLibraBorda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(20)))), ((int)(((byte)(91)))));
            this.PanelLibraBorda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelLibraBorda.Controls.Add(this.PanelLibraCentro);
            this.PanelLibraBorda.Location = new System.Drawing.Point(193, 108);
            this.PanelLibraBorda.Name = "PanelLibraBorda";
            this.PanelLibraBorda.Size = new System.Drawing.Size(332, 262);
            this.PanelLibraBorda.TabIndex = 4;
            // 
            // PanelLibraCentro
            // 
            this.PanelLibraCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(20)))), ((int)(((byte)(91)))));
            this.PanelLibraCentro.Controls.Add(this.ImgPalavra);
            this.PanelLibraCentro.Location = new System.Drawing.Point(3, 3);
            this.PanelLibraCentro.Name = "PanelLibraCentro";
            this.PanelLibraCentro.Size = new System.Drawing.Size(324, 254);
            this.PanelLibraCentro.TabIndex = 5;
            this.PanelLibraCentro.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLibraCentro_Paint);
            // 
            // ImgPalavra
            // 
            this.ImgPalavra.BackColor = System.Drawing.Color.Black;
            this.ImgPalavra.Location = new System.Drawing.Point(0, 0);
            this.ImgPalavra.Name = "ImgPalavra";
            this.ImgPalavra.Size = new System.Drawing.Size(323, 254);
            this.ImgPalavra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImgPalavra.TabIndex = 0;
            this.ImgPalavra.TabStop = false;
            // 
            // LblPalavra
            // 
            this.LblPalavra.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPalavra.Location = new System.Drawing.Point(207, 373);
            this.LblPalavra.Name = "LblPalavra";
            this.LblPalavra.Size = new System.Drawing.Size(318, 65);
            this.LblPalavra.TabIndex = 5;
            this.LblPalavra.Text = "~ Palavra Falada ~";
            this.LblPalavra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::iLibra.ReconhecimentoVoz.Forms.Properties.Resources.fiap;
            this.pictureBox1.Location = new System.Drawing.Point(248, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ILibra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(732, 466);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblPalavra);
            this.Controls.Add(this.PanelLibraBorda);
            this.Controls.Add(this.LblFechar);
            this.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ILibra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iLibra - Reconhecimento de Voz";
            this.Load += new System.EventHandler(this.ILibra_Load);
            this.PanelLibraBorda.ResumeLayout(false);
            this.PanelLibraCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgPalavra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblFechar;
        private System.Windows.Forms.Panel PanelLibraBorda;
        private System.Windows.Forms.Panel PanelLibraCentro;
        private System.Windows.Forms.Label LblPalavra;
        private System.Windows.Forms.PictureBox ImgPalavra;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

