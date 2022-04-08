using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contas
{
    public partial class Contas : Form
    {
        ContaNormal normar = new ContaNormal();
        ContaComCartao cartao = new ContaComCartao();
        public Contas()
        {
            InitializeComponent();
        }

        private void Contas_Load(object sender, EventArgs e)
        {
            
            normar.VerCadastros(dataContas);
            ContasNormais.Hide();
              
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        

            cartao.VerCadastros(dataContas);
            ContaComCartão.Hide();
            ContasNormais.Show();
            lbNc.Text = ContaComCartão.Text;
        }

        private void lbNc_Click(object sender, EventArgs e)
        {
        }

        private void ContasNormais_Click(object sender, EventArgs e)
        {
            normar.VerCadastros(dataContas);
            ContaComCartão.Show();
            ContasNormais.Hide();
            lbNc.Text = ContasNormais.Text;
        }
    }
}
