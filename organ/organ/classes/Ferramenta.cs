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
    public class Ferramenta : Produto
    {
        public Ferramenta(int codigo)
        {
            this.Codigo = codigo;
        }

        public Fornecedor fornecedor { get; set; }

        public Ferramenta(String nome, String descricao, String marca, int quantidade, int cod_fornecedor, String unidademedida)
        {
            fornecedor = new Fornecedor();
            this.Nome = nome;
            this.Descricao = descricao;
            this.Marca = marca;
            this.Quantidade = quantidade;
            fornecedor.Codigo_fornecedor = cod_fornecedor;
            this.UnidadeMedida = unidademedida;
        }

        public void RegistrarFerramenta(Ferramenta f)
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);

            SqlCommand cmd = new SqlCommand("SP_INSERT_FERRAMENTA", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@NOME_FERRA", SqlDbType.VarChar).Value = f.Nome;
            cmd.Parameters.Add("@DESC_FERRA", SqlDbType.VarChar).Value = f.Descricao;
            cmd.Parameters.Add("@MARCA_FERRA", SqlDbType.VarChar).Value = f.Marca;
            cmd.Parameters.Add("@COD_FORNECEDOR", SqlDbType.Int).Value = fornecedor.Codigo_fornecedor;
            cmd.Parameters.Add("@QTD_ESTOQUE", SqlDbType.Int).Value = f.Quantidade;
            cmd.Parameters.Add("@UNIDADE_MEDIDA", SqlDbType.Char).Value = f.UnidadeMedida;

            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Ferramenta registrada com sucesso!", "Cadastro finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void ExcluirFerramenta(Ferramenta f)
        {
            using (SqlConnection sqlCon = new SqlConnection(StringConexao.connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SP_DELETE_FERRAMENTA", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@COD_FERRAMENTA", f.Codigo);
                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}
