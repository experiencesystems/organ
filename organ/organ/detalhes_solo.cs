using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organ
{
    public partial class detalhes_solo : Form
    {
        public detalhes_solo()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            PreencherDataGridView();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void PreencherDataGridView()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT cod_talhao AS [Código], nome_tal AS [Nome], tam_tal AS [Tamanho], tipo_solo_tal AS [Tipo de solo], inc_solar_tal AS [Incidência Solar], inc_vento_tal AS [Incidência do vento], acidez_tal AS [Acidez], disponivel_tal AS [Disponível] FROM tbTalhao ORDER BY cod_talhao ASC;", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvDetalhesSolo.DataSource = dtbl;
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }



        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }
    }
}

