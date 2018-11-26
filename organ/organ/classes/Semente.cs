using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organ
{
    public class Semente
    {
        private int codigo_semente;
        private String nome;
        private String tipo_solo;
        private double acidez;
        private double incidencia_vento;
        private double incidencia_solar;
        private int quantidade;
        private String unidademedida;
        private int cod_fornecedor;

        public Semente(int codigo_semente)
        {
            this.Codigo_semente = codigo_semente;
        }

        public Semente()
        {

        }

        public Semente(String nome, String tipo_solo, double acidez, double incidencia_vento, double incidencia_solar, int quantidade, int cod_fornecedor, String unidademedida)
        {
            this.Nome = nome;
            this.Tipo_solo = tipo_solo;
            this.Acidez = acidez;
            this.Incidencia_vento = incidencia_vento;
            this.Incidencia_solar = incidencia_solar;
            this.Quantidade = quantidade;
            this.Cod_fornecedor = cod_fornecedor;
            this.UnidadeMedida = unidademedida;
        }

        public int Codigo_semente
        {
            get { return codigo_semente; }
            set { codigo_semente = value; }
        }
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public String Tipo_solo
        {
            get { return tipo_solo; }
            set { tipo_solo = value; }
        }
        public double Acidez
        {
            get { return acidez; }
            set { acidez = value; }
        }
        public double Incidencia_vento
        {
            get { return incidencia_vento; }
            set { incidencia_vento = value; }
        }
        public double Incidencia_solar
        {
            get { return incidencia_solar; }
            set { incidencia_solar = value; }
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
        public Fornecedor fornecedor { get; set; }

        public int Cod_fornecedor
        {
            get { return fornecedor.Codigo; }
            set { cod_fornecedor = fornecedor.Codigo; }
        }

        public void RegistrarSemente(Semente s)
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);

            SqlCommand cmd = new SqlCommand("SP_INSERT_SEMENTE", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@NOME_SEM", SqlDbType.VarChar).Value = s.Nome;
            cmd.Parameters.Add("@TIPO_SOLO_SEM", SqlDbType.VarChar).Value = s.Tipo_solo;
            cmd.Parameters.Add("@ACIDEZ_SEM", SqlDbType.NVarChar).Value = s.Acidez;
            cmd.Parameters.Add("@INC_VENTO_SEM", SqlDbType.NVarChar).Value = s.Incidencia_vento;
            cmd.Parameters.Add("@INC_SOLAR_SEM", SqlDbType.NVarChar).Value = s.Incidencia_solar;
            cmd.Parameters.Add("@QTD_ESTOQUE", SqlDbType.Int).Value = s.Quantidade;
            cmd.Parameters.Add("@COD_FORNECEDOR", SqlDbType.Int).Value = s.Cod_fornecedor;
            cmd.Parameters.Add("@UNIDADE_MEDIDA", SqlDbType.Char).Value = s.UnidadeMedida;

            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Semente registrada com sucesso!", "Cadastro finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro: " + e.ToString());
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public void ExcluirSemente(Semente s)
        {
            using (SqlConnection sqlCon = new SqlConnection(StringConexao.connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SP_DELETE_SEMENTE", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@COD_SEMENTE", s.Codigo_semente);
                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}
