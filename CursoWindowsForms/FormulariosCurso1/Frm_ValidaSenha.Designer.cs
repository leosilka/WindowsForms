﻿namespace CursoWindowsForms
{
    partial class Frm_ValidaSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ValidaSenha));
            Txt_Senha = new TextBox();
            Lbl_Resultado = new Label();
            Btn_Reset = new Button();
            Btn_VerSenha = new Button();
            SuspendLayout();
            // 
            // Txt_Senha
            // 
            Txt_Senha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_Senha.Location = new Point(12, 45);
            Txt_Senha.Name = "Txt_Senha";
            Txt_Senha.PasswordChar = '*';
            Txt_Senha.Size = new Size(218, 23);
            Txt_Senha.TabIndex = 0;
            Txt_Senha.KeyDown += Txt_Senha_KeyDown;
            // 
            // Lbl_Resultado
            // 
            Lbl_Resultado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Lbl_Resultado.AutoSize = true;
            Lbl_Resultado.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Resultado.Location = new Point(12, 90);
            Lbl_Resultado.Name = "Lbl_Resultado";
            Lbl_Resultado.Size = new Size(0, 23);
            Lbl_Resultado.TabIndex = 1;
            // 
            // Btn_Reset
            // 
            Btn_Reset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Reset.Location = new Point(245, 42);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(111, 23);
            Btn_Reset.TabIndex = 2;
            Btn_Reset.Text = "Limpa";
            Btn_Reset.UseVisualStyleBackColor = true;
            Btn_Reset.Click += Btn_Reset_Click;
            // 
            // Btn_VerSenha
            // 
            Btn_VerSenha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_VerSenha.Location = new Point(245, 71);
            Btn_VerSenha.Name = "Btn_VerSenha";
            Btn_VerSenha.Size = new Size(111, 23);
            Btn_VerSenha.TabIndex = 3;
            Btn_VerSenha.Text = "Ver Senha";
            Btn_VerSenha.UseVisualStyleBackColor = true;
            Btn_VerSenha.Click += Btn_VerSenha_Click;
            // 
            // Frm_ValidaSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 154);
            Controls.Add(Btn_VerSenha);
            Controls.Add(Btn_Reset);
            Controls.Add(Lbl_Resultado);
            Controls.Add(Txt_Senha);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_ValidaSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validação de Senha";
            Load += Frm_ValidaSenha_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_Senha;
        private Label Lbl_Resultado;
        private Button Btn_Reset;
        private Button Btn_VerSenha;
    }
}