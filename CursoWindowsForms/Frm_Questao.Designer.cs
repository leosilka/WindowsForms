namespace CursoWindowsForms
{
    partial class Frm_Questao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Questao));
            Lbl_Questao = new Label();
            Btn_OK = new Button();
            Btn_Cancel = new Button();
            Pic_Imagem = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Pic_Imagem).BeginInit();
            SuspendLayout();
            // 
            // Lbl_Questao
            // 
            Lbl_Questao.AutoSize = true;
            Lbl_Questao.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Questao.Location = new Point(18, 9);
            Lbl_Questao.Name = "Lbl_Questao";
            Lbl_Questao.Size = new Size(244, 20);
            Lbl_Questao.TabIndex = 0;
            Lbl_Questao.Text = "Voce deseja validar a senha?";
            // 
            // Btn_OK
            // 
            Btn_OK.Location = new Point(147, 60);
            Btn_OK.Name = "Btn_OK";
            Btn_OK.Size = new Size(115, 23);
            Btn_OK.TabIndex = 1;
            Btn_OK.Text = "Sim. Continue";
            Btn_OK.UseVisualStyleBackColor = true;
            Btn_OK.Click += Btn_OK_Click;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Location = new Point(147, 89);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(115, 23);
            Btn_Cancel.TabIndex = 2;
            Btn_Cancel.Text = "Nao. Pare";
            Btn_Cancel.UseVisualStyleBackColor = true;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // Pic_Imagem
            // 
            Pic_Imagem.Image = Properties.Resources.question1;
            Pic_Imagem.Location = new Point(18, 44);
            Pic_Imagem.Name = "Pic_Imagem";
            Pic_Imagem.Size = new Size(105, 95);
            Pic_Imagem.SizeMode = PictureBoxSizeMode.CenterImage;
            Pic_Imagem.TabIndex = 3;
            Pic_Imagem.TabStop = false;
            // 
            // Frm_Questao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 151);
            Controls.Add(Pic_Imagem);
            Controls.Add(Btn_Cancel);
            Controls.Add(Btn_OK);
            Controls.Add(Lbl_Questao);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Questao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Questao";
            ((System.ComponentModel.ISupportInitialize)Pic_Imagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Questao;
        private Button Btn_OK;
        private Button Btn_Cancel;
        private PictureBox Pic_Imagem;
    }
}