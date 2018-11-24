using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organ
{
    public class Fertilizante : Produto
    {
        public Fertilizante(String nome, String descricao, String marca, int quantidade, int cod_fornecedor)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Marca = marca;
            this.Quantidade = quantidade;
            this.Cod_fornecedor = cod_fornecedor;
        }
    }
}
