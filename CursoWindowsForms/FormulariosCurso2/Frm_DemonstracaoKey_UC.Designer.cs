namespace CursoWindowsForms.FormulariosCurso2
{
    partial class Frm_DemonstracaoKey_UC
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
            lbl_Lower = new Label();
            lbl_Upper = new Label();
            lbl_Maius = new Label();
            lbl_Minus = new Label();
            btn_Reset = new Button();
            txt_Msg = new TextBox();
            txt_Input = new TextBox();
            SuspendLayout();
            // 
            // lbl_Lower
            // 
            lbl_Lower.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Lower.BorderStyle = BorderStyle.Fixed3D;
            lbl_Lower.Location = new Point(370, 108);
            lbl_Lower.Name = "lbl_Lower";
            lbl_Lower.Size = new Size(32, 23);
            lbl_Lower.TabIndex = 13;
            // 
            // lbl_Upper
            // 
            lbl_Upper.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Upper.BorderStyle = BorderStyle.Fixed3D;
            lbl_Upper.Location = new Point(370, 60);
            lbl_Upper.Name = "lbl_Upper";
            lbl_Upper.Size = new Size(32, 23);
            lbl_Upper.TabIndex = 12;
            // 
            // lbl_Maius
            // 
            lbl_Maius.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Maius.AutoSize = true;
            lbl_Maius.Location = new Point(322, 60);
            lbl_Maius.Name = "lbl_Maius";
            lbl_Maius.Size = new Size(39, 15);
            lbl_Maius.TabIndex = 11;
            lbl_Maius.Text = "Maius";
            // 
            // lbl_Minus
            // 
            lbl_Minus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Minus.AutoSize = true;
            lbl_Minus.Location = new Point(322, 108);
            lbl_Minus.Name = "lbl_Minus";
            lbl_Minus.Size = new Size(40, 15);
            lbl_Minus.TabIndex = 10;
            lbl_Minus.Text = "Minus";
            // 
            // btn_Reset
            // 
            btn_Reset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Reset.Location = new Point(330, 12);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(75, 28);
            btn_Reset.TabIndex = 9;
            btn_Reset.Text = "Limpa";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // txt_Msg
            // 
            txt_Msg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Msg.Location = new Point(10, 44);
            txt_Msg.Multiline = true;
            txt_Msg.Name = "txt_Msg";
            txt_Msg.ScrollBars = ScrollBars.Vertical;
            txt_Msg.Size = new Size(304, 232);
            txt_Msg.TabIndex = 8;
            txt_Msg.TabStop = false;
            // 
            // txt_Input
            // 
            txt_Input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_Input.Location = new Point(10, 12);
            txt_Input.Name = "txt_Input";
            txt_Input.ShortcutsEnabled = false;
            txt_Input.Size = new Size(100, 23);
            txt_Input.TabIndex = 7;
            txt_Input.KeyDown += txt_Input_KeyDown;
            // 
            // Frm_DemonstracaoKey_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_Lower);
            Controls.Add(lbl_Upper);
            Controls.Add(lbl_Maius);
            Controls.Add(lbl_Minus);
            Controls.Add(btn_Reset);
            Controls.Add(txt_Msg);
            Controls.Add(txt_Input);
            Name = "Frm_DemonstracaoKey_UC";
            Size = new Size(415, 288);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Lower;
        private Label lbl_Upper;
        private Label lbl_Maius;
        private Label lbl_Minus;
        private Button btn_Reset;
        private TextBox txt_Msg;
        private TextBox txt_Input;
    }
}
