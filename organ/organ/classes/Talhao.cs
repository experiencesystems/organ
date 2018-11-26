using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organ
{
    public class Talhao
    {
        private int codigo;
        private String nome_talhao;
        private String tipo_solo;
        private int tamanho;
        private double incidencia_solar;
        private double incidencia_vento;
        private double acidez;
        private bool disponibilidade;
        
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public String Nome_talhao
        {
            get { return nome_talhao; }
            set { nome_talhao = value; }
        }
        public String Tipo_solo
        {
            get { return tipo_solo; }
            set { tipo_solo = value; }
        }
        public int Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
        public double Incidencia_solar
        {
            get { return incidencia_solar; }
            set { incidencia_solar = value; }
        }
        public double Incidencia_vento
        {
            get { return incidencia_vento; }
            set { incidencia_vento = value; }
        }
        public double Acidez
        {
            get { return acidez; }
            set { acidez = value; }
        }
        public bool Disponibilidade
        {
            get { return disponibilidade; }
            set { disponibilidade = value; }
        }

        public Talhao(int codigo)
        {
            this.Codigo = codigo;
        }

        public Talhao(String nome_talhao, int tamanho, double incidencia_solar, double incidencia_vento, double acidez, bool disponibilidade)
        {
            this.Nome_talhao = nome_talhao;
            this.Tamanho = tamanho;
            this.Incidencia_solar = incidencia_solar;
            this.Incidencia_vento = incidencia_vento;
            this.Acidez = acidez;
            this.Disponibilidade = disponibilidade;
        }
    }
}
