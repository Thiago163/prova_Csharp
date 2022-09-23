namespace Atividade_Avaliativa_Pratica_1ºParte
{
    partial class frmTriangulo
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
            this.txt_Lado_C = new System.Windows.Forms.TextBox();
            this.lbl_Lado_C = new System.Windows.Forms.Label();
            this.txt_Lado_B = new System.Windows.Forms.TextBox();
            this.lbl_Lado_B = new System.Windows.Forms.Label();
            this.txt_Lado_A = new System.Windows.Forms.TextBox();
            this.lbl_Lado_A = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.btn_Triangulo = new System.Windows.Forms.Button();
            this.grp_Resultado = new System.Windows.Forms.GroupBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.grp_Resultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Lado_C
            // 
            this.txt_Lado_C.Location = new System.Drawing.Point(38, 314);
            this.txt_Lado_C.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Lado_C.Name = "txt_Lado_C";
            this.txt_Lado_C.Size = new System.Drawing.Size(196, 20);
            this.txt_Lado_C.TabIndex = 17;
            // 
            // lbl_Lado_C
            // 
            this.lbl_Lado_C.AutoSize = true;
            this.lbl_Lado_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lado_C.Location = new System.Drawing.Point(34, 258);
            this.lbl_Lado_C.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Lado_C.Name = "lbl_Lado_C";
            this.lbl_Lado_C.Size = new System.Drawing.Size(76, 24);
            this.lbl_Lado_C.TabIndex = 16;
            this.lbl_Lado_C.Text = "Lado C";
            // 
            // txt_Lado_B
            // 
            this.txt_Lado_B.Location = new System.Drawing.Point(34, 205);
            this.txt_Lado_B.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Lado_B.Name = "txt_Lado_B";
            this.txt_Lado_B.Size = new System.Drawing.Size(196, 20);
            this.txt_Lado_B.TabIndex = 15;
            // 
            // lbl_Lado_B
            // 
            this.lbl_Lado_B.AutoSize = true;
            this.lbl_Lado_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lado_B.Location = new System.Drawing.Point(30, 151);
            this.lbl_Lado_B.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Lado_B.Name = "lbl_Lado_B";
            this.lbl_Lado_B.Size = new System.Drawing.Size(75, 24);
            this.lbl_Lado_B.TabIndex = 14;
            this.lbl_Lado_B.Text = "Lado B";
            // 
            // txt_Lado_A
            // 
            this.txt_Lado_A.Location = new System.Drawing.Point(34, 102);
            this.txt_Lado_A.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Lado_A.Name = "txt_Lado_A";
            this.txt_Lado_A.Size = new System.Drawing.Size(196, 20);
            this.txt_Lado_A.TabIndex = 13;
            // 
            // lbl_Lado_A
            // 
            this.lbl_Lado_A.AutoSize = true;
            this.lbl_Lado_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lado_A.Location = new System.Drawing.Point(30, 55);
            this.lbl_Lado_A.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Lado_A.Name = "lbl_Lado_A";
            this.lbl_Lado_A.Size = new System.Drawing.Size(76, 24);
            this.lbl_Lado_A.TabIndex = 12;
            this.lbl_Lado_A.Text = "Lado A";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.No;
            this.btnLimpar.FlatAppearance.BorderSize = 4;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpar.Location = new System.Drawing.Point(369, 301);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(167, 68);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "Li&mpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.FlatAppearance.BorderSize = 4;
            this.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnSair.Location = new System.Drawing.Point(599, 301);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(167, 68);
            this.BtnSair.TabIndex = 21;
            this.BtnSair.Text = "&Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btn_Triangulo
            // 
            this.btn_Triangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Triangulo.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Triangulo.Location = new System.Drawing.Point(360, 62);
            this.btn_Triangulo.Name = "btn_Triangulo";
            this.btn_Triangulo.Size = new System.Drawing.Size(420, 73);
            this.btn_Triangulo.TabIndex = 19;
            this.btn_Triangulo.Text = "O triangulo é ...";
            this.btn_Triangulo.UseVisualStyleBackColor = true;
            this.btn_Triangulo.Click += new System.EventHandler(this.Btn_Triangulo_Click);
            // 
            // grp_Resultado
            // 
            this.grp_Resultado.Controls.Add(this.lbl_Resultado);
            this.grp_Resultado.Location = new System.Drawing.Point(442, 165);
            this.grp_Resultado.Margin = new System.Windows.Forms.Padding(6);
            this.grp_Resultado.Name = "grp_Resultado";
            this.grp_Resultado.Padding = new System.Windows.Forms.Padding(6);
            this.grp_Resultado.Size = new System.Drawing.Size(263, 106);
            this.grp_Resultado.TabIndex = 18;
            this.grp_Resultado.TabStop = false;
            this.grp_Resultado.Text = "Sobras";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(44, 43);
            this.lbl_Resultado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(0, 13);
            this.lbl_Resultado.TabIndex = 0;
            // 
            // frmTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 418);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.btn_Triangulo);
            this.Controls.Add(this.grp_Resultado);
            this.Controls.Add(this.txt_Lado_C);
            this.Controls.Add(this.lbl_Lado_C);
            this.Controls.Add(this.txt_Lado_B);
            this.Controls.Add(this.lbl_Lado_B);
            this.Controls.Add(this.txt_Lado_A);
            this.Controls.Add(this.lbl_Lado_A);
            this.Name = "frmTriangulo";
            this.Text = "Triangulo";
            this.grp_Resultado.ResumeLayout(false);
            this.grp_Resultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Lado_C;
        private System.Windows.Forms.Label lbl_Lado_C;
        private System.Windows.Forms.TextBox txt_Lado_B;
        private System.Windows.Forms.Label lbl_Lado_B;
        private System.Windows.Forms.TextBox txt_Lado_A;
        private System.Windows.Forms.Label lbl_Lado_A;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button btn_Triangulo;
        private System.Windows.Forms.GroupBox grp_Resultado;
        private System.Windows.Forms.Label lbl_Resultado;
    }
}