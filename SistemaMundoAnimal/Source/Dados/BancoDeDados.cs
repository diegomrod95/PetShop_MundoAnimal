using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace SistemaMundoAnimal.Source.Dados {

    #region Classe BancoDeDados
    public class BancoDeDados {
        /// <summary>
        /// Nome do Banco de Dados.
        /// </summary>
        public static string NOME = "MundoAnimal_BD";

        /// <summary>
        /// Assinatura da função callback usada para ler as linhas de uma tabela retornada pelo banco de dados.
        /// </summary>
        /// <example>
        /// <code>
        /// public static TesteConsulta (string consulta, ConsultaSqlCallback callback) {
        ///     ...
        ///     var reader = command.ExecuteReader();
        ///     while (reader.Read()) {
        ///         callback(reader);
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="dados">Um leitor de linhas de tabela</param>
        public delegate void ConsultaSqlCallback (SqlDataReader dados);

        /// <summary>
        /// String com as informações referentes a conexão com o banco de dados.
        /// </summary>
        private static string StringDeConexaoSql { 
            get {
                return string.Format("Data Source=.;Initial Catalog={0};Integrated Security=True", NOME);
            }
        }

        #region Metodos Públicos de Comandos SQL
        /// <summary>
        /// Realiza um comando INSERT, UPDATE ou DELETE no banco de dados.
        /// </summary>
        /// <example>
        /// <code>
        /// private void BotaoTeste_Clicar () {
        ///     string comando = "INSERT INTO Teste([Nome]) VALUES (" + TxtNome.Text + ");"
        ///     BancoDeDados.NovoComandoSql(comando);
        /// }
        /// </code>
        /// </example>
        /// <param name="comando">Um comando sql válido</param>
        public static void NovoComandoSql(string comando) {
            using (var conexao = new SqlConnection(StringDeConexaoSql)) {
                if (conexao.State.ToString() == "Closed") { 
                    conexao.Open();
                }

                var cmd = new SqlCommand(comando, conexao);
                cmd.ExecuteNonQuery();

                conexao.Close();
            }
        }

        /// <summary>
        /// Insere uma consulta SQL do tipo SELECT no banco de dados. Para cada linha da tabela retornada pelo
        /// comando, a função callback é invocada com o reader contendo os dados da linha atual. Caso a consulta 
        /// não retorne alguma linha, a função não será invocada.
        /// </summary>
        /// <example>
        /// <code>
        /// private void BotaoTeste_Clicar () {
        ///     string comando = "SELECT * FROM [Teste] WHERE [Nome] = '" + TxtNome.Text + "';"
        ///     BancoDeDados.NovaConsulta(comando, (SqlDataReader reader) => {
        ///         TxtTelefone.Text = reader["Telefone"];
        ///         TxtEndereco.Text = reader["Endereco"];
        ///         ...
        ///     });
        /// }
        /// </code>
        /// </example>
        /// <param name="consulta">Uma consulta sql válida</param>
        /// <param name="callback">Uma função anonima que receba um SqlDataReader. Veja <see cref="BancoDeDados.ConsultaSqlCallback"/></param>
        public static void NovaConsultaSql(string consulta, ConsultaSqlCallback callback) {
            using (var conexao = new SqlConnection(StringDeConexaoSql)) {
                if (conexao.State.ToString() == "Closed") {
                    conexao.Open();
                }

                using (var command = new SqlCommand(consulta, conexao)) {
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            callback(reader);
                        }
                    }
                }

                conexao.Close();
            }
        }
        #endregion
    }
    #endregion
}
