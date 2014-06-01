using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using SistemaMundoAnimal.Source.Dados;
using SistemaMundoAnimal.Source.Entidades;

namespace SistemaMundoAnimal.Source.Pesquisa.Entidade {
    public static class PesquisaFuncionario {

        /// <summary>
        /// Filtros usado pelos metodos de pesquisa.
        /// </summary>
        public enum Filtros : int { 
            Id = 1,
            Nome,
            Sobrenome,
            Cargo,
            RG,
            CPF,
            Idade,
            IdadeMaiorQue,
            IdadeMenorQue,
            Salario,
            SalarioMaiorQue,
            SalarioMenorQue,
            DiaDePagamento
        }

        private static string SelectFuncionarioPorIdSqlQuery = @"SELECT *"
            + " FROM [View_Funcionarios] WHERE [Código da Pessoa] = {0}";

        private static string SelectFuncionarioPorCampoSqlQuery = @"SELECT *"
            + " FROM [View_Funcionarios] WHERE [{0}] LIKE '{1}%'";

        private static string SelectFuncionarioPorComparacaoSqlQuery = @"SELECT *"
            + " FROM [View_Funcionarios] WHERE [{0}] {1} {2}";

        private static string SelectFuncionarioTodos = @"SELECT * FROM [View_Funcionarios]";

        /// <summary>
        /// Recebe um ponteiro à uma entidade do tipo funcionário e um reader com informações
        /// de uma consulta completa à view View_Funcionários.
        /// </summary>
        /// <param name="funcionario">Um ponteiro para uma entidade do Tipo Funcionario</param>
        /// <param name="reader">Um SqlDataReader com informações referentes à View_Funcionários.</param>
        private static void SetFuncionario(ref Funcionario funcionario, SqlDataReader reader) {
            funcionario.SetId(Convert.ToInt32(reader["Código da Pessoa"]));
            funcionario.SetNome(reader["Nome"].ToString());
            funcionario.SetSobrenome(reader["Sobrenome"].ToString());
            funcionario.SetGenero((char)reader["Genero"]);
            funcionario.SetTipoPessoa('F');
            funcionario.SetRG(reader["RG"].ToString());
            funcionario.SetCPF(reader["CPF"].ToString());
            funcionario.SetSalario(Convert.ToDouble(reader["Salario"]));
            funcionario.SetAssitenciaMedica(Convert.ToDouble(reader["Assitencia Medica"]));
            funcionario.SetAuxilioCreche(Convert.ToDouble(reader["Auxilio Creche"]));
            funcionario.SetValeAlimentacao(Convert.ToDouble(reader["Vale Alimentacao"]));
            funcionario.SetValeTransporte(Convert.ToDouble(reader["Vale Transporte"]));
            funcionario.SetDiaPagamento(Convert.ToInt32(reader["Dia de Pagamento"]));
            funcionario.SetCargo((TipoCargo)Convert.ToInt32(reader["Codigo do Cargo"]));
        }

        /// <summary>
        /// Pesquisa um funcionario na View de Funcionarios e retorna uma entidade com os
        /// valores correspondentes.
        /// </summary>
        /// <param name="id">O id do funcionário na tabela Pessoa</param>
        /// <returns>Uma entidade do Tipo Funcionario</returns>
        public static Funcionario PorId(int id) {
            var funcionario = new Funcionario();
            var consulta = string.Format(SelectFuncionarioPorIdSqlQuery, id);

            BancoDeDados.NovaConsultaSql(consulta, (SqlDataReader reader) => {
                SetFuncionario(ref funcionario, reader);
            });

            return funcionario;
        }

        /// <summary>
        /// Faz uma consulta na view de funcionários retornando o funcionario com
        /// determinado id.
        /// </summary>
        /// <param name="id">O id do funcionário desejado</param>
        /// <param name="callback">Uma função callback que permite manipular os dados retornandos</param>
        public static void PorId(int id, BancoDeDados.ConsultaSqlCallback callback) {
            var consulta = string.Format(SelectFuncionarioPorIdSqlQuery, id);
            BancoDeDados.NovaConsultaSql(consulta, callback);
        }

