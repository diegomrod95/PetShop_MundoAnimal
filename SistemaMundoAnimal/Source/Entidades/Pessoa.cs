using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMundoAnimal.Source.Dados.Tipos;

namespace SistemaMundoAnimal.Source.Entidades {
    public abstract class Pessoa : Entidade {
        protected int Id;
        protected string Nome;
        protected string Sobrenome;
        protected string NomeFantasia;
        protected char Genero;
        protected TipoRG RG;
        protected TipoCPF CPF;
        protected TipoCNPJ CNPJ;
        protected DateTime Nascimento;

        protected List<Endereco> Enderecos;
        protected List<Contato> Contatos;
        protected List<Pessoa> Parentes;

        private const int NomeMaxLength = 60;
        private const int SobrenomeMaxLength = 80;
        private List<char> Generos = new List<char>(){ 'F', 'M', 'O' };

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

        #endregion

        public string GetNomeCompleto() {
            return Nome + " " + Sobrenome;
        }
    }
}
