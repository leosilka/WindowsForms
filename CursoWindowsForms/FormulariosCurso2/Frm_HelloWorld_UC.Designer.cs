namespace CursoWindowsForms
{
    partial class Frm_HelloWorld_UC
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
            lbl_RevelaTexto = new Label();
            txt_ConteudoLabel = new TextBox();
            btn_ModificaTexto = new Button();
            lbl_Titulo = new Label();
            SuspendLayout();
            // 
            // lbl_RevelaTexto
            // 
            lbl_RevelaTexto.AutoSize = true;
            lbl_RevelaTexto.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_RevelaTexto.Location = new Point(116, 69);
            lbl_RevelaTexto.Name = "lbl_RevelaTexto";
            lbl_RevelaTexto.Size = new Size(368, 45);
            lbl_RevelaTexto.TabIndex = 7;
            lbl_RevelaTexto.Text = "daposkdpaskdpoakspdq";
            lbl_RevelaTexto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_ConteudoLabel
            // 
            txt_ConteudoLabel.Location = new Point(116, 137);
            txt_ConteudoLabel.Name = "txt_ConteudoLabel";
            txt_ConteudoLabel.Size = new Size(368, 23);
            txt_ConteudoLabel.TabIndex = 9;
            // 
            // btn_ModificaTexto
            // 
            btn_ModificaTexto.Location = new Point(225, 193);
            btn_ModificaTexto.Name = "btn_ModificaTexto";
            btn_ModificaTexto.Size = new Size(144, 23);
            btn_ModificaTexto.TabIndex = 8;
            btn_ModificaTexto.Text = "Modifique o Texto";
            btn_ModificaTexto.UseVisualStyleBackColor = true;
            btn_ModificaTexto.Click += btn_ModificaTexto_Click;
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Ink Free", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_Titulo.ForeColor = SystemColors.MenuHighlight;
            lbl_Titulo.Location = new Point(0, 0);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(140, 26);
            lbl_Titulo.TabIndex = 6;
            lbl_Titulo.Text = "Sistema PDV";
            // 
            // Frm_HelloWorld_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_RevelaTexto);
            Controls.Add(txt_ConteudoLabel);
            Controls.Add(btn_ModificaTexto);
            Controls.Add(lbl_Titulo);
            Name = "Frm_HelloWorld_UC";
            Size = new Size(568, 273);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_RevelaTexto;
        private TextBox txt_ConteudoLabel;
        private Button btn_ModificaTexto;
        private Label lbl_Titulo;
    }
}
