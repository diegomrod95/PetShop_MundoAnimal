using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados;
using SistemaMundoAnimal.Source.Dados.Tipos;

namespace SistemaMundoAnimal.Source.Entidades {
    /// <summary>
    /// Classe abstrata que representa a entidade Pessoa, da qual outras entidades que se qualifiquem 
    /// descenderão. As entidades pessoas se encontram na tabela Pessoa, e suas extenções se encontram
    /// em tabelas detalhes, ex. Funcionário, Fornecedor.
    /// </summary>
    public abstract class Pessoa : Entidade {
        protected int Id;
        protected string Nome;
        protected string Sobrenome;
        protected string NomeFantasia;
        protected char TipoPessoa;
        protected char Genero;
        protected TipoRG RG;
        protected TipoCPF CPF;
        protected TipoCNPJ CNPJ;
        protected DateTime Nascimento;

        protected List<Endereco> Enderecos;
        protected List<Contato> Contatos;
        protected List<Parente> Parentes;

        private const int NomeMaxLength = 60;
        private const int SobrenomeMaxLength = 80;
        private const int NomeFantasiaMaxLength = 100;
        private List<char> TiposPessoa = new List<char>(){ 'F', 'J' };
        private List<char> Generos = new List<char>(){ 'F', 'M', 'O' };

        /// <summary>
        /// Query usada para inserir entidades do tipo Pessoa na tabela Pessoa no banco de dados.
        /// </summary>
        private static string InsertPessoaSqlQuery = @"INSERT INTO [Pessoa]" 
            + " ([Nome], [Sobrenome], [Nome_Fantasia], [Tipo_Pessoa], [Genero], [RG], [CPF], [CNPJ], [Nascimento])"
            + " VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');"; 

        /// <summary>
        /// Insere uma entidade do tipo pessoa no banco de dados.
        /// </summary>
        /// <param name="pessoa">Uma instancia da classe Pessoa</param>
        public static void InserirNoBancoDeDados(Pessoa pessoa) {
            string comando;
            string rg = "";
            string cpf = "";
            string cnpj = "";
            string nascimento = "";

            try {

                if (pessoa.GetTipoPessoa() == 'F') {
                    rg = pessoa.GetRG();
                    cpf = pessoa.GetCPF();
                    nascimento = pessoa.GetNascimento().ToString("d");
                } else {
                    cnpj = pessoa.GetCNPJ();
                }

                comando = string.Format(InsertPessoaSqlQuery, 
                    pessoa.GetNome(),
                    pessoa.GetSobrenome(), 
                    pessoa.GetNomeFantasia(), 
                    pessoa.GetTipoPessoa(),
                    pessoa.GetGenero(), 
                    rg, cpf, cnpj, nascimento);

                BancoDeDados.NovoComandoSql(comando);

            } catch (Exception e) {
                throw e;
            }
        }

        /// <summary>
        /// Getters e Setters públicos da classe.
        /// </summary>
        #region Entidade Getters e Setters
        public int GetId () {
            return this.Id;
        }

        public void SetId(int id) {
            if (id >= 1) {
                this.Id = id;
            } else {
                throw new ArgumentException("O id da pessoa deve ser maior que zero.");
            }
        }

        public string GetNome() {
            return this.Nome;
        }

        public void SetNome(string nome) {
            if (nome.Length < NomeMaxLength) {
                this.Nome = nome;
            } else {
                throw new ArgumentException("O nome não pode ultrapassar " + NomeMaxLength + " caracteres.");
            }
        }

        public string GetSobrenome() {
            return this.Sobrenome;
        }

        public void SetSobrenome(string sobrenome) {
            if (sobrenome.Length < SobrenomeMaxLength) {
                this.Sobrenome = sobrenome;
            } else {
                throw new ArgumentException("O sobrenome não pode ultrapassar " + SobrenomeMaxLength + " caracteres.");
            }
        }

        public string GetNomeFantasia() {
            return this.NomeFantasia;
        }

        public void SetNomeFantasia(string nomeFantasia) {
            if (nomeFantasia.Length < NomeFantasiaMaxLength) {
                this.NomeFantasia = nomeFantasia;
            } else {
                throw new ArgumentException(nomeFantasia + " não é um nome fantasia válido.");
            }
        }

        public char GetTipoPessoa() {
            return this.TipoPessoa;
        }

        public void SetTipoPessoa(char tipo) {
            if (TiposPessoa.Contains(tipo)) {
                this.TipoPessoa = tipo;
            } else {
                throw new ArgumentException(tipo + " não é um tipo de pessoa válido.");
            }
        }

        public char GetGenero() {
            return this.Genero;     
        }

        public void SetGenero(char genero) {
            if (Generos.Contains(genero)) {
                this.Genero = genero;
            } else {
                throw new ArgumentException(genero + " não é um genero válido.");    
            }   
        }

        public string GetRG() {
            return this.RG.ToString();
        }

        public void SetRG(string rg) {
            if (TipoRG.ValidarRG(rg)) {
                this.RG = new TipoRG(rg);
            } else {
                throw new ArgumentException(rg + " não é um RG válido.");
            }
        }

        public string GetCPF() {
            return this.CPF.ToString();
        }

        public void SetCPF(string cpf) {
            if (TipoCPF.ValidarCPF(cpf)) {
                this.CPF = new TipoCPF(cpf);
            } else {
                throw new ArgumentException(cpf + " não é um cpf válido.");
            }   
        }

        public string GetCNPJ() {
            return this.CNPJ.ToString();
        }

        public void SetCNPJ(string cnpj) {
            if (TipoCNPJ.ValidarCNPJ(cnpj)) {
                this.CNPJ = new TipoCNPJ(cnpj);
            } else {
                throw new ArgumentException(cnpj + " não é um cnpj válido.");
            }
        }

        public DateTime GetNascimento() {
            return this.Nascimento;
        }

        public void SetNascimento(int dia, int mes, int ano) {
            if (dia < 31 && mes < 12 && ano > 1800) {
                this.Nascimento = new DateTime(ano, mes, dia);
            } else {
                throw new ArgumentException(dia + "/" + mes + "/" + ano + " não é uma data válida!");
            }
        }

        public List<Endereco> GetEnderecos() {
            return this.Enderecos;
        }

        public void AddEndereco(Endereco endereco) {
            this.Enderecos.Add(endereco);
        }

        public List<Contato> GetContatos() {
            return this.Contatos;
        }

        public void AddContato(Contato contato) {
            this.Contatos.Add(contato);
        }

        public List<Parente> GetParentes() {
            return this.Parentes;
        }

        public void AddParente(Parente parente) {
            this.Parentes.Add(parente);
        }
        #endregion

    }
}
