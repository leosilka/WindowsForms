namespace CursoWindowsForms.FormulariosCurso2
{
    partial class Frm_ValidaSenha_UC
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
            Btn_VerSenha = new Button();
            Btn_Reset = new Button();
            Lbl_Resultado = new Label();
            Txt_Senha = new TextBox();
            SuspendLayout();
            // 
            // Btn_VerSenha
            // 
            Btn_VerSenha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_VerSenha.Location = new Point(253, 90);
            Btn_VerSenha.Name = "Btn_VerSenha";
            Btn_VerSenha.Size = new Size(111, 23);
            Btn_VerSenha.TabIndex = 7;
            Btn_VerSenha.Text = "Ver Senha";
            Btn_VerSenha.UseVisualStyleBackColor = true;
            Btn_VerSenha.Click += Btn_VerSenha_Click;
            // 
            // Btn_Reset
            // 
            Btn_Reset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Reset.Location = new Point(253, 61);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(111, 23);
            Btn_Reset.TabIndex = 6;
            Btn_Reset.Text = "Limpa";
            Btn_Reset.UseVisualStyleBackColor = true;
            Btn_Reset.Click += Btn_Reset_Click;
            // 
            // Lbl_Resultado
            // 
            Lbl_Resultado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Lbl_Resultado.AutoSize = true;
            Lbl_Resultado.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Resultado.Location = new Point(20, 109);
            Lbl_Resultado.Name = "Lbl_Resultado";
            Lbl_Resultado.Size = new Size(0, 23);
            Lbl_Resultado.TabIndex = 5;
            // 
            // Txt_Senha
            // 
            Txt_Senha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_Senha.Location = new Point(20, 64);
            Txt_Senha.Name = "Txt_Senha";
            Txt_Senha.PasswordChar = '*';
            Txt_Senha.Size = new Size(218, 23);
            Txt_Senha.TabIndex = 4;
            Txt_Senha.KeyDown += Txt_Senha_KeyDown;
            // 
            // Frm_ValidaSenha_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Btn_VerSenha);
            Controls.Add(Btn_Reset);
            Controls.Add(Lbl_Resultado);
            Controls.Add(Txt_Senha);
            Name = "Frm_ValidaSenha_UC";
            Size = new Size(384, 193);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_VerSenha;
        private Button Btn_Reset;
        private Label Lbl_Resultado;
        private TextBox Txt_Senha;
    }
}
