namespace CursoWindowsForms.FormulariosCurso2
{
    partial class Frm_Mascara_UC
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
            Btn_VerConteudo = new Button();
            Btn_Telefone = new Button();
            Btn_Senha = new Button();
            Btn_Data = new Button();
            Btn_Moeda = new Button();
            Btn_CEP = new Button();
            Btn_Hora = new Button();
            Lbl_MascaraAtiva = new Label();
            Lbl_Conteudo = new Label();
            Msk_TextBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // Btn_VerConteudo
            // 
            Btn_VerConteudo.Location = new Point(35, 210);
            Btn_VerConteudo.Name = "Btn_VerConteudo";
            Btn_VerConteudo.Size = new Size(258, 37);
            Btn_VerConteudo.TabIndex = 19;
            Btn_VerConteudo.Text = "Ver Conteúdo";
            Btn_VerConteudo.UseVisualStyleBackColor = true;
            Btn_VerConteudo.Click += Btn_VerConteudo_Click;
            // 
            // Btn_Telefone
            // 
            Btn_Telefone.Location = new Point(211, 166);
            Btn_Telefone.Name = "Btn_Telefone";
            Btn_Telefone.Size = new Size(82, 37);
            Btn_Telefone.TabIndex = 18;
            Btn_Telefone.Text = "Telefone";
            Btn_Telefone.UseVisualStyleBackColor = true;
            Btn_Telefone.Click += Btn_Telefone_Click;
            // 
            // Btn_Senha
            // 
            Btn_Senha.Location = new Point(123, 166);
            Btn_Senha.Name = "Btn_Senha";
            Btn_Senha.Size = new Size(82, 37);
            Btn_Senha.TabIndex = 17;
            Btn_Senha.Text = "Senha";
            Btn_Senha.UseVisualStyleBackColor = true;
            Btn_Senha.Click += Btn_Senha_Click;
            // 
            // Btn_Data
            // 
            Btn_Data.Location = new Point(35, 166);
            Btn_Data.Name = "Btn_Data";
            Btn_Data.Size = new Size(82, 37);
            Btn_Data.TabIndex = 16;
            Btn_Data.Text = "Data";
            Btn_Data.UseVisualStyleBackColor = true;
            Btn_Data.Click += Btn_Data_Click;
            // 
            // Btn_Moeda
            // 
            Btn_Moeda.Location = new Point(211, 123);
            Btn_Moeda.Name = "Btn_Moeda";
            Btn_Moeda.Size = new Size(82, 37);
            Btn_Moeda.TabIndex = 15;
            Btn_Moeda.Text = "Moeda";
            Btn_Moeda.UseVisualStyleBackColor = true;
            Btn_Moeda.Click += Btn_Moeda_Click;
            // 
            // Btn_CEP
            // 
            Btn_CEP.Location = new Point(123, 123);
            Btn_CEP.Name = "Btn_CEP";
            Btn_CEP.Size = new Size(82, 37);
            Btn_CEP.TabIndex = 14;
            Btn_CEP.Text = "CEP";
            Btn_CEP.UseVisualStyleBackColor = true;
            Btn_CEP.Click += Btn_CEP_Click;
            // 
            // Btn_Hora
            // 
            Btn_Hora.Location = new Point(35, 123);
            Btn_Hora.Name = "Btn_Hora";
            Btn_Hora.Size = new Size(82, 37);
            Btn_Hora.TabIndex = 13;
            Btn_Hora.Text = "Hora";
            Btn_Hora.UseVisualStyleBackColor = true;
            Btn_Hora.Click += Btn_Hora_Click;
            // 
            // Lbl_MascaraAtiva
            // 
            Lbl_MascaraAtiva.AutoSize = true;
            Lbl_MascaraAtiva.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_MascaraAtiva.Location = new Point(35, 88);
            Lbl_MascaraAtiva.Name = "Lbl_MascaraAtiva";
            Lbl_MascaraAtiva.Size = new Size(0, 19);
            Lbl_MascaraAtiva.TabIndex = 12;
            // 
            // Lbl_Conteudo
            // 
            Lbl_Conteudo.AutoSize = true;
            Lbl_Conteudo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Conteudo.Location = new Point(35, 259);
            Lbl_Conteudo.Name = "Lbl_Conteudo";
            Lbl_Conteudo.Size = new Size(0, 19);
            Lbl_Conteudo.TabIndex = 11;
            // 
            // Msk_TextBox
            // 
            Msk_TextBox.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Msk_TextBox.Location = new Point(35, 44);
            Msk_TextBox.Name = "Msk_TextBox";
            Msk_TextBox.Size = new Size(258, 26);
            Msk_TextBox.TabIndex = 10;
            // 
            // Frm_Mascara_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Btn_VerConteudo);
            Controls.Add(Btn_Telefone);
            Controls.Add(Btn_Senha);
            Controls.Add(Btn_Data);
            Controls.Add(Btn_Moeda);
            Controls.Add(Btn_CEP);
            Controls.Add(Btn_Hora);
            Controls.Add(Lbl_MascaraAtiva);
            Controls.Add(Lbl_Conteudo);
            Controls.Add(Msk_TextBox);
            Name = "Frm_Mascara_UC";
            Size = new Size(328, 322);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_VerConteudo;
        private Button Btn_Telefone;
        private Button Btn_Senha;
        private Button Btn_Data;
        private Button Btn_Moeda;
        private Button Btn_CEP;
        private Button Btn_Hora;
        private Label Lbl_MascaraAtiva;
        private Label Lbl_Conteudo;
        private MaskedTextBox Msk_TextBox;
    }
}
