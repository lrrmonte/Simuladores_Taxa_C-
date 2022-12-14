using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Simulador_TabelaPrice
{
    public partial class Form1 : Form
    {
        double vlr_bem, entrada, tac, vlr_financ, taxa, coeficiente, parcela;
        int prazo;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {

            converter();

            vlr_financ = (vlr_bem - entrada) + tac;

            lb_vlr_tot_financ.Text = vlr_financ.ToString();

            coeficiente = Financial.Pmt((taxa / 100), prazo, -100) / 100;

            parcela = Financial.Pmt((taxa / 100), prazo, -vlr_financ);

            lb_coeficiente.Text = (Math.Round(coeficiente, 5).ToString());

            lb_parcela.Text = (Math.Round(parcela, 2).ToString());

        }
        private void converter()
        {
            try
            {
                vlr_bem = Convert.ToDouble(tb_vlr_bem.Text);
                entrada = Convert.ToDouble(tb_entrada.Text);
                tac = Convert.ToDouble(tb_tac.Text);
                prazo = Convert.ToInt32(cb_prazos.Text);
                taxa = Convert.ToDouble(tb_taxa.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            limpar();
            tb_vlr_bem.Focus();
        }
        private void limpar()
        {
            tb_vlr_bem.Clear();
            tb_entrada.Clear();
            tb_tac.Clear();
            tb_taxa.Clear();
            lb_vlr_tot_financ.ResetText();
            lb_coeficiente.ResetText();
            lb_parcela.ResetText();
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

    
