﻿namespace CursoWindowsForms.FormulariosCurso2
{
    partial class Frm_ValidaCpf2_UC
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
            Btn_Valida = new Button();
            Btn_Reset = new Button();
            Msk_CPF = new MaskedTextBox();
            SuspendLayout();
            // 
            // Btn_Valida
            // 
            Btn_Valida.Location = new Point(253, 99);
            Btn_Valida.Name = "Btn_Valida";
            Btn_Valida.Size = new Size(111, 23);
            Btn_Valida.TabIndex = 6;
            Btn_Valida.Text = "Valida";
            Btn_Valida.UseVisualStyleBackColor = true;
            Btn_Valida.Click += Btn_Valida_Click;
            // 
            // Btn_Reset
            // 
            Btn_Reset.Location = new Point(253, 70);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(111, 23);
            Btn_Reset.TabIndex = 5;
            Btn_Reset.Text = "Limpa";
            Btn_Reset.UseVisualStyleBackColor = true;
            Btn_Reset.Click += Btn_Reset_Click;
            // 
            // Msk_CPF
            // 
            Msk_CPF.Location = new Point(20, 73);
            Msk_CPF.Mask = "000,000,000-00";
            Msk_CPF.Name = "Msk_CPF";
            Msk_CPF.Size = new Size(218, 23);
            Msk_CPF.TabIndex = 4;
            // 
            // Frm_ValidaCpf2_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Btn_Valida);
            Controls.Add(Btn_Reset);
            Controls.Add(Msk_CPF);
            Name = "Frm_ValidaCpf2_UC";
            Size = new Size(384, 193);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Valida;
        private Button Btn_Reset;
        private MaskedTextBox Msk_CPF;
    }
}