        /// <summary>
        /// Faz uma consulta na view funcionarios retornando aqueles que tem nome
        /// parecido com o nome passado como argumento.
        /// </summary>
        /// <param name="nome">Nom usadao para pesquisa</param>
        /// <param name="callback">Uma função callback que permite manipular os dados retornandos</param>
        public static void PorNome(string nome, BancoDeDados.ConsultaSqlCallback callback) {
            var consulta = string.Format(SelectFuncionarioPorCampoSqlQuery, "Nome", nome);
            BancoDeDados.NovaConsultaSql(consulta, callback);
        }

        public static void PorSobrenome(string sobrenome, BancoDeDados.ConsultaSqlCallback callback) {
            var consulta = string.Format(SelectFuncionarioPorCampoSqlQuery, "Sobrenome", sobrenome);
            BancoDeDados.NovaConsultaSql(consulta, callback);
        }

        public static void PorRG(string rg, BancoDeDados.ConsultaSqlCallback callback) {
            var consulta = string.Format(SelectFuncionarioPorCampoSqlQuery, "RG", rg);
            BancoDeDados.NovaConsultaSql(consulta, callback);
        }

        public static void PorCPF(string cpf, BancoDeDados.ConsultaSqlCallback callback) {
            var consulta = string.Format(SelectFuncionarioPorCampoSqlQuery, "CPF", cpf);
            BancoDeDados.NovaConsultaSql(consulta, callback);
        }

        /// <summary>
        /// Faz uma consulta a view funcionários comparando o campo idade com o parametro passado
        /// como argumento.
        /// </summary>
        /// <param name="idade">O valor a ser comparado</param>
        /// <param name="cmp">O sinal de comparação</param>
        /// <param name="callback">Uma função callback que permite manipular os dados retornandos</param>
        public static void PorIdade(string idade, string cmp, BancoDeDados.ConsultaSqlCallback callback) {
            var consulta = string.Format(SelectFuncionarioPorComparacaoSqlQuery, "Idade", cmp, idade);
            BancoDeDados.NovaConsultaSql(consulta, callback);
        }

        /// <summary>
        /// Faz uma consulta a view funcionários comparando o campo salario com o parametro passado
        /// como argumento.
        /// </summary>
        /// <param name="idade">O valor a ser comparado</param>
        /// <param name="cmp">O sinal de comparação</param>
        /// <param name="callback">Uma função callback que permite manipular os dados retornandos</param>
        public static void PorSalario(string salario, string cmp, BancoDeDados.ConsultaSqlCallback callback) {
            var consulta = string.Format(SelectFuncionarioPorComparacaoSqlQuery, "Salario", cmp, salario);
            BancoDeDados.NovaConsultaSql(consulta, callback);
        }

        /// <summary>
        /// Faz uma consulta na view funcionários, retornando aqueles que exercem um determinado cargo.
        /// </summary>
        /// <param name="cargo">O cargo a ser pesquisado</param>
        /// <param name="callback">Uma função callback que permite manipular os dados retornandos</param>
        public static void PorCargo(string cargo, BancoDeDados.ConsultaSqlCallback callback) {
            var consulta = string.Format(SelectFuncionarioPorCampoSqlQuery, "Cargo", cargo);
            BancoDeDados.NovaConsultaSql(consulta, callback);
        }

        public static void PorDiaDePagamento(string dia, BancoDeDados.ConsultaSqlCallback callback) {
            var consulta = string.Format(SelectFuncionarioPorComparacaoSqlQuery, "Dia de Pagamento", "=", dia);
            BancoDeDados.NovaConsultaSql(consulta, callback);
        }

        /// <summary>
        /// Seleciona todos os funcionários no Banco de Dados.
        /// </summary>
        /// <param name="callback">Callback invocado a cada linha da view</param>
        public static void Todos(BancoDeDados.ConsultaSqlCallback callback) { 
            BancoDeDados.NovaConsultaSql(SelectFuncionarioTodos, callback);
        }

    }
}
