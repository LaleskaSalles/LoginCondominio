namespace LoginCondominio
{
    partial class CadastroApartamento
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.text_NumApartamento = new System.Windows.Forms.TextBox();
            this.Text_NumAndar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bttSair = new System.Windows.Forms.Button();
            this.bttCadastrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.text_NumApartamento);
            this.panel1.Controls.Add(this.Text_NumAndar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 351);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(18, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 130);
            this.panel2.TabIndex = 21;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(295, 124);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // text_NumApartamento
            // 
            this.text_NumApartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_NumApartamento.Location = new System.Drawing.Point(219, 75);
            this.text_NumApartamento.Name = "text_NumApartamento";
            this.text_NumApartamento.Size = new System.Drawing.Size(100, 23);
            this.text_NumApartamento.TabIndex = 20;
            // 
            // Text_NumAndar
            // 
            this.Text_NumAndar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_NumAndar.Location = new System.Drawing.Point(18, 75);
            this.Text_NumAndar.Name = "Text_NumAndar";
            this.Text_NumAndar.Size = new System.Drawing.Size(100, 23);
            this.Text_NumAndar.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nº Apartamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nº Andar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Condominio Tecnology";
            // 
            // bttSair
            // 
            this.bttSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSair.Location = new System.Drawing.Point(12, 402);
            this.bttSair.Name = "bttSair";
            this.bttSair.Size = new System.Drawing.Size(76, 28);
            this.bttSair.TabIndex = 1;
            this.bttSair.Text = "Sair";
            this.bttSair.UseVisualStyleBackColor = true;
            // 
            // bttCadastrar
            // 
            this.bttCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCadastrar.Location = new System.Drawing.Point(267, 402);
            this.bttCadastrar.Name = "bttCadastrar";
            this.bttCadastrar.Size = new System.Drawing.Size(83, 28);
            this.bttCadastrar.TabIndex = 2;
            this.bttCadastrar.Text = "Cadastrar";
            this.bttCadastrar.UseVisualStyleBackColor = true;
            this.bttCadastrar.Click += new System.EventHandler(this.bttCadastrar_Click);
            // 
            // CadastroApartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.bttCadastrar);
            this.Controls.Add(this.bttSair);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroApartamento";
            this.Text = "CadastroApartamento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_NumApartamento;
        private System.Windows.Forms.TextBox Text_NumAndar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bttSair;
        private System.Windows.Forms.Button bttCadastrar;
        private System.Windows.Forms.ListView listView1;
    }
}