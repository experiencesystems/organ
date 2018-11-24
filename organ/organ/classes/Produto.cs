using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organ
{
    public class Produto
    {
        private String nome;
        private String descricao;
        private String marca;
        private int quantidade;
        private int cod_fornecedor;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        public int Cod_fornecedor
        {
            get { return cod_fornecedor; }
            set { cod_fornecedor = value; }
        }
    }
}
