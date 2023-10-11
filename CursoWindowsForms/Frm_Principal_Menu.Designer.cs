namespace CursoWindowsForms
{
    partial class Frm_Principal_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal_Menu));
            Mnu_Principal = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            demonstraçãoKeyToolStripMenuItem = new ToolStripMenuItem();
            helloWorldToolStripMenuItem = new ToolStripMenuItem();
            mascaraToolStripMenuItem = new ToolStripMenuItem();
            validaCPFToolStripMenuItem = new ToolStripMenuItem();
            validaCPF2ToolStripMenuItem = new ToolStripMenuItem();
            validaSenhaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            windowsToolStripMenuItem = new ToolStripMenuItem();
            Mnu_Principal.SuspendLayout();
            SuspendLayout();
            // 
            // Mnu_Principal
            // 
            Mnu_Principal.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, windowsToolStripMenuItem });
            Mnu_Principal.Location = new Point(0, 0);
            Mnu_Principal.Name = "Mnu_Principal";
            Mnu_Principal.Size = new Size(800, 24);
            Mnu_Principal.TabIndex = 0;
            Mnu_Principal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { demonstraçãoKeyToolStripMenuItem, helloWorldToolStripMenuItem, mascaraToolStripMenuItem, validaCPFToolStripMenuItem, validaCPF2ToolStripMenuItem, validaSenhaToolStripMenuItem });
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(180, 22);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // demonstraçãoKeyToolStripMenuItem
            // 
            demonstraçãoKeyToolStripMenuItem.Image = (Image)resources.GetObject("demonstraçãoKeyToolStripMenuItem.Image");
            demonstraçãoKeyToolStripMenuItem.Name = "demonstraçãoKeyToolStripMenuItem";
            demonstraçãoKeyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            demonstraçãoKeyToolStripMenuItem.Size = new Size(215, 22);
            demonstraçãoKeyToolStripMenuItem.Text = "&Demonstração Key";
            demonstraçãoKeyToolStripMenuItem.Click += demonstraçãoKeyToolStripMenuItem_Click;
            // 
            // helloWorldToolStripMenuItem
            // 
            helloWorldToolStripMenuItem.Image = (Image)resources.GetObject("helloWorldToolStripMenuItem.Image");
            helloWorldToolStripMenuItem.Name = "helloWorldToolStripMenuItem";
            helloWorldToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            helloWorldToolStripMenuItem.Size = new Size(215, 22);
            helloWorldToolStripMenuItem.Text = "&Hello World";
            helloWorldToolStripMenuItem.Click += helloWorldToolStripMenuItem_Click;
            // 
            // mascaraToolStripMenuItem
            // 
            mascaraToolStripMenuItem.Image = Properties.Resources.Frm_Mascara;
            mascaraToolStripMenuItem.Name = "mascaraToolStripMenuItem";
            mascaraToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.M;
            mascaraToolStripMenuItem.Size = new Size(215, 22);
            mascaraToolStripMenuItem.Text = "&Mascara";
            mascaraToolStripMenuItem.Click += mascaraToolStripMenuItem_Click;
            // 
            // validaCPFToolStripMenuItem
            // 
            validaCPFToolStripMenuItem.Image = Properties.Resources.Frm_ValidaCPF;
            validaCPFToolStripMenuItem.Name = "validaCPFToolStripMenuItem";
            validaCPFToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            validaCPFToolStripMenuItem.Size = new Size(215, 22);
            validaCPFToolStripMenuItem.Text = "&Valida CPF";
            validaCPFToolStripMenuItem.Click += validaCPFToolStripMenuItem_Click;
            // 
            // validaCPF2ToolStripMenuItem
            // 
            validaCPF2ToolStripMenuItem.Image = Properties.Resources.Frm_ValidaCPF2;
            validaCPF2ToolStripMenuItem.Name = "validaCPF2ToolStripMenuItem";
            validaCPF2ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.V;
            validaCPF2ToolStripMenuItem.Size = new Size(215, 22);
            validaCPF2ToolStripMenuItem.Text = "&Valida CPF 2";
            validaCPF2ToolStripMenuItem.Click += validaCPF2ToolStripMenuItem_Click;
            // 
            // validaSenhaToolStripMenuItem
            // 
            validaSenhaToolStripMenuItem.Image = Properties.Resources.Frm_ValidaSenha;
            validaSenhaToolStripMenuItem.Name = "validaSenhaToolStripMenuItem";
            validaSenhaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            validaSenhaToolStripMenuItem.Size = new Size(215, 22);
            validaSenhaToolStripMenuItem.Text = "Valida &Senha";
            validaSenhaToolStripMenuItem.Click += validaSenhaToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // windowsToolStripMenuItem
            // 
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new Size(68, 20);
            windowsToolStripMenuItem.Text = "Windows";
            // 
            // Frm_Principal_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Mnu_Principal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = Mnu_Principal;
            Name = "Frm_Principal_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Mnu_Principal.ResumeLayout(false);
            Mnu_Principal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Mnu_Principal;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem demonstraçãoKeyToolStripMenuItem;
        private ToolStripMenuItem helloWorldToolStripMenuItem;
        private ToolStripMenuItem mascaraToolStripMenuItem;
        private ToolStripMenuItem validaCPFToolStripMenuItem;
        private ToolStripMenuItem validaCPF2ToolStripMenuItem;
        private ToolStripMenuItem validaSenhaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem windowsToolStripMenuItem;
    }
}