namespace CursoWindowsForms
{
    partial class Frm_Principal_Menu_UC
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal_Menu_UC));
            Mnu_Principal = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            conectarToolStripMenuItem = new ToolStripMenuItem();
            desconectarToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            demonstraçãoKeyToolStripMenuItem = new ToolStripMenuItem();
            helloWorldToolStripMenuItem = new ToolStripMenuItem();
            mascaraToolStripMenuItem = new ToolStripMenuItem();
            validaCPFToolStripMenuItem = new ToolStripMenuItem();
            validaCPF2ToolStripMenuItem = new ToolStripMenuItem();
            validaSenhaToolStripMenuItem = new ToolStripMenuItem();
            apagarAbaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            acoesToolStripMenuItem = new ToolStripMenuItem();
            abrirImagemToolStripMenuItem = new ToolStripMenuItem();
            windowsToolStripMenuItem = new ToolStripMenuItem();
            Tbc_Aplicacoes = new TabControl();
            Iml_Imagens = new ImageList(components);
            Mnu_Principal.SuspendLayout();
            SuspendLayout();
            // 
            // Mnu_Principal
            // 
            Mnu_Principal.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, acoesToolStripMenuItem, windowsToolStripMenuItem });
            Mnu_Principal.Location = new Point(0, 0);
            Mnu_Principal.Name = "Mnu_Principal";
            Mnu_Principal.Size = new Size(800, 24);
            Mnu_Principal.TabIndex = 0;
            Mnu_Principal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { conectarToolStripMenuItem, desconectarToolStripMenuItem, novoToolStripMenuItem, apagarAbaToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // conectarToolStripMenuItem
            // 
            conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            conectarToolStripMenuItem.Size = new Size(180, 22);
            conectarToolStripMenuItem.Text = "Conectar";
            conectarToolStripMenuItem.Click += conectarToolStripMenuItem_Click;
            // 
            // desconectarToolStripMenuItem
            // 
            desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            desconectarToolStripMenuItem.Size = new Size(180, 22);
            desconectarToolStripMenuItem.Text = "Desconectar";
            desconectarToolStripMenuItem.Click += desconectarToolStripMenuItem_Click;
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
            demonstraçãoKeyToolStripMenuItem.Image = Properties.Resources.Frm_DemonstracaoKey;
            demonstraçãoKeyToolStripMenuItem.Name = "demonstraçãoKeyToolStripMenuItem";
            demonstraçãoKeyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            demonstraçãoKeyToolStripMenuItem.Size = new Size(215, 22);
            demonstraçãoKeyToolStripMenuItem.Text = "&Demonstração Key";
            demonstraçãoKeyToolStripMenuItem.Click += demonstraçãoKeyToolStripMenuItem_Click;
            // 
            // helloWorldToolStripMenuItem
            // 
            helloWorldToolStripMenuItem.Image = Properties.Resources.Frm_HelloWorld;
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
            // apagarAbaToolStripMenuItem
            // 
            apagarAbaToolStripMenuItem.Name = "apagarAbaToolStripMenuItem";
            apagarAbaToolStripMenuItem.Size = new Size(180, 22);
            apagarAbaToolStripMenuItem.Text = "Apagar Aba";
            apagarAbaToolStripMenuItem.Click += apagarAbaToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // acoesToolStripMenuItem
            // 
            acoesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirImagemToolStripMenuItem });
            acoesToolStripMenuItem.Name = "acoesToolStripMenuItem";
            acoesToolStripMenuItem.Size = new Size(51, 20);
            acoesToolStripMenuItem.Text = "Acoes";
            // 
            // abrirImagemToolStripMenuItem
            // 
            abrirImagemToolStripMenuItem.Image = Properties.Resources.folder;
            abrirImagemToolStripMenuItem.Name = "abrirImagemToolStripMenuItem";
            abrirImagemToolStripMenuItem.Size = new Size(147, 22);
            abrirImagemToolStripMenuItem.Text = "Abrir Imagem";
            abrirImagemToolStripMenuItem.Click += abrirImagemToolStripMenuItem_Click;
            // 
            // windowsToolStripMenuItem
            // 
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new Size(68, 20);
            windowsToolStripMenuItem.Text = "Windows";
            // 
            // Tbc_Aplicacoes
            // 
            Tbc_Aplicacoes.Dock = DockStyle.Fill;
            Tbc_Aplicacoes.ImageList = Iml_Imagens;
            Tbc_Aplicacoes.Location = new Point(0, 24);
            Tbc_Aplicacoes.Name = "Tbc_Aplicacoes";
            Tbc_Aplicacoes.SelectedIndex = 0;
            Tbc_Aplicacoes.Size = new Size(800, 426);
            Tbc_Aplicacoes.TabIndex = 1;
            // 
            // Iml_Imagens
            // 
            Iml_Imagens.ColorDepth = ColorDepth.Depth8Bit;
            Iml_Imagens.ImageStream = (ImageListStreamer)resources.GetObject("Iml_Imagens.ImageStream");
            Iml_Imagens.TransparentColor = Color.Transparent;
            Iml_Imagens.Images.SetKeyName(0, "Frm_DemonstracaoKey.png");
            Iml_Imagens.Images.SetKeyName(1, "Frm_HelloWorld.png");
            Iml_Imagens.Images.SetKeyName(2, "Frm_Mascara.png");
            Iml_Imagens.Images.SetKeyName(3, "Frm_ValidaCPF.png");
            Iml_Imagens.Images.SetKeyName(4, "Frm_ValidaCPF2.png");
            Iml_Imagens.Images.SetKeyName(5, "Frm_ValidaSenha.png");
            Iml_Imagens.Images.SetKeyName(6, "folder.png");
            Iml_Imagens.Images.SetKeyName(7, "key.png");
            Iml_Imagens.Images.SetKeyName(8, "Frm_Principal.ico");
            // 
            // Frm_Principal_Menu_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Tbc_Aplicacoes);
            Controls.Add(Mnu_Principal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = Mnu_Principal;
            Name = "Frm_Principal_Menu_UC";
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
        private TabControl Tbc_Aplicacoes;
        private ImageList Iml_Imagens;
        private ToolStripMenuItem apagarAbaToolStripMenuItem;
        private ToolStripMenuItem acoesToolStripMenuItem;
        private ToolStripMenuItem abrirImagemToolStripMenuItem;
        private ToolStripMenuItem conectarToolStripMenuItem;
        private ToolStripMenuItem desconectarToolStripMenuItem;
    }
}