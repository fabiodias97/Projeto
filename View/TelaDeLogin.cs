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
    public partial class frmTelaDeLogin : Form
    {
        public frmTelaDeLogin()
        {
            InitializeComponent();
        }

        private void btnRedefinirSenha_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInicial tela = new frmInicial();
            tela.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmTelaDeMenuAnunciante tela = new frmTelaDeMenuAnunciante();
            tela.Show();
        }
    }
}
