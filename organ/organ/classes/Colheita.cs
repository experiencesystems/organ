using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organ
{
    public class Colheita
    {
        private int qtd_colheita;
        private int codigo;

        public Plantio plantio { get; set; }

        public Colheita(int codigo)
        {
            this.Codigo = codigo;
        }

        public Colheita(int qtd_colheita, String data_colheita, int cod_plantio)
        {
            this.Qtd_colheita = qtd_colheita;
            plantio.Data_colheita = data_colheita;
            plantio.Cod_plantio = cod_plantio;
        }

        public int Codigo
        {
            get { return plantio.Cod_plantio; }
            set { codigo = plantio.Cod_plantio; }
        }

        public int Qtd_colheita
        {
            get { return qtd_colheita; }
            set { qtd_colheita = value; }
        }

        public void RealizarColheita(Colheita c)
        {

        }

        public void RepetirColheita(Colheita c)
        {

        }

        public void ExcluirColheita(Colheita c)
        {
            using (SqlConnection sqlCon = new SqlConnection(StringConexao.connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SP_DELETE_COLHEITA", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@COD_COLHEITA", c.Codigo);
                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}
