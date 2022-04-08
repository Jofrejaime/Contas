using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Outras Bibliotecas
using System.Windows.Forms;
using Bunifu.Framework.UI;
namespace Contas
{
    public partial class CadastrosContas : Form
    {
        //Fields
        private BunifuFlatButton currentbtn;
        private Panel leftBorderBtn;
        private Form currentForm;
        //Construtor

        public CadastrosContas()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 48);
            panelMenu.Controls.Add(leftBorderBtn);

        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 116);
            public static Color color3 = Color.FromArgb(253, 158, 176);
         
        }
        //metodos
        private void ActivateButton(Object senderBtn, Color color, Label lb, PictureBox pct)
        {
            if (senderBtn != null)

            {
                DisableButton();
                currentbtn = (BunifuFlatButton)senderBtn;
                currentbtn.BackColor = Color.FromArgb(37,36,81);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.Iconcolor = color;
                //Left border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(-1, currentbtn.Location.Y);
                leftBorderBtn.Visible = true;
                lb.Text = currentbtn.Text;
                pct.BackgroundImage = currentbtn.Iconimage;
            }
        }
        private void DisableButton()
        {
            if (currentbtn != null)
            {
               
                currentbtn.BackColor = Color.Transparent;
                currentbtn.ForeColor = Color.White;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.Iconcolor = Color.Transparent;
               
            }
        }
        private void CadastrosContas_Load(object sender, EventArgs e)
        {
           
        }

        private void OpenChildForm(Form pequenoForm)
        {
            if (currentForm !=null)
            {
                currentForm.Close();

            }
            currentForm = pequenoForm;
            pequenoForm.TopLevel = false;
            pequenoForm.Dock = DockStyle.Fill;
            PainelForm.Controls.Add(pequenoForm);
            PainelForm.Tag = pequenoForm;
            pequenoForm.BringToFront();
            pequenoForm.Show();

        }
     private void closeFor(Form pequenoForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();

            }
            pequenoForm.Controls.Remove(pequenoForm);
            PainelForm.Tag = PainelForm.Tag;
            pequenoForm.Close();
        }
        private void btnContas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.BlueViolet, lbPrincipal, pctChang);
            OpenChildForm( new Contas());
        }

        private void btnLevDep_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Aqua, lbPrincipal, pctChang);
            OpenChildForm(new LevaDepo());
        }

        private void btnDifi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Aquamarine, lbPrincipal, pctChang);
            OpenChildForm(new Difinicoes());
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Reset1();
        }
        private void Reset1()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            lbPrincipal.Text = "Home";
            pctChang.BackgroundImage = global::Contas.Properties.Resources.icons8_home_96px; 
        }

        private void lnHome_Click(object sender, EventArgs e)
        {

            DisableButton();
            leftBorderBtn.Visible = false;
            lbPrincipal.Text = "Home";
            pctChang.BackgroundImage = global::Contas.Properties.Resources.icons8_home_96px;
            currentForm.Close();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
           


        }
        Conta conta = new Conta();
        private void btnCriaConta_Click(object sender, EventArgs e)
        {
           try
            {
            conta.cadastrarConta(txtNomeCriarConta, txtSaldoInicial, numericUpDown1);
                MessageBox.Show("Conta Criada com Sucesso", "Sucesso",MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (numericUpDown1.Value == 2)
            {
                MessageBox.Show("Conta Criada com Sucesso \nO seu PIN é '" + conta.PIN+"'", "PIN da Conta", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            }
            catch (ArgumentNullException )
            {
                MessageBox.Show("Verifica se preenceu bem as informações","Informações nulas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
           
        }
    }
}
