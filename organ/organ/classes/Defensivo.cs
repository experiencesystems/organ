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
        public Defensivo(String nome, String descricao, String marca, int quantidade, int cod_fornecedor)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Marca = marca;
            this.Quantidade = quantidade;
            this.Cod_fornecedor = cod_fornecedor;
        }

        public void RegistrarDefensivo(Defensivo d)
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);

            SqlCommand cmd = new SqlCommand("SP_INSERT_DEFENSIVO", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@NOME", SqlDbType.VarChar).Value = d.Nome;
            cmd.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = d.Descricao;
            cmd.Parameters.Add("@MARCA", SqlDbType.VarChar).Value = d.Marca;
            cmd.Parameters.Add("@QUANTIDADE", SqlDbType.Int).Value = d.Quantidade;
            cmd.Parameters.Add("@COD_FORNECEDOR", SqlDbType.Int).Value = d.Cod_fornecedor;

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
    }
}
