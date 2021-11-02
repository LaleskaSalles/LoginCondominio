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
using System.IO;

namespace LoginCondominio
{
    public partial class CadastrarMorador : Form
    {
        System.String connectionString = "Data Source=localhost;Database=sistema_condominios;User Id=root;SslMode=none;";

        public CadastrarMorador()
        {
            InitializeComponent();
            carregarLista(); //chama o procedimento construtor da listview
        }

        private void bttSair_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void bttCadastrar_Click(object sender, EventArgs e)
        {
            text_NomeCompleto.Enabled = true; //Toda vez que for cadastrar, habilitar
            System.String nomeCompleto;
            System.String dataNascimento;
            System.String cpf;
            System.String rg;

            nomeCompleto = text_NomeCompleto.Text;
            dataNascimento = dtNasc.Text;
            cpf = text_CPF.Text;
            rg = text_RG.Text;

            //database.inserirDados(nomeCompleto, dataNascimento, cpf, rg);


            Database database = new Database();
            //Comentei o procimento da classe Database "testeConexão", ele é exclusivo para testes
            //database.testeConexao();


            //Neste tipo de declaracao deixamos de forma encapsulada ou melhor,
            //negligenciamos o tamanho, pois, vamos assumir que não sabemos o tamanho
            //da lista. Nesse caso é "Alocação Dinâmica de Memória"
            String[] lista02 = { nomeCompleto, dataNascimento, cpf, rg };

            //Tem como criar a matriz de Strings (objetos) dessa forma
            //Dessa forma deixamos explicito o tamanho da matriz TAM 4
            //Esse tipo de alocação é "Alocação Estática de Memória"
            String[] lista = new string[4] { nomeCompleto, dataNascimento, cpf, rg };

            //SÃO ADICIONADOS A LISTA EM TEMPO DE EXECUÇÃO
            var listView = new ListViewItem(lista);//Criamos uma variavel do Tipo VAR, que pode ser qualquer tipo de dado, e adicionamos ao objeto ListView
            lsvMorador.Items.Add(listView);//listView1 é o nome do Objeto da lista


            database.inserirDados(nomeCompleto, dataNascimento, cpf, rg);
            clearCampos();
        }

        private void bttClear_Click(object sender, EventArgs e)
        {
            clearCampos();
        }

        public void clearCampos()
        {
            text_NomeCompleto.Clear();
            text_CPF.Clear();
            text_RG.Clear();
        }

