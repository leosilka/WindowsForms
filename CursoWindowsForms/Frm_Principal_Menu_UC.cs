using CursoWindowsForms.FormulariosCurso2;
using CursoWindowsFormsBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms;

public partial class Frm_Principal_Menu_UC : Form
{
    int ControleHelloWorld = 0;
    int ControleDemonstracaoKey = 0;
    int ControleMascara = 0;
    int ControleValidaCpf = 0;
    int ControleValidaCpf2 = 0;
    int ControleValidaSenha = 0;
    int ControleArquivoImagem = 0;
    public Frm_Principal_Menu_UC()
    {
        InitializeComponent();

        novoToolStripMenuItem.Enabled = false;
        apagarAbaToolStripMenuItem.Enabled = false;
        acoesToolStripMenuItem.Enabled = false;
        desconectarToolStripMenuItem.Enabled = false;
    }

    private void novoToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ControleDemonstracaoKey++;
        FormulariosCurso2.Frm_DemonstracaoKey_UC U = new FormulariosCurso2.Frm_DemonstracaoKey_UC();
        U.Dock = DockStyle.Fill;
        TabPage TB = new TabPage();
        TB.Name = $"Demonstracao KEY {ControleDemonstracaoKey}";
        TB.Text = $"Demonstracao KEY {ControleDemonstracaoKey}";
        TB.ImageIndex = 0;
        TB.Controls.Add(U);
        Tbc_Aplicacoes.TabPages.Add(TB);
    }

    private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ControleHelloWorld++;
        Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();
        U.Dock = DockStyle.Fill;
        TabPage TB = new TabPage();
        TB.Name = $"Hello World {ControleHelloWorld}";
        TB.Text = $"Hello World {ControleHelloWorld}";
        TB.ImageIndex = 1;
        TB.Controls.Add(U);
        Tbc_Aplicacoes.TabPages.Add(TB);
    }

    private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ControleMascara++;
        Frm_Mascara_UC U = new Frm_Mascara_UC();
        U.Dock = DockStyle.Fill;
        TabPage TB = new TabPage();
        TB.Name = $"Mascara {ControleMascara}";
        TB.Text = $"Mascara {ControleMascara}";
        TB.ImageIndex = 2;
        TB.Controls.Add(U);
        Tbc_Aplicacoes.TabPages.Add(TB);
    }

    private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ControleValidaCpf++;
        Frm_ValidaCpf_UC U = new Frm_ValidaCpf_UC();
        U.Dock = DockStyle.Fill;
        TabPage TB = new TabPage();
        TB.Name = $"Valida CPF - {ControleValidaCpf}";
        TB.Text = $"Valida CPF - {ControleValidaCpf}";
        TB.ImageIndex = 3;
        TB.Controls.Add(U);
        Tbc_Aplicacoes.TabPages.Add(TB);
    }

    private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ControleValidaCpf2++;
        Frm_ValidaCpf2_UC U = new Frm_ValidaCpf2_UC();
        U.Dock = DockStyle.Fill;
        TabPage TB = new TabPage();
        TB.Name = $"Valida CPF 2 - {ControleValidaCpf2}";
        TB.Text = $"Valida CPF 2 - {ControleValidaCpf2}";
        TB.ImageIndex = 4;
        TB.Controls.Add(U);
        Tbc_Aplicacoes.TabPages.Add(TB);
    }

    private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ControleValidaSenha++;
        Frm_ValidaSenha_UC U = new Frm_ValidaSenha_UC();
        U.Dock = DockStyle.Fill;
        TabPage TB = new TabPage();
        TB.Name = $"Valida Senha {ControleValidaSenha}";
        TB.Text = $"Valida Senha - {ControleValidaSenha}";
        TB.ImageIndex = 5;
        TB.Controls.Add(U);
        Tbc_Aplicacoes.TabPages.Add(TB);
    }

    private void sairToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!(Tbc_Aplicacoes.SelectedTab == null))
        {
            Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
        }
    }

    private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OpenFileDialog Db = new OpenFileDialog();
        Db.InitialDirectory = "C:\\Users\\leona\\Documents\\Alura\\Back-end\\C#\\WindowsForms\\CursoWindowsForms\\CursoWindowsForms\\Imagens";
        Db.Filter = "PNG | *.PNG";
        Db.Title = "Escolha a Imagem";

        if (Db.ShowDialog() == DialogResult.OK)
        {
            string nomeArquivoImagem = Db.FileName;

            ControleArquivoImagem++;
            Frm_ArquivoImagem_UC U = new Frm_ArquivoImagem_UC(nomeArquivoImagem);
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = $"Arquivo Imagem {ControleArquivoImagem}";
            TB.Text = $"Arquivo Imagem {ControleArquivoImagem}";
            TB.ImageIndex = 6;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }
    }

    private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Frm_Login F = new Frm_Login();
        F.ShowDialog();

        if (F.DialogResult == DialogResult.OK)
        {
            string senha = F.senha;
            string login = F.login;

            if (CursoWindowsFormsBiblioteca.Cls_Uteis.validaSenhaLogin(senha) == true)
            {
                novoToolStripMenuItem.Enabled = true;
                apagarAbaToolStripMenuItem.Enabled = true;
                acoesToolStripMenuItem.Enabled = true;
                conectarToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = true;

                MessageBox.Show($"Bem vindo {login}!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Senha Invalida!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Frm_Questao Db = new Frm_Questao("question1", "Você deseja se desconectar?");
        Db.ShowDialog();
        //if (MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        if (Db.DialogResult == DialogResult.Yes)
        {
            //Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i += -1)
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
            }

            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            acoesToolStripMenuItem.Enabled = false;
            conectarToolStripMenuItem.Enabled = true;
            desconectarToolStripMenuItem.Enabled = false;
        }


    }
}
