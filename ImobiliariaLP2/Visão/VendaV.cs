﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImobiliariaLP2.Visão
{
    public partial class VendaV : Form
    {
        public VendaV()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnBuscarVenda_Click(object sender, EventArgs e)
        {
            VisualizarVenda vv = new VisualizarVenda();
            vv.ShowDialog();
        }
    }
}
