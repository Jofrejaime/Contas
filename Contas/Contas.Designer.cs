namespace Contas
{
    partial class Contas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbNc = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ContaComCartão = new System.Windows.Forms.LinkLabel();
            this.ContasNormais = new System.Windows.Forms.LinkLabel();
            this.dataContas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataContas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNc
            // 
            this.lbNc.AutoSize = true;
            this.lbNc.Font = new System.Drawing.Font("Font Awesome 6 Free Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNc.Location = new System.Drawing.Point(12, 22);
            this.lbNc.Name = "lbNc";
            this.lbNc.Size = new System.Drawing.Size(172, 16);
            this.lbNc.TabIndex = 1;
            this.lbNc.Text = "Contas Normais";
            this.lbNc.Click += new System.EventHandler(this.lbNc_Click);
            // 
            // ContaComCartão
            // 
            this.ContaComCartão.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ContaComCartão.AutoSize = true;
            this.ContaComCartão.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(134)))));
            this.ContaComCartão.Font = new System.Drawing.Font("Font Awesome 6 Free Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContaComCartão.Location = new System.Drawing.Point(353, 75);
            this.ContaComCartão.Name = "ContaComCartão";
            this.ContaComCartão.Size = new System.Drawing.Size(169, 13);
            this.ContaComCartão.TabIndex = 3;
            this.ContaComCartão.TabStop = true;
            this.ContaComCartão.Text = "Contas Com Cartao\r\n";
            this.ContaComCartão.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ContaComCartão.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // ContasNormais
            // 
            this.ContasNormais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ContasNormais.AutoSize = true;
            this.ContasNormais.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(134)))));
            this.ContasNormais.Font = new System.Drawing.Font("Font Awesome 6 Free Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContasNormais.Location = new System.Drawing.Point(353, 75);
            this.ContasNormais.Name = "ContasNormais";
            this.ContasNormais.Size = new System.Drawing.Size(141, 13);
            this.ContasNormais.TabIndex = 5;
            this.ContasNormais.TabStop = true;
            this.ContasNormais.Text = "Contas Normais";
            this.ContasNormais.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ContasNormais.Click += new System.EventHandler(this.ContasNormais_Click);
            // 
            // dataContas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataContas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataContas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataContas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataContas.BackgroundColor = System.Drawing.Color.Azure;
            this.dataContas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataContas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataContas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataContas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataContas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataContas.DoubleBuffered = true;
            this.dataContas.EnableHeadersVisualStyles = false;
            this.dataContas.GridColor = System.Drawing.Color.Azure;
            this.dataContas.HeaderBgColor = System.Drawing.Color.RosyBrown;
            this.dataContas.HeaderForeColor = System.Drawing.Color.White;
            this.dataContas.Location = new System.Drawing.Point(0, 91);
            this.dataContas.Name = "dataContas";
            this.dataContas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataContas.Size = new System.Drawing.Size(534, 291);
            this.dataContas.TabIndex = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(134)))));
            this.linkLabel1.Font = new System.Drawing.Font("Font Awesome 6 Free Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(281, 75);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mostrar";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Contas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(534, 382);
            this.Controls.Add(this.dataContas);
            this.Controls.Add(this.ContasNormais);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ContaComCartão);
            this.Controls.Add(this.lbNc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contas";
            this.Text = "Contas";
            this.Load += new System.EventHandler(this.Contas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataContas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel lbNc;
        private System.Windows.Forms.LinkLabel ContaComCartão;
        private System.Windows.Forms.LinkLabel ContasNormais;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataContas;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}