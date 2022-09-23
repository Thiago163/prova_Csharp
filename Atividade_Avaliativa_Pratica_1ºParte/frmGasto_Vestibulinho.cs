using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Avaliativa_Pratica_1ºParte
{
    public partial class frmGasto_Vestibulinho : Form
    {
        public frmGasto_Vestibulinho()
        {
            InitializeComponent();
        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            int inscricoes, fiscais, alimentacao, calculo;
            inscricoes = Convert.ToInt32(txt_incricoes.Text);
            fiscais = Convert.ToInt32(txt_fiscais.Text);
            alimentacao = Convert.ToInt32(txt_alimentacao.Text);

            calculo = (inscricoes - (fiscais * 70) - alimentacao);

            //Saída
            lbl_Resultado.Text = "Sobrou " + calculo;
            MessageBox.Show("Sobrou " + calculo, "Resultado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            //fApplication.Exit()
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txt_alimentacao.Clear();
            txt_fiscais.Text = String.Empty;
            txt_incricoes.Clear();
        }
    }
}
