using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMundoAnimal.Source.Entidades {
    public abstract class Pessoa : Entidade {
        protected int Id;
        protected string Nome;
        protected string Sobrenome;
        protected string NomeFantasia;
        protected char Genero;
        protected string RG;
        protected string CPF;
        protected string CNPJ;
        protected DateTime Nascimento;

        protected List<Endereco> Enderecos;
        protected List<Contato> Contatos;
        protected List<Pessoa> Parentes;

        private const int NomeMaxLength = 60;
        private const int SobrenomeMaxLength = 80;
        private const List<char> Generos = new List<char>(){ 'F', 'M', 'O' }; 

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

        public string GetNomeCompleto() {
            return Nome + " " + Sobrenome;
        }
    }
}
