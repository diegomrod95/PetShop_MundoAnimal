using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados.Tipos;

namespace SistemaMundoAnimal.Source.Entidades {
    public class Produto : Entidade {
        private int Id;
        private string Nome;
        private TipoCodigo Codigo;
        private TipoTamanho Tamanho;
        private TipoPeso Peso;
        private TipoMedida Medida;
        private string Descricao;
        private string Especificacoes;

        private List<Categoria> Categorias;
        private List<Fornecedor> Fornecedores;
        private List<Fabricante> Fabricantes;

        private int NomeMaxLength = 150;
        private int DescricaoMaxLength = 1000;

        #region Getters e Setters
        public int GetId() {
            return this.Id;
        }

        public void SetId(int id) {
            if (id > 0) {
                this.Id = id;
            } else {
                throw new ArgumentException(id + " não é um id válido.");
            }   
        }

        public string GetNome() {
            return this.Nome;
        }

        public void SetNome(string nome) {
            if (nome.Length < NomeMaxLength) {
                this.Nome = nome;
            } else {
                throw new ArgumentException(nome + " não é um nome válido.");
            }
        }

        public void SetCodigo() {
            this.Codigo = new TipoCodigo(TipoCodigo.GerarCodigo());
        }

        public string GetCodigo() {
            return this.Codigo.ToString();
        }

        public void SetTamanho(double tamanho) {
            if (tamanho > 0) {
                this.Tamanho = new TipoTamanho(tamanho);
            } else {
                throw new ArgumentException(tamanho + " não é tamanho válido.");
            }
        }

        public string GetTamanho() {
            return this.Tamanho.ToString();
        }

        public void SetPeso(double peso) {
            if (peso > 0) {
                this.Peso = new TipoPeso(peso);
            } else {
                throw new ArgumentException(peso + " não é peso válido.");    
            }
        }

        public void SetMedida(string medida) {
            if (TipoMedida.ValidarMedida(medida)) {
                this.Medida = new TipoMedida(medida);
            } else {
                throw new ArgumentException(medida + " não é uma medida válida.");
            }
        }

        public string GetMedida() {
            return this.Medida.ToString();
        }

        public void SetDescricao(string descricao) {
            if (descricao.Length < DescricaoMaxLength) {
                this.Descricao = descricao;
            } else {
                throw new ArgumentException(descricao + " não é uma descricão válida.");    
            }
        }

        public string GetEspecificacoes() {
            return this.Especificacoes;
        }

        public void SetEspecificacoes(string especificacoes) {
            this.Especificacoes = especificacoes;
        }

        public void AddCategoria(Categoria categoria) {
            this.Categorias.Add(categoria);
        }

        public List<Categoria> GetCategorias() {
            return this.Categorias;
        }

        public void AddFabricantes(Fabricante fabricante) {
            this.Fabricantes.Add(fabricante);
        }

        public List<Fabricante> GetFabricantes() {
            return this.Fabricantes;
        }

        public void AddFornecedor(Fornecedor fornecedor) {
            this.Fornecedores.Add(fornecedor);
        }

        public List<Fornecedor> GetFornecedores() {
            return this.Fornecedores;
        }
        #endregion
    }
}