        //Esse procedimento será usado para Carregar a lista com os dados vindo do Database
        public void carregarLista()
        {
            try
            {
                //Peguei prontinho do projeto do Cliente

                //Esta tudo comentado em ingles, depois, se não entender só traduzir

                //São para ATRIBUTOS DE PROPRIEDADES DA LISTA

                // Set the view to show details.
                lsvMorador.View = View.Details;
                // Allow the user to edit item text.
                lsvMorador.LabelEdit = true;
                // Allow the user to rearrange columns.
                lsvMorador.AllowColumnReorder = true;
                // Display check boxes.
                //listView1.CheckBoxes = true;
                // Select the item and subitems when selection is made.
                lsvMorador.FullRowSelect = true;
                // Display grid lines.
                lsvMorador.GridLines = true;
                // Sort the items in the list in ascending order.
                lsvMorador.Sorting = SortOrder.None;
                //Agora vamos criar o cabeçalho da lista

                //Ele adiciona os dados do cabeçalho, pegando o a string do nome do cabelho,
                //o tamnho no nosso caso 150 pixels, e o alinhamento, coloquei para centralizar
                lsvMorador.Columns.Add("NOME COMPLETO", 150, HorizontalAlignment.Center);
                lsvMorador.Columns.Add("DATA NASCIMENTO", 60, HorizontalAlignment.Center);
                lsvMorador.Columns.Add("CPF", 120, HorizontalAlignment.Center);
                lsvMorador.Columns.Add("RG", 120, HorizontalAlignment.Center);

                //Criar a conexão para carregar os dados do Database MySQL
                MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open(); //abre a conexão

                MySqlCommand cmd; //classe MYSQLCOMMAND usada para criar a plsql
                MySqlDataAdapter da; //classe usada para criar plsql adapter do banco
                DataTable dt; //para trabalhar com DataTables
                DataSet ds; //dataSets para carregamento dinamicos também

                cmd = new MySqlCommand("SELECT * FROM SISTEMA_CONDOMINIOS.MORADOR", mySqlConnection);
                da = new MySqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "MORADOR");
                mySqlConnection.Close();

                //Faz um loop carregando os dados do banco
                dt = ds.Tables["MORADOR"];
                int i;

                for (i =0; i <= dt.Rows.Count - 1; i++)
                {
                    //listView1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    lsvMorador.Items.Add(dt.Rows[i].ItemArray[1].ToString());//NOME COMPLETO
                    lsvMorador.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());//DATA NASCIMENTO
                    lsvMorador.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());//CPF
                    lsvMorador.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());//RG
                }
            }
            catch(MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }

        private void bttEditar_Click(object sender, EventArgs e)
        {
            //Vou desabilitar a alteração do dado no nome do Moradora
            text_NomeCompleto.Enabled = false; //Toda vez que for fazer alteração, travar o nome, para o usuario não mudar sem querer o nome, e dar ruim na query

            //Declara as veriaveis
            System.String nome, dataNascimento, cpf, rg;
            //Recebe os dados para fazer o UPDATE
            nome = text_NomeCompleto.Text;
            dataNascimento = dtNasc.Value.ToString("yyyy/MM/dd");
            cpf = text_CPF.Text;
            rg = text_RG.Text;

            System.Int16 id_morador = Convert.ToInt16(localizarIDMorador(nome));


            try
            {
                MySqlConnection connection;
                MySqlCommand command;

                connection = new MySqlConnection(connectionString);
                connection.Open();

                command = new MySqlCommand("UPDATE MORADOR SET NOMECOMPLETO='" + nome + "',DATANASCIMENTO='" + dataNascimento + "',CPF='" + cpf + "',RG='" + rg + "' WHERE ID_MORADOR='" + id_morador + "'", connection);
                command.ExecuteNonQuery(); //Executa a query

                System.Windows.Forms.MessageBox.Show("Dados alterados com Sucesso!!!");
                connection.Close();//fecha a conexão.

                //Agora precisamos atualizar a lista.
                //segue abaixo o codigo
                //Nossa. estou pegando os TextBox. kkkkkkkkk
                lsvMorador.SelectedItems[0].SubItems[0].Text = nome;
                lsvMorador.SelectedItems[0].SubItems[1].Text = dataNascimento;
                lsvMorador.SelectedItems[0].SubItems[2].Text = cpf;
                lsvMorador.SelectedItems[0].SubItems[3].Text = rg;

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }

        }// fim do editar

        private void lsvMorador_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void lsvMorador_Click(object sender, EventArgs e)
        {

        }

        private void lsvMorador_MouseClick(object sender, MouseEventArgs e)
        {
            text_NomeCompleto.Text = lsvMorador.SelectedItems[0].SubItems[0].Text;
            dtNasc.Value = DateTime.Parse(lsvMorador.SelectedItems[0].SubItems[1].Text); //As demais dão erro pelo formato errado

            //DateTime time = DateTime.ParseExact(listView1.SelectedItems[0].SubItems[1].Text, "yyyy/MM/dd", CultureInfo.InvariantCulture);
            //dtNascimento.Value = time;

            text_CPF.Text = lsvMorador.SelectedItems[0].SubItems[2].Text;
            text_RG.Text = lsvMorador.SelectedItems[0].SubItems[3].Text;
        }

        private System.String localizarIDMorador(string nome)
        {
            System.String id_morador;

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command;

                command = new MySqlCommand("SELECT ID_MORADOR FROM MORADOR WHERE NOMECOMPLETO='" + nome + "'", connection);
                MySqlDataReader dataReader = command.ExecuteReader();

                //Descobre o ID e aplica a atualização
                while (dataReader.Read())
                {
                    Console.WriteLine("{0}", dataReader.GetString(0));
                    //System.Windows.Forms.MessageBox.Show(dataReader.GetString(0));
                }

                //Chamar outro procedimento para fazer o UPDATE no Banco

                id_morador = dataReader.GetString(0);

                return id_morador;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }

            return null;
        }
    }
}

