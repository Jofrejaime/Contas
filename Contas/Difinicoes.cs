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
    public partial class Difinicoes : Form
    {
        Conta v = new Conta();
        public Difinicoes()
        {
            InitializeComponent();
        }

        private void Difinicoes_Load(object sender, EventArgs e)
        {

        }

        private void txtNumContaApa_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Show();
                v.verificarse(txtNumContaApa, pictureBox1, btnApagar);

            }
            catch (FormatException)
            {
                btnApagar.Enabled = false;
            }
        }

        private void txtNumContaAlter_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox2.Show();
                v.verificarse(txtNumContaAlter, pictureBox2,  btnAlterarPin);
              

            }
            catch (FormatException)
            {
                btnAlterarPin.Enabled = false;
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (v.tipoConta.Equals(1))
                {
                    ContaNormal conta1 = new ContaNormal();
                    conta1.eliminarConta(txtNumContaApa);
                    MessageBox.Show("Conta Eliminada com sucesso", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ContaComCartao conta2 = new ContaComCartao();
                    conta2.eliminarConta(txtNumContaApa,txtPINContaApa);
                    MessageBox.Show("Conta Eliminada com sucesso", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Preencha devimente os campos","Campos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("PIN incorreto, introduza novamente", "Erro PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterarPin_Click(object sender, EventArgs e)
        {
            try
            {
                if (v.tipoConta.Equals(1))
                {
                   
                    MessageBox.Show("Apenas é possivel alterar o pin em Contas Com Cartão", "Alteração do PIN Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                ContaComCartao conta2 = new ContaComCartao();
                conta2.alterarPin(txtPassActual, txtPassAntigo,  txtNumContaAlter);
                MessageBox.Show("Pin Actualizado com Sucesso", "Alteração do PIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Campos Vazios não são permitidos", "Capos Nulos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Campos Vazios não são permitidos", "Capos Nulos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
            catch (ArgumentException)
            {
                MessageBox.Show("PIN Diferente do Actual", "Erro PIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        }
    }

