﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainPagesProjetoJane
{
    public partial class FornecedoresPage : Form
    {
        public FornecedoresPage()
        {
            InitializeComponent();
        }


        private void btnAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            NovoFornecedor novoFornecedor = new NovoFornecedor();
            novoFornecedor.Show();
        }
    }
}
