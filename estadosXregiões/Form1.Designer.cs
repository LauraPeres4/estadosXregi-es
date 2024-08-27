namespace estadosXregiões
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboLista1 = new System.Windows.Forms.ComboBox();
            this.cboNorte = new System.Windows.Forms.ComboBox();
            this.cboNordeste = new System.Windows.Forms.ComboBox();
            this.cboCentro = new System.Windows.Forms.ComboBox();
            this.cboSudeste = new System.Windows.Forms.ComboBox();
            this.cboSul = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEst = new System.Windows.Forms.Label();
            this.lblNorte = new System.Windows.Forms.Label();
            this.lblNordeste = new System.Windows.Forms.Label();
            this.lblCentro = new System.Windows.Forms.Label();
            this.lblSudeste = new System.Windows.Forms.Label();
            this.lblSul = new System.Windows.Forms.Label();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnNorte = new System.Windows.Forms.Button();
            this.btnNordeste = new System.Windows.Forms.Button();
            this.btnCentro = new System.Windows.Forms.Button();
            this.btnSudeste = new System.Windows.Forms.Button();
            this.btnSul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboLista1
            // 
            this.cboLista1.FormattingEnabled = true;
            this.cboLista1.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cboLista1.Location = new System.Drawing.Point(286, 48);
            this.cboLista1.Name = "cboLista1";
            this.cboLista1.Size = new System.Drawing.Size(197, 21);
            this.cboLista1.TabIndex = 0;
            this.cboLista1.SelectedIndexChanged += new System.EventHandler(this.cboLista1_SelectedIndexChanged);
            // 
            // cboNorte
            // 
            this.cboNorte.FormattingEnabled = true;
            this.cboNorte.Location = new System.Drawing.Point(286, 98);
            this.cboNorte.Name = "cboNorte";
            this.cboNorte.Size = new System.Drawing.Size(197, 21);
            this.cboNorte.TabIndex = 1;
            this.cboNorte.SelectedIndexChanged += new System.EventHandler(this.cboNorte_SelectedIndexChanged);
            // 
            // cboNordeste
            // 
            this.cboNordeste.FormattingEnabled = true;
            this.cboNordeste.Location = new System.Drawing.Point(286, 143);
            this.cboNordeste.Name = "cboNordeste";
            this.cboNordeste.Size = new System.Drawing.Size(197, 21);
            this.cboNordeste.TabIndex = 2;
            // 
            // cboCentro
            // 
            this.cboCentro.FormattingEnabled = true;
            this.cboCentro.Location = new System.Drawing.Point(286, 186);
            this.cboCentro.Name = "cboCentro";
            this.cboCentro.Size = new System.Drawing.Size(197, 21);
            this.cboCentro.TabIndex = 3;
            // 
            // cboSudeste
            // 
            this.cboSudeste.FormattingEnabled = true;
            this.cboSudeste.Location = new System.Drawing.Point(286, 233);
            this.cboSudeste.Name = "cboSudeste";
            this.cboSudeste.Size = new System.Drawing.Size(197, 21);
            this.cboSudeste.TabIndex = 4;
            // 
            // cboSul
            // 
            this.cboSul.FormattingEnabled = true;
            this.cboSul.Location = new System.Drawing.Point(286, 282);
            this.cboSul.Name = "cboSul";
            this.cboSul.Size = new System.Drawing.Size(197, 21);
            this.cboSul.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Todos os Estados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Região Norte:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Região Nordeste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Região Centro-Oeste";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Região Sudeste";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Região Sul";
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.Location = new System.Drawing.Point(525, 51);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(13, 13);
            this.lblEst.TabIndex = 12;
            this.lblEst.Text = "0";
            this.lblEst.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblNorte
            // 
            this.lblNorte.AutoSize = true;
            this.lblNorte.Location = new System.Drawing.Point(525, 101);
            this.lblNorte.Name = "lblNorte";
            this.lblNorte.Size = new System.Drawing.Size(13, 13);
            this.lblNorte.TabIndex = 13;
            this.lblNorte.Text = "0";
            this.lblNorte.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblNordeste
            // 
            this.lblNordeste.AutoSize = true;
            this.lblNordeste.Location = new System.Drawing.Point(525, 143);
            this.lblNordeste.Name = "lblNordeste";
            this.lblNordeste.Size = new System.Drawing.Size(13, 13);
            this.lblNordeste.TabIndex = 14;
            this.lblNordeste.Text = "0";
            this.lblNordeste.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblCentro
            // 
            this.lblCentro.AutoSize = true;
            this.lblCentro.Location = new System.Drawing.Point(525, 194);
            this.lblCentro.Name = "lblCentro";
            this.lblCentro.Size = new System.Drawing.Size(13, 13);
            this.lblCentro.TabIndex = 15;
            this.lblCentro.Text = "0";
            // 
            // lblSudeste
            // 
            this.lblSudeste.AutoSize = true;
            this.lblSudeste.Location = new System.Drawing.Point(525, 241);
            this.lblSudeste.Name = "lblSudeste";
            this.lblSudeste.Size = new System.Drawing.Size(13, 13);
            this.lblSudeste.TabIndex = 16;
            this.lblSudeste.Text = "0";
            this.lblSudeste.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblSul
            // 
            this.lblSul.AutoSize = true;
            this.lblSul.Location = new System.Drawing.Point(525, 285);
            this.lblSul.Name = "lblSul";
            this.lblSul.Size = new System.Drawing.Size(13, 13);
            this.lblSul.TabIndex = 17;
            this.lblSul.Text = "0";
            this.lblSul.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(489, 51);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(30, 23);
            this.btnEstado.TabIndex = 18;
            this.btnEstado.Text = "-";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNorte
            // 
            this.btnNorte.Location = new System.Drawing.Point(489, 101);
            this.btnNorte.Name = "btnNorte";
            this.btnNorte.Size = new System.Drawing.Size(29, 23);
            this.btnNorte.TabIndex = 19;
            this.btnNorte.Text = "-";
            this.btnNorte.UseVisualStyleBackColor = true;
            this.btnNorte.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNordeste
            // 
            this.btnNordeste.Location = new System.Drawing.Point(489, 146);
            this.btnNordeste.Name = "btnNordeste";
            this.btnNordeste.Size = new System.Drawing.Size(29, 23);
            this.btnNordeste.TabIndex = 20;
            this.btnNordeste.Text = "-";
            this.btnNordeste.UseVisualStyleBackColor = true;
            // 
            // btnCentro
            // 
            this.btnCentro.Location = new System.Drawing.Point(490, 189);
            this.btnCentro.Name = "btnCentro";
            this.btnCentro.Size = new System.Drawing.Size(26, 23);
            this.btnCentro.TabIndex = 21;
            this.btnCentro.Text = "-";
            this.btnCentro.UseVisualStyleBackColor = true;
            this.btnCentro.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSudeste
            // 
            this.btnSudeste.Location = new System.Drawing.Point(488, 233);
            this.btnSudeste.Name = "btnSudeste";
            this.btnSudeste.Size = new System.Drawing.Size(28, 23);
            this.btnSudeste.TabIndex = 22;
            this.btnSudeste.Text = "-";
            this.btnSudeste.UseVisualStyleBackColor = true;
            // 
            // btnSul
            // 
            this.btnSul.Location = new System.Drawing.Point(489, 279);
            this.btnSul.Name = "btnSul";
            this.btnSul.Size = new System.Drawing.Size(27, 23);
            this.btnSul.TabIndex = 23;
            this.btnSul.Text = "-";
            this.btnSul.UseVisualStyleBackColor = true;
            this.btnSul.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSul);
            this.Controls.Add(this.btnSudeste);
            this.Controls.Add(this.btnCentro);
            this.Controls.Add(this.btnNordeste);
            this.Controls.Add(this.btnNorte);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.lblSul);
            this.Controls.Add(this.lblSudeste);
            this.Controls.Add(this.lblCentro);
            this.Controls.Add(this.lblNordeste);
            this.Controls.Add(this.lblNorte);
            this.Controls.Add(this.lblEst);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSul);
            this.Controls.Add(this.cboSudeste);
            this.Controls.Add(this.cboCentro);
            this.Controls.Add(this.cboNordeste);
            this.Controls.Add(this.cboNorte);
            this.Controls.Add(this.cboLista1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLista1;
        private System.Windows.Forms.ComboBox cboNorte;
        private System.Windows.Forms.ComboBox cboNordeste;
        private System.Windows.Forms.ComboBox cboCentro;
        private System.Windows.Forms.ComboBox cboSudeste;
        private System.Windows.Forms.ComboBox cboSul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.Label lblNorte;
        private System.Windows.Forms.Label lblNordeste;
        private System.Windows.Forms.Label lblCentro;
        private System.Windows.Forms.Label lblSudeste;
        private System.Windows.Forms.Label lblSul;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnNorte;
        private System.Windows.Forms.Button btnNordeste;
        private System.Windows.Forms.Button btnCentro;
        private System.Windows.Forms.Button btnSudeste;
        private System.Windows.Forms.Button btnSul;
    }
}

