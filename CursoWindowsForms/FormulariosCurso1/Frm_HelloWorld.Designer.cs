namespace CursoWindowsForms
{
    partial class Frm_HelloWorld
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HelloWorld));
            lbl_Titulo = new Label();
            Btn_Sair = new Button();
            lbl_Version = new Label();
            lbl_RevelaTexto = new Label();
            btn_ModificaTexto = new Button();
            txt_ConteudoLabel = new TextBox();
            SuspendLayout();
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Ink Free", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_Titulo.ForeColor = SystemColors.MenuHighlight;
            lbl_Titulo.Location = new Point(12, 9);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(140, 26);
            lbl_Titulo.TabIndex = 0;
            lbl_Titulo.Text = "Sistema PDV";
            lbl_Titulo.Click += lbl_Titulo_Click;
            // 
            // Btn_Sair
            // 
            Btn_Sair.Location = new Point(434, 323);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(159, 23);
            Btn_Sair.TabIndex = 1;
            Btn_Sair.Text = "Fechar Aplicação";
            Btn_Sair.UseVisualStyleBackColor = true;
            Btn_Sair.Click += Btn_Sair_Click;
            // 
            // lbl_Version
            // 
            lbl_Version.AutoSize = true;
            lbl_Version.Location = new Point(553, 9);
            lbl_Version.Name = "lbl_Version";
            lbl_Version.Size = new Size(40, 15);
            lbl_Version.TabIndex = 2;
            lbl_Version.Text = "v 1.0.0";
            // 
            // lbl_RevelaTexto
            // 
            lbl_RevelaTexto.AutoSize = true;
            lbl_RevelaTexto.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_RevelaTexto.Location = new Point(128, 78);
            lbl_RevelaTexto.Name = "lbl_RevelaTexto";
            lbl_RevelaTexto.Size = new Size(368, 45);
            lbl_RevelaTexto.TabIndex = 3;
            lbl_RevelaTexto.Text = "daposkdpaskdpoakspdq";
            lbl_RevelaTexto.TextAlign = ContentAlignment.MiddleCenter;
            lbl_RevelaTexto.Click += lbl_RevelaTexto_Click;
            // 
            // btn_ModificaTexto
            // 
            btn_ModificaTexto.Location = new Point(237, 202);
            btn_ModificaTexto.Name = "btn_ModificaTexto";
            btn_ModificaTexto.Size = new Size(144, 23);
            btn_ModificaTexto.TabIndex = 4;
            btn_ModificaTexto.Text = "Modifique o Texto";
            btn_ModificaTexto.UseVisualStyleBackColor = true;
            btn_ModificaTexto.Click += btn_ModificaTexto_Click;
            // 
            // txt_ConteudoLabel
            // 
            txt_ConteudoLabel.Location = new Point(128, 146);
            txt_ConteudoLabel.Name = "txt_ConteudoLabel";
            txt_ConteudoLabel.Size = new Size(368, 23);
            txt_ConteudoLabel.TabIndex = 5;
            txt_ConteudoLabel.TextChanged += txt_ConteudoLabel_TextChanged;
            // 
            // Frm_HelloWorld
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 358);
            Controls.Add(lbl_RevelaTexto);
            Controls.Add(txt_ConteudoLabel);
            Controls.Add(btn_ModificaTexto);
            Controls.Add(lbl_Version);
            Controls.Add(Btn_Sair);
            Controls.Add(lbl_Titulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_HelloWorld";
            Text = "Hello World";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Titulo;
        private Button Btn_Sair;
        private Label lbl_Version;
        private Label lbl_RevelaTexto;
        private Button btn_ModificaTexto;
        private TextBox txt_ConteudoLabel;
    }
}