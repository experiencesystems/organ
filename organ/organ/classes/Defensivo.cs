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
    public class Defensivo : Produto
    {
        private int cod_praga;
        private int cod_doenca;

        public int Cod_praga
        {
            get { return cod_praga; }
            set { cod_praga = value; }
        }
        public int Cod_doenca
        {
            get { return cod_doenca; }
            set { cod_doenca = value; }
        }

        public Defensivo(int codigo)
        {
            this.Codigo = codigo;
        }

        public Fornecedor fornecedor { get; set; }

        public Defensivo(String nome, String descricao, String marca, int quantidade, int cod_fornecedor, int cod_praga, int cod_doenca, String unidademedida)
        {
            fornecedor = new Fornecedor();
            this.Nome = nome;
            this.Descricao = descricao;
            this.Marca = marca;
            this.Quantidade = quantidade;
            fornecedor.Codigo_fornecedor = cod_fornecedor;
            this.Cod_praga = cod_praga;
            this.Cod_doenca = cod_doenca;
            this.UnidadeMedida = unidademedida;
        }

        public void RegistrarDefensivo(Defensivo d)
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);

            SqlCommand cmd = new SqlCommand("SP_INSERT_DEFENSIVO", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add("@NOME_DEF", SqlDbType.VarChar).Value = d.Nome;
            cmd.Parameters.Add("@DESC_DEF", SqlDbType.VarChar).Value = d.Descricao;
            cmd.Parameters.Add("@MARCA_DEF", SqlDbType.VarChar).Value = d.Marca;
            cmd.Parameters.Add("@COD_FORNECEDOR", SqlDbType.Int).Value = fornecedor.Codigo_fornecedor;
            cmd.Parameters.Add("@QTD_ESTOQUE", SqlDbType.Int).Value = d.Quantidade;
            cmd.Parameters.Add("@UNIDADE_MEDIDA", SqlDbType.Char).Value = d.UnidadeMedida;

            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Defensivo registrado com sucesso!", "Cadastro finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void ExcluirDefensivo(Defensivo d)
        {
            using (SqlConnection sqlCon = new SqlConnection(StringConexao.connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SP_DELETE_DEFENSIVO", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@COD_DEFENSIVO", d.Codigo);
                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}
