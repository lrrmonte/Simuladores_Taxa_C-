namespace Simulador_TabelaPrice
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_vlr_tot_financ = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_coeficiente = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_parcela = new System.Windows.Forms.Label();
            this.cb_prazos = new System.Windows.Forms.ComboBox();
            this.tb_vlr_bem = new System.Windows.Forms.TextBox();
            this.tb_entrada = new System.Windows.Forms.TextBox();
            this.tb_tac = new System.Windows.Forms.TextBox();
            this.tb_taxa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulador Parcela Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor do Bem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "TAC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor Total Financiado";
            // 
            // lb_vlr_tot_financ
            // 
            this.lb_vlr_tot_financ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_vlr_tot_financ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vlr_tot_financ.Location = new System.Drawing.Point(188, 315);
            this.lb_vlr_tot_financ.Name = "lb_vlr_tot_financ";
            this.lb_vlr_tot_financ.Size = new System.Drawing.Size(148, 29);
            this.lb_vlr_tot_financ.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(357, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Prazo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(357, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Taxa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(341, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Coeficiente";
            // 
            // lb_coeficiente
            // 
            this.lb_coeficiente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_coeficiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_coeficiente.Location = new System.Drawing.Point(433, 233);
            this.lb_coeficiente.Name = "lb_coeficiente";
            this.lb_coeficiente.Size = new System.Drawing.Size(151, 27);
            this.lb_coeficiente.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(363, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Parcela";
            // 
            // lb_parcela
            // 
            this.lb_parcela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_parcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_parcela.Location = new System.Drawing.Point(433, 314);
            this.lb_parcela.Name = "lb_parcela";
            this.lb_parcela.Size = new System.Drawing.Size(149, 30);
            this.lb_parcela.TabIndex = 11;
            // 
            // cb_prazos
            // 
            this.cb_prazos.FormattingEnabled = true;
            this.cb_prazos.Items.AddRange(new object[] {
            "6",
            "9",
            "12",
            "18",
            "24",
            "30",
            "36",
            "42",
            "48",
            "54",
            "60",
            "72"});
            this.cb_prazos.Location = new System.Drawing.Point(433, 98);
            this.cb_prazos.Name = "cb_prazos";
            this.cb_prazos.Size = new System.Drawing.Size(121, 21);
            this.cb_prazos.TabIndex = 12;
            // 
            // tb_vlr_bem
            // 
            this.tb_vlr_bem.Location = new System.Drawing.Point(177, 98);
            this.tb_vlr_bem.Name = "tb_vlr_bem";
            this.tb_vlr_bem.Size = new System.Drawing.Size(100, 20);
            this.tb_vlr_bem.TabIndex = 13;
            // 
            // tb_entrada
            // 
            this.tb_entrada.Location = new System.Drawing.Point(177, 154);
            this.tb_entrada.Name = "tb_entrada";
            this.tb_entrada.Size = new System.Drawing.Size(100, 20);
            this.tb_entrada.TabIndex = 14;
            // 
            // tb_tac
            // 
            this.tb_tac.Location = new System.Drawing.Point(177, 233);
            this.tb_tac.Name = "tb_tac";
            this.tb_tac.Size = new System.Drawing.Size(100, 20);
            this.tb_tac.TabIndex = 15;
            // 
            // tb_taxa
            // 
            this.tb_taxa.Location = new System.Drawing.Point(433, 159);
            this.tb_taxa.Name = "tb_taxa";
            this.tb_taxa.Size = new System.Drawing.Size(121, 20);
            this.tb_taxa.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Image = global::Simulador_TabelaPrice.Properties.Resources.revendaMonteCar4;
            this.button1.Location = new System.Drawing.Point(619, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 99);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bt_calcular
            // 
            this.bt_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calcular.Location = new System.Drawing.Point(672, 127);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(75, 73);
            this.bt_calcular.TabIndex = 18;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpar.Location = new System.Drawing.Point(672, 219);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(75, 73);
            this.bt_limpar.TabIndex = 19;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.Location = new System.Drawing.Point(672, 315);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(75, 71);
            this.bt_sair.TabIndex = 20;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_taxa);
            this.Controls.Add(this.tb_tac);
            this.Controls.Add(this.tb_entrada);
            this.Controls.Add(this.tb_vlr_bem);
            this.Controls.Add(this.cb_prazos);
            this.Controls.Add(this.lb_parcela);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb_coeficiente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_vlr_tot_financ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revenda Monte Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_vlr_tot_financ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_coeficiente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_parcela;
        private System.Windows.Forms.ComboBox cb_prazos;
        private System.Windows.Forms.TextBox tb_vlr_bem;
        private System.Windows.Forms.TextBox tb_entrada;
        private System.Windows.Forms.TextBox tb_tac;
        private System.Windows.Forms.TextBox tb_taxa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_sair;
    }
}

