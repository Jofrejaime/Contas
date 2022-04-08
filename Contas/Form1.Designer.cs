namespace Contas
{
    partial class CadastrosContas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrosContas));
            this.PainelForm = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCriaConta = new Bunifu.Framework.UI.BunifuTileButton();
            this.lbtest = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtSaldoInicial = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNomeCriarConta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbPrincipal = new System.Windows.Forms.Label();
            this.pctChang = new System.Windows.Forms.PictureBox();
            this.panelMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lnHome = new System.Windows.Forms.Label();
            this.btnDifi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLevDep = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnContas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Home = new System.Windows.Forms.PictureBox();
            this.PainelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctChang)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.SuspendLayout();
            // 
            // PainelForm
            // 
            this.PainelForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PainelForm.BackgroundImage")));
            this.PainelForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PainelForm.Controls.Add(this.btnCriaConta);
            this.PainelForm.Controls.Add(this.lbtest);
            this.PainelForm.Controls.Add(this.numericUpDown1);
            this.PainelForm.Controls.Add(this.txtSaldoInicial);
            this.PainelForm.Controls.Add(this.txtNomeCriarConta);
            this.PainelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelForm.GradientBottomLeft = System.Drawing.Color.Turquoise;
            this.PainelForm.GradientBottomRight = System.Drawing.Color.OrangeRed;
            this.PainelForm.GradientTopLeft = System.Drawing.Color.White;
            this.PainelForm.GradientTopRight = System.Drawing.Color.White;
            this.PainelForm.Location = new System.Drawing.Point(165, 58);
            this.PainelForm.Name = "PainelForm";
            this.PainelForm.Quality = 10;
            this.PainelForm.Size = new System.Drawing.Size(534, 382);
            this.PainelForm.TabIndex = 2;
            this.PainelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // btnCriaConta
            // 
            this.btnCriaConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriaConta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCriaConta.color = System.Drawing.SystemColors.ScrollBar;
            this.btnCriaConta.colorActive = System.Drawing.Color.MediumPurple;
            this.btnCriaConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriaConta.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriaConta.ForeColor = System.Drawing.Color.White;
            this.btnCriaConta.Image = global::Contas.Properties.Resources.icons8_add_user_group_woman_man_80px;
            this.btnCriaConta.ImagePosition = 18;
            this.btnCriaConta.ImageZoom = 50;
            this.btnCriaConta.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnCriaConta.LabelPosition = 36;
            this.btnCriaConta.LabelText = "Criar Conta";
            this.btnCriaConta.Location = new System.Drawing.Point(395, 110);
            this.btnCriaConta.Margin = new System.Windows.Forms.Padding(6);
            this.btnCriaConta.Name = "btnCriaConta";
            this.btnCriaConta.Size = new System.Drawing.Size(124, 139);
            this.btnCriaConta.TabIndex = 4;
            this.btnCriaConta.Click += new System.EventHandler(this.btnCriaConta_Click);
            // 
            // lbtest
            // 
            this.lbtest.AutoSize = true;
            this.lbtest.BackColor = System.Drawing.Color.Transparent;
            this.lbtest.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtest.Location = new System.Drawing.Point(221, 227);
            this.lbtest.Name = "lbtest";
            this.lbtest.Size = new System.Drawing.Size(146, 22);
            this.lbtest.TabIndex = 3;
            this.lbtest.Text = "1 - Conta Nomal\r\n2 - Conta Com Cartão";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(24, 229);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(122, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSaldoInicial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSaldoInicial.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoInicial.ForeColor = System.Drawing.Color.Black;
            this.txtSaldoInicial.HintForeColor = System.Drawing.Color.Empty;
            this.txtSaldoInicial.HintText = "Saldo Inicial da Conta";
            this.txtSaldoInicial.isPassword = false;
            this.txtSaldoInicial.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSaldoInicial.LineIdleColor = System.Drawing.Color.Aqua;
            this.txtSaldoInicial.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSaldoInicial.LineThickness = 3;
            this.txtSaldoInicial.Location = new System.Drawing.Point(24, 168);
            this.txtSaldoInicial.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Size = new System.Drawing.Size(343, 29);
            this.txtSaldoInicial.TabIndex = 1;
            this.txtSaldoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNomeCriarConta
            // 
            this.txtNomeCriarConta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNomeCriarConta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeCriarConta.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCriarConta.ForeColor = System.Drawing.Color.Black;
            this.txtNomeCriarConta.HintForeColor = System.Drawing.Color.Empty;
            this.txtNomeCriarConta.HintText = "Nome Do Titular";
            this.txtNomeCriarConta.isPassword = false;
            this.txtNomeCriarConta.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNomeCriarConta.LineIdleColor = System.Drawing.Color.Aqua;
            this.txtNomeCriarConta.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNomeCriarConta.LineThickness = 3;
            this.txtNomeCriarConta.Location = new System.Drawing.Point(24, 110);
            this.txtNomeCriarConta.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtNomeCriarConta.Name = "txtNomeCriarConta";
            this.txtNomeCriarConta.Size = new System.Drawing.Size(343, 29);
            this.txtNomeCriarConta.TabIndex = 0;
            this.txtNomeCriarConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.Yellow;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.lbPrincipal);
            this.bunifuGradientPanel2.Controls.Add(this.pctChang);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.OrangeRed;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Turquoise;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.SystemColors.ScrollBar;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(165, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(534, 58);
            this.bunifuGradientPanel2.TabIndex = 1;
            // 
            // lbPrincipal
            // 
            this.lbPrincipal.AutoSize = true;
            this.lbPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lbPrincipal.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrincipal.Location = new System.Drawing.Point(77, 18);
            this.lbPrincipal.Name = "lbPrincipal";
            this.lbPrincipal.Size = new System.Drawing.Size(69, 19);
            this.lbPrincipal.TabIndex = 1;
            this.lbPrincipal.Text = "HOME";
            // 
            // pctChang
            // 
            this.pctChang.BackColor = System.Drawing.Color.Transparent;
            this.pctChang.BackgroundImage = global::Contas.Properties.Resources.icons8_home_96px;
            this.pctChang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctChang.Location = new System.Drawing.Point(24, 9);
            this.pctChang.Name = "pctChang";
            this.pctChang.Size = new System.Drawing.Size(47, 38);
            this.pctChang.TabIndex = 0;
            this.pctChang.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Yellow;
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.lnHome);
            this.panelMenu.Controls.Add(this.btnDifi);
            this.panelMenu.Controls.Add(this.btnLevDep);
            this.panelMenu.Controls.Add(this.btnContas);
            this.panelMenu.Controls.Add(this.Home);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.GradientBottomLeft = System.Drawing.Color.OrangeRed;
            this.panelMenu.GradientBottomRight = System.Drawing.Color.Turquoise;
            this.panelMenu.GradientTopLeft = System.Drawing.SystemColors.WindowText;
            this.panelMenu.GradientTopRight = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Quality = 10;
            this.panelMenu.Size = new System.Drawing.Size(165, 440);
            this.panelMenu.TabIndex = 0;
            // 
            // lnHome
            // 
            this.lnHome.AutoSize = true;
            this.lnHome.BackColor = System.Drawing.Color.Transparent;
            this.lnHome.Font = new System.Drawing.Font("Font Awesome 6 Free Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnHome.ForeColor = System.Drawing.Color.Aqua;
            this.lnHome.Location = new System.Drawing.Point(70, 21);
            this.lnHome.Name = "lnHome";
            this.lnHome.Size = new System.Drawing.Size(58, 16);
            this.lnHome.TabIndex = 5;
            this.lnHome.Text = "HOME";
            this.lnHome.Click += new System.EventHandler(this.lnHome_Click);
            // 
            // btnDifi
            // 
            this.btnDifi.Activecolor = System.Drawing.Color.Transparent;
            this.btnDifi.BackColor = System.Drawing.Color.Transparent;
            this.btnDifi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDifi.BorderRadius = 0;
            this.btnDifi.ButtonText = "Difiniçoes";
            this.btnDifi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDifi.DisabledColor = System.Drawing.Color.Gray;
            this.btnDifi.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnDifi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDifi.Iconimage = global::Contas.Properties.Resources.icons8_settings_128px_1;
            this.btnDifi.Iconimage_right = null;
            this.btnDifi.Iconimage_right_Selected = null;
            this.btnDifi.Iconimage_Selected = null;
            this.btnDifi.IconMarginLeft = 0;
            this.btnDifi.IconMarginRight = 0;
            this.btnDifi.IconRightVisible = true;
            this.btnDifi.IconRightZoom = 0D;
            this.btnDifi.IconVisible = true;
            this.btnDifi.IconZoom = 90D;
            this.btnDifi.IsTab = false;
            this.btnDifi.Location = new System.Drawing.Point(9, 207);
            this.btnDifi.Name = "btnDifi";
            this.btnDifi.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDifi.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.btnDifi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDifi.selected = false;
            this.btnDifi.Size = new System.Drawing.Size(155, 48);
            this.btnDifi.TabIndex = 4;
            this.btnDifi.Text = "Difiniçoes";
            this.btnDifi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDifi.Textcolor = System.Drawing.Color.White;
            this.btnDifi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDifi.Click += new System.EventHandler(this.btnDifi_Click);
            // 
            // btnLevDep
            // 
            this.btnLevDep.Activecolor = System.Drawing.Color.Transparent;
            this.btnLevDep.BackColor = System.Drawing.Color.Transparent;
            this.btnLevDep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevDep.BorderRadius = 0;
            this.btnLevDep.ButtonText = "Levantamento  Depósito";
            this.btnLevDep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevDep.DisabledColor = System.Drawing.Color.Gray;
            this.btnLevDep.Font = new System.Drawing.Font("Font Awesome 6 Free Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevDep.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnLevDep.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLevDep.Iconimage = global::Contas.Properties.Resources.bank_96px;
            this.btnLevDep.Iconimage_right = null;
            this.btnLevDep.Iconimage_right_Selected = null;
            this.btnLevDep.Iconimage_Selected = null;
            this.btnLevDep.IconMarginLeft = 0;
            this.btnLevDep.IconMarginRight = 0;
            this.btnLevDep.IconRightVisible = true;
            this.btnLevDep.IconRightZoom = 0D;
            this.btnLevDep.IconVisible = true;
            this.btnLevDep.IconZoom = 90D;
            this.btnLevDep.IsTab = false;
            this.btnLevDep.Location = new System.Drawing.Point(8, 153);
            this.btnLevDep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLevDep.Name = "btnLevDep";
            this.btnLevDep.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLevDep.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.btnLevDep.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLevDep.selected = false;
            this.btnLevDep.Size = new System.Drawing.Size(156, 48);
            this.btnLevDep.TabIndex = 3;
            this.btnLevDep.Text = "Levantamento  Depósito";
            this.btnLevDep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLevDep.Textcolor = System.Drawing.Color.White;
            this.btnLevDep.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevDep.Click += new System.EventHandler(this.btnLevDep_Click);
            // 
            // btnContas
            // 
            this.btnContas.Activecolor = System.Drawing.Color.Transparent;
            this.btnContas.BackColor = System.Drawing.Color.Transparent;
            this.btnContas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContas.BorderRadius = 0;
            this.btnContas.ButtonText = "Contas";
            this.btnContas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContas.DisabledColor = System.Drawing.Color.Gray;
            this.btnContas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnContas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnContas.Iconimage = global::Contas.Properties.Resources.icons8_merchant_account_128px;
            this.btnContas.Iconimage_right = null;
            this.btnContas.Iconimage_right_Selected = null;
            this.btnContas.Iconimage_Selected = null;
            this.btnContas.IconMarginLeft = 0;
            this.btnContas.IconMarginRight = 0;
            this.btnContas.IconRightVisible = true;
            this.btnContas.IconRightZoom = 0D;
            this.btnContas.IconVisible = true;
            this.btnContas.IconZoom = 90D;
            this.btnContas.IsTab = false;
            this.btnContas.Location = new System.Drawing.Point(8, 99);
            this.btnContas.Name = "btnContas";
            this.btnContas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnContas.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.btnContas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnContas.selected = false;
            this.btnContas.Size = new System.Drawing.Size(156, 48);
            this.btnContas.TabIndex = 2;
            this.btnContas.Text = "Contas";
            this.btnContas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContas.Textcolor = System.Drawing.Color.White;
            this.btnContas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContas.Click += new System.EventHandler(this.btnContas_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.BackgroundImage = global::Contas.Properties.Resources.icons8_account_100px_1;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.Location = new System.Drawing.Point(20, 9);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(44, 38);
            this.Home.TabIndex = 2;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // CadastrosContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 440);
            this.Controls.Add(this.PainelForm);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastrosContas";
            this.Text = "CadastroContas";
            this.Load += new System.EventHandler(this.CadastrosContas_Load);
            this.PainelForm.ResumeLayout(false);
            this.PainelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctChang)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel panelMenu;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label lnHome;
        private Bunifu.Framework.UI.BunifuFlatButton btnDifi;
        private Bunifu.Framework.UI.BunifuFlatButton btnLevDep;
        private Bunifu.Framework.UI.BunifuFlatButton btnContas;
        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.PictureBox pctChang;
        private System.Windows.Forms.Label lbPrincipal;
        private Bunifu.Framework.UI.BunifuGradientPanel PainelForm;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSaldoInicial;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNomeCriarConta;
        private Bunifu.Framework.UI.BunifuCustomLabel lbtest;
        private Bunifu.Framework.UI.BunifuTileButton btnCriaConta;
    }
}

