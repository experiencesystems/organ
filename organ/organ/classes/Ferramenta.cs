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
        public Ferramenta(String nome, String descricao, String marca, int quantidade, int cod_fornecedor)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Marca = marca;
            this.Quantidade = quantidade;
            this.Cod_fornecedor = cod_fornecedor;
        }

        public void RegistrarFerramenta(Ferramenta f)
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);

            SqlCommand cmd = new SqlCommand("SP_INSERT_FERRAMENTA", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@NOME", SqlDbType.VarChar).Value = f.Nome;
            cmd.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = f.Descricao;
            cmd.Parameters.Add("@MARCA", SqlDbType.VarChar).Value = f.Marca;
            cmd.Parameters.Add("@QUANTIDADE", SqlDbType.Int).Value = f.Quantidade;
            cmd.Parameters.Add("@COD_FORNECEDOR", SqlDbType.Int).Value = f.Cod_fornecedor;

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
    }
}
