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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void bttFechar_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void bttCadastroMorador_Click(object sender, EventArgs e)
        {
            CadastrarMorador morador = new CadastrarMorador();
            morador.Show();
        }

        private void bttCadastroApartamento_Click(object sender, EventArgs e)
        {
            CadastroApartamento apartamento = new CadastroApartamento();
            apartamento.Show();
        }

        private void bttCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            CadastroVeiculo veiculo = new CadastroVeiculo();
            veiculo.Show();
        }
    }
}
