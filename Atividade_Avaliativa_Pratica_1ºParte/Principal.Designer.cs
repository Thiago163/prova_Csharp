namespace Atividade_Avaliativa_Pratica_1ºParte
{
    partial class frmPrincipal
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
            this.btn_Gasto = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.btn_Triangulo = new System.Windows.Forms.Button();
            this.btnNavegacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Gasto
            // 
            this.btn_Gasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gasto.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gasto.Location = new System.Drawing.Point(88, 27);
            this.btn_Gasto.Name = "btn_Gasto";
            this.btn_Gasto.Size = new System.Drawing.Size(460, 90);
            this.btn_Gasto.TabIndex = 4;
            this.btn_Gasto.Text = "Gasto_Vestibulinho";
            this.btn_Gasto.UseVisualStyleBackColor = true;
            this.btn_Gasto.Click += new System.EventHandler(this.Btn_Gasto_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.FlatAppearance.BorderSize = 4;
            this.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnSair.Location = new System.Drawing.Point(232, 435);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(167, 68);
            this.BtnSair.TabIndex = 15;
            this.BtnSair.Text = "&Voltar";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btn_Triangulo
            // 
            this.btn_Triangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Triangulo.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Triangulo.Location = new System.Drawing.Point(88, 171);
            this.btn_Triangulo.Name = "btn_Triangulo";
            this.btn_Triangulo.Size = new System.Drawing.Size(460, 90);
            this.btn_Triangulo.TabIndex = 16;
            this.btn_Triangulo.Text = "Triangulo";
            this.btn_Triangulo.UseVisualStyleBackColor = true;
            this.btn_Triangulo.Click += new System.EventHandler(this.Btn_Triangulo_Click);
            // 
            // btnNavegacao
            // 
            this.btnNavegacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavegacao.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavegacao.Location = new System.Drawing.Point(88, 311);
            this.btnNavegacao.Name = "btnNavegacao";
            this.btnNavegacao.Size = new System.Drawing.Size(460, 90);
            this.btnNavegacao.TabIndex = 17;
            this.btnNavegacao.Text = "Navegação";
            this.btnNavegacao.UseVisualStyleBackColor = true;
            this.btnNavegacao.Click += new System.EventHandler(this.BtnNavegacao_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 535);
            this.Controls.Add(this.btnNavegacao);
            this.Controls.Add(this.btn_Triangulo);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.btn_Gasto);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Gasto;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button btn_Triangulo;
        private System.Windows.Forms.Button btnNavegacao;
    }
}

