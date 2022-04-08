namespace Contas
{
    partial class LevaDepo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevaDepo));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNumContaLev = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPinLev = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPinDep = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNumContaDEP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMontanteLev = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMontanteDep = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDep = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLevantar = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(239, 204);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(82, 16);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Deposito";
            // 
            // txtNumContaLev
            // 
            this.txtNumContaLev.BackColor = System.Drawing.SystemColors.Info;
            this.txtNumContaLev.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumContaLev.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumContaLev.ForeColor = System.Drawing.Color.Black;
            this.txtNumContaLev.HintForeColor = System.Drawing.Color.Black;
            this.txtNumContaLev.HintText = "Nº da Conta";
            this.txtNumContaLev.isPassword = false;
            this.txtNumContaLev.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNumContaLev.LineIdleColor = System.Drawing.Color.Violet;
            this.txtNumContaLev.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNumContaLev.LineThickness = 3;
            this.txtNumContaLev.Location = new System.Drawing.Point(31, 68);
            this.txtNumContaLev.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumContaLev.Name = "txtNumContaLev";
            this.txtNumContaLev.Size = new System.Drawing.Size(278, 29);
            this.txtNumContaLev.TabIndex = 2;
            this.txtNumContaLev.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumContaLev.OnValueChanged += new System.EventHandler(this.txtNumContaLev_OnValueChanged);
            // 
            // txtPinLev
            // 
            this.txtPinLev.BackColor = System.Drawing.SystemColors.Info;
            this.txtPinLev.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPinLev.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinLev.ForeColor = System.Drawing.Color.White;
            this.txtPinLev.HintForeColor = System.Drawing.Color.Black;
            this.txtPinLev.HintText = "PIN";
            this.txtPinLev.isPassword = false;
            this.txtPinLev.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPinLev.LineIdleColor = System.Drawing.Color.Violet;
            this.txtPinLev.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPinLev.LineThickness = 3;
            this.txtPinLev.Location = new System.Drawing.Point(31, 105);
            this.txtPinLev.Margin = new System.Windows.Forms.Padding(4);
            this.txtPinLev.Name = "txtPinLev";
            this.txtPinLev.Size = new System.Drawing.Size(166, 29);
            this.txtPinLev.TabIndex = 3;
            this.txtPinLev.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(204, 112);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(150, 22);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Deixar em branco caso for \r\numa conta normal";
            // 
            // bl
            // 
            this.bl.AutoSize = true;
            this.bl.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl.Location = new System.Drawing.Point(197, 9);
            this.bl.Name = "bl";
            this.bl.Size = new System.Drawing.Size(150, 16);
            this.bl.TabIndex = 5;
            this.bl.Text = "LEVANTAMENTO";
            // 
            // txtPinDep
            // 
            this.txtPinDep.BackColor = System.Drawing.SystemColors.Info;
            this.txtPinDep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPinDep.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinDep.ForeColor = System.Drawing.Color.White;
            this.txtPinDep.HintForeColor = System.Drawing.Color.Black;
            this.txtPinDep.HintText = "PIN";
            this.txtPinDep.isPassword = false;
            this.txtPinDep.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPinDep.LineIdleColor = System.Drawing.Color.Violet;
            this.txtPinDep.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPinDep.LineThickness = 3;
            this.txtPinDep.Location = new System.Drawing.Point(31, 286);
            this.txtPinDep.Margin = new System.Windows.Forms.Padding(4);
            this.txtPinDep.Name = "txtPinDep";
            this.txtPinDep.Size = new System.Drawing.Size(166, 29);
            this.txtPinDep.TabIndex = 8;
            this.txtPinDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNumContaDEP
            // 
            this.txtNumContaDEP.BackColor = System.Drawing.SystemColors.Info;
            this.txtNumContaDEP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumContaDEP.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumContaDEP.ForeColor = System.Drawing.Color.Black;
            this.txtNumContaDEP.HintForeColor = System.Drawing.Color.Black;
            this.txtNumContaDEP.HintText = "Nº da Conta";
            this.txtNumContaDEP.isPassword = false;
            this.txtNumContaDEP.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNumContaDEP.LineIdleColor = System.Drawing.Color.Violet;
            this.txtNumContaDEP.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNumContaDEP.LineThickness = 3;
            this.txtNumContaDEP.Location = new System.Drawing.Point(31, 249);
            this.txtNumContaDEP.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumContaDEP.Name = "txtNumContaDEP";
            this.txtNumContaDEP.Size = new System.Drawing.Size(278, 29);
            this.txtNumContaDEP.TabIndex = 7;
            this.txtNumContaDEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumContaDEP.OnValueChanged += new System.EventHandler(this.txtNumContaDEP_OnValueChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(215, 293);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(150, 22);
            this.bunifuCustomLabel3.TabIndex = 9;
            this.bunifuCustomLabel3.Text = "Deixar em branco caso for \r\numa conta normal";
            // 
            // txtMontanteLev
            // 
            this.txtMontanteLev.BackColor = System.Drawing.SystemColors.Info;
            this.txtMontanteLev.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontanteLev.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontanteLev.ForeColor = System.Drawing.Color.Black;
            this.txtMontanteLev.HintForeColor = System.Drawing.Color.Black;
            this.txtMontanteLev.HintText = "Montante";
            this.txtMontanteLev.isPassword = false;
            this.txtMontanteLev.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMontanteLev.LineIdleColor = System.Drawing.Color.Violet;
            this.txtMontanteLev.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMontanteLev.LineThickness = 3;
            this.txtMontanteLev.Location = new System.Drawing.Point(31, 143);
            this.txtMontanteLev.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontanteLev.Name = "txtMontanteLev";
            this.txtMontanteLev.Size = new System.Drawing.Size(166, 29);
            this.txtMontanteLev.TabIndex = 12;
            this.txtMontanteLev.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMontanteDep
            // 
            this.txtMontanteDep.BackColor = System.Drawing.SystemColors.Info;
            this.txtMontanteDep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontanteDep.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontanteDep.ForeColor = System.Drawing.Color.Black;
            this.txtMontanteDep.HintForeColor = System.Drawing.Color.Black;
            this.txtMontanteDep.HintText = "Montante";
            this.txtMontanteDep.isPassword = false;
            this.txtMontanteDep.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMontanteDep.LineIdleColor = System.Drawing.Color.Violet;
            this.txtMontanteDep.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMontanteDep.LineThickness = 3;
            this.txtMontanteDep.Location = new System.Drawing.Point(31, 324);
            this.txtMontanteDep.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontanteDep.Name = "txtMontanteDep";
            this.txtMontanteDep.Size = new System.Drawing.Size(166, 29);
            this.txtMontanteDep.TabIndex = 13;
            this.txtMontanteDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Contas.Properties.Resources.icons8_ok_96px;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(436, 295);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Contas.Properties.Resources.icons8_ok_96px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(436, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnDep
            // 
            this.btnDep.ActiveBorderThickness = 1;
            this.btnDep.ActiveCornerRadius = 20;
            this.btnDep.ActiveFillColor = System.Drawing.Color.Turquoise;
            this.btnDep.ActiveForecolor = System.Drawing.Color.White;
            this.btnDep.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDep.BackColor = System.Drawing.Color.Azure;
            this.btnDep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDep.BackgroundImage")));
            this.btnDep.ButtonText = "Depositar";
            this.btnDep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDep.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDep.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDep.IdleBorderThickness = 1;
            this.btnDep.IdleCornerRadius = 20;
            this.btnDep.IdleFillColor = System.Drawing.Color.White;
            this.btnDep.IdleForecolor = System.Drawing.Color.Turquoise;
            this.btnDep.IdleLineColor = System.Drawing.Color.Violet;
            this.btnDep.Location = new System.Drawing.Point(373, 324);
            this.btnDep.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnDep.Name = "btnDep";
            this.btnDep.Size = new System.Drawing.Size(146, 29);
            this.btnDep.TabIndex = 11;
            this.btnDep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDep.Click += new System.EventHandler(this.btnDep_Click);
            // 
            // btnLevantar
            // 
            this.btnLevantar.ActiveBorderThickness = 1;
            this.btnLevantar.ActiveCornerRadius = 20;
            this.btnLevantar.ActiveFillColor = System.Drawing.Color.Turquoise;
            this.btnLevantar.ActiveForecolor = System.Drawing.Color.White;
            this.btnLevantar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLevantar.BackColor = System.Drawing.Color.Azure;
            this.btnLevantar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLevantar.BackgroundImage")));
            this.btnLevantar.ButtonText = "Levantar";
            this.btnLevantar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevantar.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevantar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLevantar.IdleBorderThickness = 1;
            this.btnLevantar.IdleCornerRadius = 20;
            this.btnLevantar.IdleFillColor = System.Drawing.Color.White;
            this.btnLevantar.IdleForecolor = System.Drawing.Color.Turquoise;
            this.btnLevantar.IdleLineColor = System.Drawing.Color.Violet;
            this.btnLevantar.Location = new System.Drawing.Point(373, 143);
            this.btnLevantar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnLevantar.Name = "btnLevantar";
            this.btnLevantar.Size = new System.Drawing.Size(146, 29);
            this.btnLevantar.TabIndex = 10;
            this.btnLevantar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLevantar.Click += new System.EventHandler(this.btnLevantar_Click);
            // 
            // LevaDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(534, 382);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMontanteDep);
            this.Controls.Add(this.txtMontanteLev);
            this.Controls.Add(this.btnDep);
            this.Controls.Add(this.btnLevantar);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtPinDep);
            this.Controls.Add(this.txtNumContaDEP);
            this.Controls.Add(this.bl);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtPinLev);
            this.Controls.Add(this.txtNumContaLev);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "LevaDepo";
            this.Text = "LevaDepo";
            this.Load += new System.EventHandler(this.LevaDepo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNumContaLev;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPinLev;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPinDep;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNumContaDEP;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLevantar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDep;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMontanteLev;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMontanteDep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}