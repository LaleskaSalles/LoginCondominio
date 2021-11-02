using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector.Authentication;
using MySql.Data.MySqlClient;

namespace LoginCondominio
{
    class Database
    {
        //Esse connectionString contém os parametros de segurança SslMode=none.
        System.String connectionString = "Data Source=localhost;Database=sistema_condominios;User Id=root;SslMode=none;";

        MySqlConnection connection = new MySqlConnection();

        //Esse procedimento está funcionando corretamente
        //Procedimento exclusivo para testes
        public void testeConexao()
        {
            //var connection = new MySqlConnection("Data Source=127.0.0.1;Database=sistema_condominios;User Id=root;Password=blabla;SSL Mode=Required");

            Console.WriteLine("Abrindo a conexão com o banco de dados!!!");

            try
            {
                var connection = new MySqlConnection("Data Source=localhost;Database=sistema_condominios;User Id=root;SslMode=none");
                //connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
                connection.Open();//Abre a conexão

                System.Windows.Forms.MessageBox.Show("Conexão foi um sucesso!!!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            connection.Close(); //Fecha a conexão.
        }

        //Testar esse procedimento agora
        //Procedimento de persistência de Dados
        public void inserirDados(string nomeCompleto, string dataNascimento, string cpf, string rg)
        {
            MySqlConnection mySqlConnection;
            MySqlCommand mySqlCommand; 

            try
            {
                //criação da query PLSQL, passando os parametros dentro da string
                string query = "INSERT INTO SISTEMA_CONDOMINIOS.MORADOR(NOMECOMPLETO, DATANASCIMENTO, CPF, RG)" + " VALUES('" + nomeCompleto + "','" + dataNascimento + "','" + cpf + "','" + rg + "');";

                mySqlConnection = new MySqlConnection(connectionString);//criação da query PLSQL, passando os parametros dentro da string
                mySqlCommand    = new MySqlCommand(query, mySqlConnection);//Cria o comando
                mySqlConnection.Open();

                System.Windows.Forms.MessageBox.Show("Conexão testada");

                //persistencia de dados no banco(enviando os dados)
                mySqlCommand.ExecuteReader();
                System.Windows.Forms.MessageBox.Show("Cadastrado com sucesso!");

                //Fecha a conexão
                mySqlConnection.Close();
            }
            catch(MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            } 
        }

        public void inserirDadosApartamento(string numApartamento, string numAndar)
        {
            MySqlConnection mySqlConnection;
            MySqlCommand mySqlCommand;

            try
            {
                //criação da query PLSQL, passando os parametros dentro da string
                string query = "INSERT INTO SISTEMA_CONDOMINIOS.APARTAMENTO(NUMAPARTAMENTO, NUMANDAR)" + " VALUES('" + numApartamento + "','" + numAndar + "');";

                mySqlConnection = new MySqlConnection(connectionString);//criação da query PLSQL, passando os parametros dentro da string
                mySqlCommand = new MySqlCommand(query, mySqlConnection);//Cria o comando
                mySqlConnection.Open();

                System.Windows.Forms.MessageBox.Show("Conexão testada");

                //persistencia de dados no banco(enviando os dados)
                mySqlCommand.ExecuteReader();
                System.Windows.Forms.MessageBox.Show("Cadastrado com sucesso!");

                //Fecha a conexão
                mySqlConnection.Close();
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
    }
}
