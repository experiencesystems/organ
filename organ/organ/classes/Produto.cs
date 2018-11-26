﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organ
{
    public class Produto
    {
        private int codigo;
        private String nome;
        private String descricao;
        private String marca;
        private int quantidade;
        public String unidademedida;
        private int cod_fornecedor;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
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

        public String UnidadeMedida
        {
            get { return unidademedida; }
            set { unidademedida = value; }
        }

        // perguntar pra aline

        public Fornecedor fornecedor { get; set; }
        
        public int Cod_fornecedor
        {
            get { return fornecedor.Codigo; }
            set { cod_fornecedor = fornecedor.Codigo; }
        }
    }
}
