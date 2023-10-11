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

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCpf : Form
    {
        public Frm_ValidaCpf()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = "";
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            bool validaCpf = false;
            validaCpf = Cls_Uteis.Valida(Msk_CPF.Text);
            if (validaCpf == true)
            {
                Lbl_Resultado.Text = "CPF VÁLIDO";
                Lbl_Resultado.ForeColor = Color.Gold;
            }
            else
            {
                Lbl_Resultado.Text = "CPF INVÁLIDO";
                Lbl_Resultado.ForeColor = Color.Red;
            }
        }
    }
}
