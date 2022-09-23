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
    public partial class frmTriangulo : Form
    {
        public frmTriangulo()
        {
            InitializeComponent();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txt_Lado_A.Clear();
            txt_Lado_B.Text = String.Empty;
            txt_Lado_C.Clear();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            //fApplication.Exit()
        }

        private void Btn_Triangulo_Click(object sender, EventArgs e)
        {
            int ladoA, ladoB, ladoC;
            //atribuir valor a variável

            ladoA = int.Parse(txt_Lado_A.Text);
            ladoB = int.Parse(txt_Lado_B.Text);
            ladoC = int.Parse(txt_Lado_C.Text);
            //processamento

            if (
               (ladoA == ladoB) && (ladoA != ladoC) && (ladoC != ladoA) ||
               (ladoA != ladoB) && (ladoA == ladoC) && (ladoC != ladoA) ||
               (ladoA != ladoB) && (ladoA != ladoC) && (ladoC == ladoA)
               )
            {
                MessageBox.Show("Dois iguais");
            }

            if ((ladoA == ladoB) && (ladoA == ladoC) && (ladoC == ladoA))
            {
                MessageBox.Show("Tudo igual");
            }

            if ((ladoA != ladoB) && (ladoA != ladoC) && (ladoC != ladoA))
            {
                MessageBox.Show("Tudo diferente");
            }

        }
    }
}
