﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.View
{
    public partial class frmTelaDeCadastroEventos : Form
    {
        public frmTelaDeCadastroEventos()
        {
            InitializeComponent();
        }

        private void btnTCEVoltar_Click(object sender, EventArgs e)
        {
            frmTelaDeMenuAnunciante tela = new frmTelaDeMenuAnunciante();
            tela.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
