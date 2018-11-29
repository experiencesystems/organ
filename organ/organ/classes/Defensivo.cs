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
        public Defensivo(int codigo)
        {
            this.Codigo = codigo;
        }

        public Doenca doenca { get; set; }
        public Praga praga { get; set; }
        public Fornecedor fornecedor { get; set; }

        public Defensivo(String nome, String descricao, String marca, int cod_doenca, int cod_praga, int cod_fornecedor, int quantidade, String unidademedida)
        {
            doenca = new Doenca();
            praga = new Praga();
            fornecedor = new Fornecedor();
            this.Nome = nome;
            this.Descricao = descricao;
            this.Marca = marca;
            doenca.Codigo_doenca = cod_doenca;
            praga.Codigo_praga = cod_doenca;
            fornecedor.Codigo_fornecedor = cod_fornecedor;
            this.Quantidade = quantidade;
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

            if (doenca.Codigo_doenca != -1)
            {
                cmd.Parameters.Add("@COD_DOENCA", SqlDbType.Int).Value = doenca.Codigo_doenca;
            }
            else if (doenca.Codigo_doenca == -1)
            {
                cmd.Parameters.Add("@COD_DOENCA", SqlDbType.Int).Value = DBNull.Value;
            }

            if (praga.Codigo_praga != -1)
            {
                cmd.Parameters.Add("@COD_PRAGA", SqlDbType.Int).Value = praga.Codigo_praga;
            }
            else if (praga.Codigo_praga == -1)
            {
                cmd.Parameters.Add("@COD_PRAGA", SqlDbType.Int).Value = DBNull.Value;
            }

            if (fornecedor.Codigo_fornecedor != -1)
            {
                cmd.Parameters.Add("@COD_FORNECEDOR", SqlDbType.Int).Value = fornecedor.Codigo_fornecedor;
            }
            else if (fornecedor.Codigo_fornecedor == -1)
            {
                cmd.Parameters.Add("@COD_FORNECEDOR", SqlDbType.Int).Value = DBNull.Value;
            }
            
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
