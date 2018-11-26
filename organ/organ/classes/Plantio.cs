using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organ
{
    public class Plantio
    {
        private int cod_plantio;
        private String nome_plantio;
        private String data_inicio;
        private String data_colheita;
        private int cod_funcionario;
        private int cod_funcionario2;
        private int cod_funcionario3;
        private int cod_semente;
        private int cod_fertilizante;
        private int cod_defensivo;
        private int cod_talhao;
        private int cod_talhao2;
        private int cod_talhao3;

        public Plantio(int cod_plantio)
        {
            this.Cod_plantio = cod_plantio;
        }

        public Plantio(String nome_plantio, String data_inicio, String data_colheita, int cod_funcionario, int cod_funcionario2, int cod_funcionario3, int cod_semente, int cod_fertilizante, int cod_defensivo, int cod_talhao, int cod_talhao2, int cod_talhao3)
        {
            this.Nome_plantio = nome_plantio;
            this.Data_inicio = data_inicio;
            this.Data_colheita = data_colheita;
            this.Cod_funcionario = cod_funcionario;
            this.Cod_funcionario2 = cod_funcionario2;
            this.Cod_funcionario3 = cod_funcionario3;
            this.Cod_semente = cod_semente;
            this.Cod_fertilizante = cod_fertilizante;
            this.Cod_defensivo = cod_defensivo;
            this.Cod_talhao = cod_talhao;
            this.Cod_talhao2 = cod_talhao2;
            this.Cod_talhao3 = cod_talhao3;
        }

        public int Cod_plantio
        {
            get { return cod_plantio; }
            set { cod_plantio = value; }
        }
        public String Nome_plantio
        {
            get { return nome_plantio; }
            set { nome_plantio = value; }
        }
        public String Data_inicio
        {
            get { return data_inicio; }
            set { data_inicio = value; }
        }
        public String Data_colheita
        {
            get { return data_colheita; }
            set { data_colheita = value; }
        }
        public int Cod_funcionario
        {
            get { return cod_funcionario; }
            set { cod_funcionario = value; }
        }
        public int Cod_funcionario2
        {
            get { return cod_funcionario2; }
            set { cod_funcionario2 = value; }
        }
        public int Cod_funcionario3
        {
            get { return cod_funcionario3; }
            set { cod_funcionario3 = value; }
        }
        public int Cod_semente
        {
            get { return cod_semente; }
            set { cod_semente = value; }
        }
        public int Cod_fertilizante
        {
            get { return cod_fertilizante; }
            set { cod_fertilizante = value; }
        }
        public int Cod_defensivo
        {
            get { return cod_defensivo; }
            set { cod_defensivo = value; }
        }
        public int Cod_talhao
        {
            get { return cod_talhao; }
            set { cod_talhao = value; }
        }
        public int Cod_talhao2
        {
            get { return cod_talhao2; }
            set { cod_talhao2 = value; }
        }
        public int Cod_talhao3
        {
            get { return cod_talhao3; }
            set { cod_talhao3 = value; }
        }

        public void ExcluirPlantio(Plantio p)
        {
            using (SqlConnection sqlCon = new SqlConnection(StringConexao.connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SP_DELETE_PLANTIO", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@COD_PLANTIO", p.Cod_plantio);
                sqlCmd.ExecuteNonQuery();
            }
        }

    }
}
