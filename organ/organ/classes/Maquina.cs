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
        public Maquina(String nome, String descricao, String marca, int quantidade, int cod_fornecedor)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Marca = marca;
            this.Quantidade = quantidade;
            this.Cod_fornecedor = cod_fornecedor;
        }

        public void RegistrarMaquina(Maquina m)
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);

            SqlCommand cmd = new SqlCommand("SP_INSERT_MAQUINA", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@NOME", SqlDbType.VarChar).Value = m.Nome;
            cmd.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = m.Descricao;
            cmd.Parameters.Add("@MARCA", SqlDbType.VarChar).Value = m.Marca;
            cmd.Parameters.Add("@QUANTIDADE", SqlDbType.Int).Value = m.Quantidade;
            cmd.Parameters.Add("@COD_FORNECEDOR", SqlDbType.Int).Value = m.Cod_fornecedor;

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
    }
}
