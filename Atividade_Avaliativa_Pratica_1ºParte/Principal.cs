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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Btn_Gasto_Click(object sender, EventArgs e)
        {
            frmGasto_Vestibulinho frmgasto_vestibulinho = new frmGasto_Vestibulinho();
            frmgasto_vestibulinho.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            //fApplication.Exit()
        }

        private void Btn_Triangulo_Click(object sender, EventArgs e)
        {
            frmTriangulo frmtriangulo = new frmTriangulo();
            frmtriangulo.Show();
        }

        private void BtnNavegacao_Click(object sender, EventArgs e)
        {
            frmNavegacao frmnavegacao = new frmNavegacao();
            frmnavegacao.Show();
        }
    }
}
