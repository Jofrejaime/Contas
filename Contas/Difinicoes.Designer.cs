namespace Contas
{
    partial class Difinicoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Difinicoes));
            this.txtNumContaApa = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPINContaApa = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassAntigo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNumContaAlter = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassActual = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.linkApag = new System.Windows.Forms.LinkLabel();
            this.linkAlterar = new System.Windows.Forms.LinkLabel();
            this.btnApagar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAlterarPin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumContaApa
            // 
            this.txtNumContaApa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumContaApa.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumContaApa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumContaApa.HintForeColor = System.Drawing.Color.Empty;
            this.txtNumContaApa.HintText = "Nº Conta";
            this.txtNumContaApa.isPassword = false;
            this.txtNumContaApa.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNumContaApa.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNumContaApa.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNumContaApa.LineThickness = 2;
            this.txtNumContaApa.Location = new System.Drawing.Point(82, 57);
            this.txtNumContaApa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumContaApa.Name = "txtNumContaApa";
            this.txtNumContaApa.Size = new System.Drawing.Size(153, 21);
            this.txtNumContaApa.TabIndex = 1;
            this.txtNumContaApa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumContaApa.OnValueChanged += new System.EventHandler(this.txtNumContaApa_OnValueChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(255, 100);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(150, 22);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Deixar em branco caso for \r\numa conta normal";
            // 
            // txtPINContaApa
            // 
            this.txtPINContaApa.AllowDrop = true;
            this.txtPINContaApa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPINContaApa.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPINContaApa.ForeColor = System.Drawing.Color.Transparent;
            this.txtPINContaApa.HintForeColor = System.Drawing.Color.Empty;
            this.txtPINContaApa.HintText = "PIN";
            this.txtPINContaApa.isPassword = false;
            this.txtPINContaApa.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPINContaApa.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPINContaApa.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPINContaApa.LineThickness = 2;
            this.txtPINContaApa.Location = new System.Drawing.Point(84, 100);
            this.txtPINContaApa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPINContaApa.Name = "txtPINContaApa";
            this.txtPINContaApa.Size = new System.Drawing.Size(153, 21);
            this.txtPINContaApa.TabIndex = 6;
            this.txtPINContaApa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPassAntigo
            // 
            this.txtPassAntigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassAntigo.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassAntigo.ForeColor = System.Drawing.Color.Transparent;
            this.txtPassAntigo.HintForeColor = System.Drawing.Color.Black;
            this.txtPassAntigo.HintText = "PIN Actual";
            this.txtPassAntigo.isPassword = false;
            this.txtPassAntigo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPassAntigo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassAntigo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPassAntigo.LineThickness = 2;
            this.txtPassAntigo.Location = new System.Drawing.Point(82, 264);
            this.txtPassAntigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassAntigo.Name = "txtPassAntigo";
            this.txtPassAntigo.Size = new System.Drawing.Size(153, 21);
            this.txtPassAntigo.TabIndex = 9;
            this.txtPassAntigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(258, 219);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(147, 22);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Apenas Contas Com Cartão\r\nPodem Alterar PIN\r\n";
            // 
            // txtNumContaAlter
            // 
            this.txtNumContaAlter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumContaAlter.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumContaAlter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumContaAlter.HintForeColor = System.Drawing.Color.Empty;
            this.txtNumContaAlter.HintText = "Nº Conta";
            this.txtNumContaAlter.isPassword = false;
            this.txtNumContaAlter.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNumContaAlter.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNumContaAlter.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNumContaAlter.LineThickness = 2;
            this.txtNumContaAlter.Location = new System.Drawing.Point(82, 219);
            this.txtNumContaAlter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumContaAlter.Name = "txtNumContaAlter";
            this.txtNumContaAlter.Size = new System.Drawing.Size(153, 21);
            this.txtNumContaAlter.TabIndex = 7;
            this.txtNumContaAlter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumContaAlter.OnValueChanged += new System.EventHandler(this.txtNumContaAlter_OnValueChanged);
            // 
            // txtPassActual
            // 
            this.txtPassActual.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassActual.Font = new System.Drawing.Font("Font Awesome 5 Free Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassActual.ForeColor = System.Drawing.Color.Transparent;
            this.txtPassActual.HintForeColor = System.Drawing.Color.Black;
            this.txtPassActual.HintText = "PIN NOVO";
            this.txtPassActual.isPassword = false;
            this.txtPassActual.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPassActual.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassActual.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPassActual.LineThickness = 2;
            this.txtPassActual.Location = new System.Drawing.Point(84, 310);
            this.txtPassActual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassActual.Name = "txtPassActual";
            this.txtPassActual.Size = new System.Drawing.Size(153, 21);
            this.txtPassActual.TabIndex = 11;
            this.txtPassActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // linkApag
            // 
            this.linkApag.ActiveLinkColor = System.Drawing.Color.Teal;
            this.linkApag.AutoSize = true;
            this.linkApag.ForeColor = System.Drawing.Color.Teal;
            this.linkApag.Location = new System.Drawing.Point(12, 24);
            this.linkApag.Name = "linkApag";
            this.linkApag.Size = new System.Drawing.Size(134, 15);
            this.linkApag.TabIndex = 14;
            this.linkApag.TabStop = true;
            this.linkApag.Text = "Apagar Conta";
            // 
            // linkAlterar
            // 
            this.linkAlterar.ActiveLinkColor = System.Drawing.Color.Teal;
            this.linkAlterar.AutoSize = true;
            this.linkAlterar.ForeColor = System.Drawing.Color.Teal;
            this.linkAlterar.Location = new System.Drawing.Point(12, 189);
            this.linkAlterar.Name = "linkAlterar";
            this.linkAlterar.Size = new System.Drawing.Size(111, 15);
            this.linkAlterar.TabIndex = 15;
            this.linkAlterar.TabStop = true;
            this.linkAlterar.Text = "Alterar PIN";
            // 
            // btnApagar
            // 
            this.btnApagar.ActiveBorderThickness = 1;
            this.btnApagar.ActiveCornerRadius = 20;
            this.btnApagar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnApagar.ActiveForecolor = System.Drawing.Color.White;
            this.btnApagar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnApagar.BackColor = System.Drawing.Color.Azure;
            this.btnApagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApagar.BackgroundImage")));
            this.btnApagar.ButtonText = "APAGAR";
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnApagar.IdleBorderThickness = 1;
            this.btnApagar.IdleCornerRadius = 20;
            this.btnApagar.IdleFillColor = System.Drawing.Color.White;
            this.btnApagar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnApagar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnApagar.Location = new System.Drawing.Point(323, 54);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(5);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(181, 41);
            this.btnApagar.TabIndex = 13;
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAlterarPin
            // 
            this.btnAlterarPin.ActiveBorderThickness = 1;
            this.btnAlterarPin.ActiveCornerRadius = 20;
            this.btnAlterarPin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAlterarPin.ActiveForecolor = System.Drawing.Color.White;
            this.btnAlterarPin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAlterarPin.BackColor = System.Drawing.Color.Azure;
            this.btnAlterarPin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterarPin.BackgroundImage")));
            this.btnAlterarPin.ButtonText = "Alterar";
            this.btnAlterarPin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarPin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarPin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAlterarPin.IdleBorderThickness = 1;
            this.btnAlterarPin.IdleCornerRadius = 20;
            this.btnAlterarPin.IdleFillColor = System.Drawing.Color.White;
            this.btnAlterarPin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAlterarPin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAlterarPin.Location = new System.Drawing.Point(339, 290);
            this.btnAlterarPin.Margin = new System.Windows.Forms.Padding(5);
            this.btnAlterarPin.Name = "btnAlterarPin";
            this.btnAlterarPin.Size = new System.Drawing.Size(181, 41);
            this.btnAlterarPin.TabIndex = 12;
            this.btnAlterarPin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAlterarPin.Click += new System.EventHandler(this.btnAlterarPin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Contas.Properties.Resources.icons8_ok_96px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(482, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Contas.Properties.Resources.icons8_ok_96px;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(482, 264);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Difinicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(534, 382);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkAlterar);
            this.Controls.Add(this.linkApag);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAlterarPin);
            this.Controls.Add(this.txtPassActual);
            this.Controls.Add(this.txtPassAntigo);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtNumContaAlter);
            this.Controls.Add(this.txtPINContaApa);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtNumContaApa);
            this.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "Difinicoes";
            this.Text = "Difinicoes";
            this.Load += new System.EventHandler(this.Difinicoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNumContaApa;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPINContaApa;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassAntigo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNumContaAlter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassActual;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAlterarPin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnApagar;
        private System.Windows.Forms.LinkLabel linkApag;
        private System.Windows.Forms.LinkLabel linkAlterar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}