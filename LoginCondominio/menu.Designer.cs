namespace LoginCondominio
{
    partial class menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttCadastroApartamento = new System.Windows.Forms.Button();
            this.bttCadastrarVeiculo = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bttRelatorio = new System.Windows.Forms.Button();
            this.bttGraficos = new System.Windows.Forms.Button();
            this.bttFechar = new System.Windows.Forms.Button();
            this.bttCadastroMorador = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bttCadastroApartamento);
            this.panel1.Controls.Add(this.bttCadastrarVeiculo);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.bttRelatorio);
            this.panel1.Controls.Add(this.bttGraficos);
            this.panel1.Controls.Add(this.bttFechar);
            this.panel1.Controls.Add(this.bttCadastroMorador);
            this.panel1.Location = new System.Drawing.Point(14, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 252);
            this.panel1.TabIndex = 0;
            // 
            // bttCadastroApartamento
            // 
            this.bttCadastroApartamento.Location = new System.Drawing.Point(597, 37);
            this.bttCadastroApartamento.Name = "bttCadastroApartamento";
            this.bttCadastroApartamento.Size = new System.Drawing.Size(176, 28);
            this.bttCadastroApartamento.TabIndex = 7;
            this.bttCadastroApartamento.Text = "Cadastrar Apartamento";
            this.bttCadastroApartamento.UseVisualStyleBackColor = true;
            this.bttCadastroApartamento.Click += new System.EventHandler(this.bttCadastroApartamento_Click);
            // 
            // bttCadastrarVeiculo
            // 
            this.bttCadastrarVeiculo.Location = new System.Drawing.Point(597, 71);
            this.bttCadastrarVeiculo.Name = "bttCadastrarVeiculo";
            this.bttCadastrarVeiculo.Size = new System.Drawing.Size(176, 28);
            this.bttCadastrarVeiculo.TabIndex = 6;
            this.bttCadastrarVeiculo.Text = "Cadastrar Veiculo";
            this.bttCadastrarVeiculo.UseVisualStyleBackColor = true;
            this.bttCadastrarVeiculo.Click += new System.EventHandler(this.bttCadastrarVeiculo_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(597, 105);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(176, 28);
            this.button6.TabIndex = 5;
            this.button6.Text = "Definir*";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // bttRelatorio
            // 
            this.bttRelatorio.Location = new System.Drawing.Point(597, 139);
            this.bttRelatorio.Name = "bttRelatorio";
            this.bttRelatorio.Size = new System.Drawing.Size(176, 28);
            this.bttRelatorio.TabIndex = 4;
            this.bttRelatorio.Text = "Relatórios";
            this.bttRelatorio.UseVisualStyleBackColor = true;
            // 
            // bttGraficos
            // 
            this.bttGraficos.Location = new System.Drawing.Point(597, 173);
            this.bttGraficos.Name = "bttGraficos";
            this.bttGraficos.Size = new System.Drawing.Size(176, 28);
            this.bttGraficos.TabIndex = 3;
            this.bttGraficos.Text = "Gráficos";
            this.bttGraficos.UseVisualStyleBackColor = true;
            // 
            // bttFechar
            // 
            this.bttFechar.Location = new System.Drawing.Point(597, 207);
            this.bttFechar.Name = "bttFechar";
            this.bttFechar.Size = new System.Drawing.Size(176, 28);
            this.bttFechar.TabIndex = 2;
            this.bttFechar.Text = "Fechar";
            this.bttFechar.UseVisualStyleBackColor = true;
            this.bttFechar.Click += new System.EventHandler(this.bttFechar_Click);
            // 
            // bttCadastroMorador
            // 
            this.bttCadastroMorador.Location = new System.Drawing.Point(597, 3);
            this.bttCadastroMorador.Name = "bttCadastroMorador";
            this.bttCadastroMorador.Size = new System.Drawing.Size(176, 28);
            this.bttCadastroMorador.TabIndex = 0;
            this.bttCadastroMorador.Text = "Cadastrar Morador";
            this.bttCadastroMorador.UseVisualStyleBackColor = true;
            this.bttCadastroMorador.Click += new System.EventHandler(this.bttCadastroMorador_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 298);
            this.Controls.Add(this.panel1);
            this.Name = "menu";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttCadastroMorador;
        private System.Windows.Forms.Button bttCadastroApartamento;
        private System.Windows.Forms.Button bttCadastrarVeiculo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button bttRelatorio;
        private System.Windows.Forms.Button bttGraficos;
        private System.Windows.Forms.Button bttFechar;
    }
}