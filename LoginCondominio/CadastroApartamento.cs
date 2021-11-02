using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginCondominio
{
    public partial class CadastroApartamento : Form
    {
        public CadastroApartamento()
        {
            InitializeComponent();
        }

        private void bttSair_Click(object sender, EventArgs e)
        {
            Close(); 
            Application.Exit();
        }

        private void bttCadastrar_Click(object sender, EventArgs e)
        {
            System.String numApartamento;
            System.String numAndar;

            numApartamento = text_NumApartamento.Text;
            numAndar = Text_NumAndar.Text;

            Database database = new Database();

            database.inserirDadosApartamento(numApartamento, numAndar);
            limparCampos();
        }

        public void limparCampos()
        {
            text_NumApartamento.Clear();
            Text_NumAndar.Clear();
        }
    }
}
