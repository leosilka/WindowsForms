﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms.FormulariosCurso2
{
    public partial class Frm_DemonstracaoKey_UC : UserControl
    {
        public Frm_DemonstracaoKey_UC()
        {
            InitializeComponent();
        }

        private void txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            txt_Msg.AppendText($"\r\nPressionei a tecla: {e.KeyCode}\r\n");
            txt_Msg.AppendText($"\tCodigo da tecla: {(int)e.KeyCode}\r\n");
            txt_Msg.AppendText($"\tNome da tecla: {e.KeyData}");
            lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Msg.Text = "";
            txt_Input.Text = "";
            lbl_Lower.Text = "";
            lbl_Upper.Text = "";
        }
    }
}
