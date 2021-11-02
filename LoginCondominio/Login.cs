using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCondominio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = "Laleska";
            string senha = "123";

            login = textBoxLogin.Text;
            senha = textBoxSenha.Text;

            if (login == "" || senha == "")
            {
                System.Windows.Forms.MessageBox.Show("Preencha os campos!");
            }
            else
            { 
                if(login == "Laleska" && senha == "123")
                {
                    System.Windows.Forms.MessageBox.Show($"Bem-vindo novamente, {login}!");
                    limparCampos();

                    menu m = new menu();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Login/Senha Incorreto!");
                    limparCampos();       
                }
            }

        }

        public void limparCampos()
        {
            textBoxLogin.Clear();
            textBoxSenha.Clear();
        }

        private void bttSair_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
