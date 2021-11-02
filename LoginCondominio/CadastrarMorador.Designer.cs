namespace LoginCondominio
{
    partial class CadastrarMorador
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
            this.dtNasc = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvMorador = new System.Windows.Forms.ListView();
            this.text_RG = new System.Windows.Forms.TextBox();
            this.text_CPF = new System.Windows.Forms.TextBox();
            this.text_NomeCompleto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttSair = new System.Windows.Forms.Button();
            this.bttCadastrar = new System.Windows.Forms.Button();
            this.bttClear = new System.Windows.Forms.Button();
            this.bttEditar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.dtNasc);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.text_RG);
            this.panel1.Controls.Add(this.text_CPF);
            this.panel1.Controls.Add(this.text_NomeCompleto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(30, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 467);
            this.panel1.TabIndex = 0;
            // 
            // dtNasc
            // 
            this.dtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNasc.Location = new System.Drawing.Point(27, 140);
            this.dtNasc.Name = "dtNasc";
            this.dtNasc.Size = new System.Drawing.Size(189, 20);
            this.dtNasc.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.lsvMorador);
            this.panel2.Location = new System.Drawing.Point(16, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 150);
            this.panel2.TabIndex = 20;
            // 
            // lsvMorador
            // 
            this.lsvMorador.HideSelection = false;
            this.lsvMorador.Location = new System.Drawing.Point(3, 3);
            this.lsvMorador.Name = "lsvMorador";
            this.lsvMorador.Size = new System.Drawing.Size(329, 144);
            this.lsvMorador.TabIndex = 0;
            this.lsvMorador.UseCompatibleStateImageBehavior = false;
            this.lsvMorador.SelectedIndexChanged += new System.EventHandler(this.lsvMorador_SelectedIndexChanged);
            this.lsvMorador.Click += new System.EventHandler(this.lsvMorador_Click);
            this.lsvMorador.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvMorador_MouseClick);
            // 
            // text_RG
            // 
            this.text_RG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_RG.Location = new System.Drawing.Point(27, 252);
            this.text_RG.Name = "text_RG";
            this.text_RG.Size = new System.Drawing.Size(189, 23);
            this.text_RG.TabIndex = 19;
            // 
            // text_CPF
            // 
            this.text_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_CPF.Location = new System.Drawing.Point(27, 196);
            this.text_CPF.Name = "text_CPF";
            this.text_CPF.Size = new System.Drawing.Size(189, 23);
            this.text_CPF.TabIndex = 18;
            // 
            // text_NomeCompleto
            // 
            this.text_NomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_NomeCompleto.Location = new System.Drawing.Point(27, 83);
            this.text_NomeCompleto.Name = "text_NomeCompleto";
            this.text_NomeCompleto.Size = new System.Drawing.Size(189, 23);
            this.text_NomeCompleto.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Condominio Tecnology";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "RG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome Completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data de Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "CPF";
            // 
            // bttSair
            // 
            this.bttSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSair.Location = new System.Drawing.Point(30, 486);
            this.bttSair.Name = "bttSair";
            this.bttSair.Size = new System.Drawing.Size(76, 28);
            this.bttSair.TabIndex = 1;
            this.bttSair.Text = "Sair";
            this.bttSair.UseVisualStyleBackColor = true;
            this.bttSair.Click += new System.EventHandler(this.bttSair_Click);
            // 
            // bttCadastrar
            // 
            this.bttCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCadastrar.Location = new System.Drawing.Point(309, 485);
            this.bttCadastrar.Name = "bttCadastrar";
            this.bttCadastrar.Size = new System.Drawing.Size(83, 29);
            this.bttCadastrar.TabIndex = 2;
            this.bttCadastrar.Text = "Cadastrar";
            this.bttCadastrar.UseVisualStyleBackColor = true;
            this.bttCadastrar.Click += new System.EventHandler(this.bttCadastrar_Click);
            // 
            // bttClear
            // 
            this.bttClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttClear.Location = new System.Drawing.Point(121, 486);
            this.bttClear.Name = "bttClear";
            this.bttClear.Size = new System.Drawing.Size(76, 28);
            this.bttClear.TabIndex = 3;
            this.bttClear.Text = "Clear";
            this.bttClear.UseVisualStyleBackColor = true;
            this.bttClear.Click += new System.EventHandler(this.bttClear_Click);
            // 
            // bttEditar
            // 
            this.bttEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttEditar.Location = new System.Drawing.Point(217, 486);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(76, 28);
            this.bttEditar.TabIndex = 4;
            this.bttEditar.Text = "Editar";
            this.bttEditar.UseVisualStyleBackColor = true;
            this.bttEditar.Click += new System.EventHandler(this.bttEditar_Click);
            // 
            // CadastrarMorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 521);
            this.Controls.Add(this.bttEditar);
            this.Controls.Add(this.bttClear);
            this.Controls.Add(this.bttCadastrar);
            this.Controls.Add(this.bttSair);
            this.Controls.Add(this.panel1);
            this.Name = "CadastrarMorador";
            this.Text = "Morador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_RG;
        private System.Windows.Forms.TextBox text_CPF;
        private System.Windows.Forms.TextBox text_NomeCompleto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bttSair;
        private System.Windows.Forms.Button bttCadastrar;
        private System.Windows.Forms.DateTimePicker dtNasc;
        private System.Windows.Forms.Button bttClear;
        private System.Windows.Forms.ListView lsvMorador;
        private System.Windows.Forms.Button bttEditar;
    }
}