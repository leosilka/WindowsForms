namespace CursoWindowsForms
{
    partial class Frm_Login
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
            Pic_Login = new PictureBox();
            Lbl_Login = new Label();
            Lbl_Password = new Label();
            Txt_Login = new TextBox();
            Txt_Password = new TextBox();
            Btn_OK = new Button();
            Btn_Cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)Pic_Login).BeginInit();
            SuspendLayout();
            // 
            // Pic_Login
            // 
            Pic_Login.Image = Properties.Resources.key;
            Pic_Login.Location = new Point(12, 8);
            Pic_Login.Name = "Pic_Login";
            Pic_Login.Size = new Size(100, 93);
            Pic_Login.SizeMode = PictureBoxSizeMode.StretchImage;
            Pic_Login.TabIndex = 0;
            Pic_Login.TabStop = false;
            // 
            // Lbl_Login
            // 
            Lbl_Login.AutoSize = true;
            Lbl_Login.Location = new Point(119, 17);
            Lbl_Login.Name = "Lbl_Login";
            Lbl_Login.Size = new Size(38, 15);
            Lbl_Login.TabIndex = 1;
            Lbl_Login.Text = "label1";
            // 
            // Lbl_Password
            // 
            Lbl_Password.AutoSize = true;
            Lbl_Password.Location = new Point(119, 65);
            Lbl_Password.Name = "Lbl_Password";
            Lbl_Password.Size = new Size(38, 15);
            Lbl_Password.TabIndex = 2;
            Lbl_Password.Text = "label1";
            // 
            // Txt_Login
            // 
            Txt_Login.Location = new Point(122, 33);
            Txt_Login.Name = "Txt_Login";
            Txt_Login.Size = new Size(151, 23);
            Txt_Login.TabIndex = 3;
            // 
            // Txt_Password
            // 
            Txt_Password.Location = new Point(122, 81);
            Txt_Password.Name = "Txt_Password";
            Txt_Password.PasswordChar = '*';
            Txt_Password.Size = new Size(151, 23);
            Txt_Password.TabIndex = 4;
            // 
            // Btn_OK
            // 
            Btn_OK.Location = new Point(12, 132);
            Btn_OK.Name = "Btn_OK";
            Btn_OK.Size = new Size(75, 23);
            Btn_OK.TabIndex = 5;
            Btn_OK.Text = "button1";
            Btn_OK.UseVisualStyleBackColor = true;
            Btn_OK.Click += Btn_OK_Click;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Location = new Point(194, 132);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(75, 23);
            Btn_Cancel.TabIndex = 6;
            Btn_Cancel.Text = "button1";
            Btn_Cancel.UseVisualStyleBackColor = true;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 162);
            Controls.Add(Btn_Cancel);
            Controls.Add(Btn_OK);
            Controls.Add(Txt_Password);
            Controls.Add(Txt_Login);
            Controls.Add(Lbl_Password);
            Controls.Add(Lbl_Login);
            Controls.Add(Pic_Login);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Login";
            ((System.ComponentModel.ISupportInitialize)Pic_Login).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Pic_Login;
        private Label Lbl_Login;
        private Label Lbl_Password;
        private TextBox Txt_Login;
        private TextBox Txt_Password;
        private Button Btn_OK;
        private Button Btn_Cancel;
    }
}