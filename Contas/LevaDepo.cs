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
    public partial class LevaDepo : Form
    {
        Conta v = new Conta();
        public LevaDepo()
        {
            InitializeComponent();
        }

        private void txtNumContaLev_OnValueChanged(object sender, EventArgs e)
        {
            
            try
            {
               pictureBox1.Show();
            v.verificarse(txtNumContaLev, pictureBox1, btnLevantar);
              
            }
            catch (FormatException)
            {
                btnLevantar.Enabled = false;
            }
          
            
        }

        private void txtNumContaDEP_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox2.Show();
                v.verificarse(txtNumContaDEP, pictureBox2, btnDep);
        
            }
            catch (FormatException)
            {
                btnLevantar.Enabled = false;
            }
        }

        private void LevaDepo_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
        }

        private void btnLevantar_Click(object sender, EventArgs e)
        {
            try
            {

                if (v.tipoConta.Equals(1))
                {
                    ContaNormal conta1 = new ContaNormal();
                    conta1.levantamento(txtNumContaLev, txtMontanteLev);
                    MessageBox.Show("Saque efectuado com sucesso", "Saque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    ContaComCartao canta2 = new ContaComCartao();
                    canta2.levantamento(txtNumContaLev, txtMontanteLev,txtPinLev);
                    MessageBox.Show("Saque efectuado com sucesso", "Saque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Verifique se preencheu bem os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidEnumArgumentException)
            {
                MessageBox.Show("O PIN ou o número da conta está errado verifica", "Erro de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("O Montante especificado não é valido pois é negativo", "Erro Montante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("O Montante especificado não é valido pois ela pode zerar a conta", "Erro Montante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDep_Click(object sender, EventArgs e)
        {
            try
            {
                if (v.tipoConta.Equals(1))
                {
                    ContaNormal conta1 = new ContaNormal();
                    conta1.deposito(txtMontanteDep, txtNumContaDEP);
                    MessageBox.Show("Deposito efectuado com sucesso", "Deposito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   ContaComCartao conta2 = new ContaComCartao();
                    conta2.deposito(txtMontanteDep, txtNumContaDEP, txtPinDep);
                    MessageBox.Show("Deposito efectuado com sucesso", "Deposito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Verifica se há algum campo vazio", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidEnumArgumentException)
            {
                MessageBox.Show("PIN ou Conta, Errada", "Erro de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Conta inexistente", "Erro Conta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
        }
    