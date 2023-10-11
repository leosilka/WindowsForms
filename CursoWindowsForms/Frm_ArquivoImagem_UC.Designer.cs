namespace CursoWindowsForms
{
    partial class Frm_ArquivoImagem_UC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Lbl_ArquivoImagem = new Label();
            Pic_ArquivoImagem = new PictureBox();
            Btn_Cor = new Button();
            Btn_Fonte = new Button();
            ((System.ComponentModel.ISupportInitialize)Pic_ArquivoImagem).BeginInit();
            SuspendLayout();
            // 
            // Lbl_ArquivoImagem
            // 
            Lbl_ArquivoImagem.AutoSize = true;
            Lbl_ArquivoImagem.Location = new Point(17, 36);
            Lbl_ArquivoImagem.Name = "Lbl_ArquivoImagem";
            Lbl_ArquivoImagem.Size = new Size(38, 15);
            Lbl_ArquivoImagem.TabIndex = 0;
            Lbl_ArquivoImagem.Text = "label1";
            // 
            // Pic_ArquivoImagem
            // 
            Pic_ArquivoImagem.Location = new Point(17, 80);
            Pic_ArquivoImagem.Name = "Pic_ArquivoImagem";
            Pic_ArquivoImagem.Size = new Size(209, 156);
            Pic_ArquivoImagem.TabIndex = 1;
            Pic_ArquivoImagem.TabStop = false;
            // 
            // Btn_Cor
            // 
            Btn_Cor.Location = new Point(17, 10);
            Btn_Cor.Name = "Btn_Cor";
            Btn_Cor.Size = new Size(75, 23);
            Btn_Cor.TabIndex = 2;
            Btn_Cor.Text = "Cor";
            Btn_Cor.UseVisualStyleBackColor = true;
            Btn_Cor.Click += Btn_Cor_Click;
            // 
            // Btn_Fonte
            // 
            Btn_Fonte.Location = new Point(98, 10);
            Btn_Fonte.Name = "Btn_Fonte";
            Btn_Fonte.Size = new Size(75, 23);
            Btn_Fonte.TabIndex = 3;
            Btn_Fonte.Text = "Fonte";
            Btn_Fonte.UseVisualStyleBackColor = true;
            Btn_Fonte.Click += Btn_Fonte_Click;
            // 
            // Frm_ArquivoImagem_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Btn_Fonte);
            Controls.Add(Btn_Cor);
            Controls.Add(Pic_ArquivoImagem);
            Controls.Add(Lbl_ArquivoImagem);
            Name = "Frm_ArquivoImagem_UC";
            Size = new Size(736, 326);
            ((System.ComponentModel.ISupportInitialize)Pic_ArquivoImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_ArquivoImagem;
        private PictureBox Pic_ArquivoImagem;
        private Button Btn_Cor;
        private Button Btn_Fonte;
    }
}
