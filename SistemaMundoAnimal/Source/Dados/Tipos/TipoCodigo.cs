using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using SistemaMundoAnimal.Source.Dados;

namespace SistemaMundoAnimal.Source.Dados.Tipos {
    public class TipoCodigo : Tipo<string> {

        private static readonly string GetTamanhoTabelaProdutos = @"SELECT COUNT(*) AS Tamanho FROM Produto";

        /// <summary>
        /// Gera uma hash code único para o produto.
        /// </summary>
        /// <returns>Retorna um string de tamanho 10</returns>
        public static string GerarCodigo() {
            string tamanho = "";

            BancoDeDados.NovaConsultaSql(GetTamanhoTabelaProdutos, (SqlDataReader reader) => {
                tamanho = reader["Tamanho"].ToString();
            });
            
            return string.Format("{0:X10}", tamanho.GetHashCode());
        }

        public TipoCodigo(string valor) {
            this.Valor = valor;
        }

        public override string ToString() {
            return this.Valor;
        }
    }
}
