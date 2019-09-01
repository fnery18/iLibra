namespace iLibra.ReconhecimentoVoz
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblFechar = new System.Windows.Forms.Label();
            this.LblSubTitulo = new System.Windows.Forms.Label();
            this.PanelLibraBorda = new System.Windows.Forms.Panel();
            this.PanelLibraCentro = new System.Windows.Forms.Panel();
            this.LblPalavra = new System.Windows.Forms.Label();
            this.ImgPalavra = new System.Windows.Forms.PictureBox();
            this.ImgIcone = new System.Windows.Forms.PictureBox();
            this.PanelLibraBorda.SuspendLayout();
            this.PanelLibraCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPalavra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(12, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(708, 67);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "iLibra - Reconhecimento de Voz";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // LblSubTitulo
            // 
            this.LblSubTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTitulo.Location = new System.Drawing.Point(12, 79);
            this.LblSubTitulo.Name = "LblSubTitulo";
            this.LblSubTitulo.Size = new System.Drawing.Size(708, 46);
            this.LblSubTitulo.TabIndex = 3;
            this.LblSubTitulo.Text = "Vamos lá! Não seja tímido, fale alguma palavra e iremos traduzir para libras :)";
            this.LblSubTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelLibraBorda
            // 
            this.PanelLibraBorda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.PanelLibraBorda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelLibraBorda.Controls.Add(this.PanelLibraCentro);
            this.PanelLibraBorda.Location = new System.Drawing.Point(207, 128);
            this.PanelLibraBorda.Name = "PanelLibraBorda";
            this.PanelLibraBorda.Size = new System.Drawing.Size(318, 245);
            this.PanelLibraBorda.TabIndex = 4;
            // 
            // PanelLibraCentro
            // 
            this.PanelLibraCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(181)))), ((int)(((byte)(217)))));
            this.PanelLibraCentro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelLibraCentro.Controls.Add(this.ImgPalavra);
            this.PanelLibraCentro.Location = new System.Drawing.Point(4, 4);
            this.PanelLibraCentro.Name = "PanelLibraCentro";
            this.PanelLibraCentro.Size = new System.Drawing.Size(308, 235);
            this.PanelLibraCentro.TabIndex = 5;
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
            // ImgPalavra
            // 
            this.ImgPalavra.Location = new System.Drawing.Point(3, 3);
            this.ImgPalavra.Name = "ImgPalavra";
            this.ImgPalavra.Size = new System.Drawing.Size(298, 225);
            this.ImgPalavra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImgPalavra.TabIndex = 0;
            this.ImgPalavra.TabStop = false;
            // 
            // ImgIcone
            // 
            this.ImgIcone.BackColor = System.Drawing.Color.Transparent;
            this.ImgIcone.Image = global::iLibra.ReconhecimentoVoz.Properties.Resources.voice_recognition;
            this.ImgIcone.Location = new System.Drawing.Point(635, 392);
            this.ImgIcone.Name = "ImgIcone";
            this.ImgIcone.Size = new System.Drawing.Size(95, 80);
            this.ImgIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgIcone.TabIndex = 1;
            this.ImgIcone.TabStop = false;
            // 
            // ILibra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(181)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(732, 466);
            this.Controls.Add(this.LblPalavra);
            this.Controls.Add(this.PanelLibraBorda);
            this.Controls.Add(this.LblSubTitulo);
            this.Controls.Add(this.LblFechar);
            this.Controls.Add(this.ImgIcone);
            this.Controls.Add(this.LblTitulo);
            this.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ILibra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iLibra - Reconhecimento de Voz";
            this.PanelLibraBorda.ResumeLayout(false);
            this.PanelLibraCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgPalavra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox ImgIcone;
        private System.Windows.Forms.Label LblFechar;
        private System.Windows.Forms.Label LblSubTitulo;
        private System.Windows.Forms.Panel PanelLibraBorda;
        private System.Windows.Forms.Panel PanelLibraCentro;
        private System.Windows.Forms.Label LblPalavra;
        private System.Windows.Forms.PictureBox ImgPalavra;
    }
}

