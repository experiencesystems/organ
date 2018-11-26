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
    public class Maquina : Produto
    {
        public Maquina(int codigo)
        {
            this.Codigo = codigo;
        }

        public Fornecedor fornecedor { get; set; }

        public Maquina(String nome, String descricao, String marca, int quantidade, int cod_fornecedor, String unidademedida)
        {
            fornecedor = new Fornecedor();
            this.Nome = nome;
            this.Descricao = descricao;
            this.Marca = marca;
            this.Quantidade = quantidade;
            fornecedor.Codigo_fornecedor = cod_fornecedor;
            this.UnidadeMedida = unidademedida;
        }

        public void RegistrarMaquina(Maquina m)
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);

            SqlCommand cmd = new SqlCommand("SP_INSERT_MAQUINA", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@NOME_MAQ", SqlDbType.VarChar).Value = m.Nome;
            cmd.Parameters.Add("@DESC_MAQ", SqlDbType.VarChar).Value = m.Descricao;
            cmd.Parameters.Add("@MARCA_MAQ", SqlDbType.VarChar).Value = m.Marca;
            cmd.Parameters.Add("@COD_FORNECEDOR", SqlDbType.Int).Value = fornecedor.Codigo_fornecedor;
            cmd.Parameters.Add("@QTD_ESTOQUE", SqlDbType.Int).Value = m.Quantidade;
            cmd.Parameters.Add("@UNIDADE_MEDIDA", SqlDbType.Char).Value = m.UnidadeMedida;

            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Máquina registrada com sucesso!", "Cadastro finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void ExcluirMaquina(Maquina m)
        {
            using (SqlConnection sqlCon = new SqlConnection(StringConexao.connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SP_DELETE_MAQUINA", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@COD_MAQUINA", m.Codigo);
                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}
