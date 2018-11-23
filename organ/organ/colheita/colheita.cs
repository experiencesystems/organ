using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace organ
{
    public partial class colheita : UserControl
    {
        Label[] labels = new Label[11];
        Label[] labels2 = new Label[11];

        public colheita()
        {
            InitializeComponent();
        }

        private void colheita_Load(object sender, EventArgs e)
        {
            PreencherCamposSementeData(labels, labels2);
            CalcularBarraProgresso();
        }

        void PreencherCamposSementeData(Label[] labels, Label[] labels2)
        {

            labels[0] = lblNomeSemente1;
            labels[1] = lblNomeSemente2;
            labels[2] = lblNomeSemente3;
            labels[3] = lblNomeSemente4;
            labels[4] = lblNomeSemente5;
            labels[5] = lblNomeSemente6;
            labels[6] = lblNomeSemente7;
            labels[7] = lblNomeSemente8;
            labels[8] = lblNomeSemente9;
            labels[9] = lblNomeSemente10;
            labels[10] = lblNomeSemente11;

            string cmdNS;

            labels2[0] = lblDataColheita1;
            labels2[1] = lblDataColheita2;
            labels2[2] = lblDataColheita3;
            labels2[3] = lblDataColheita4;
            labels2[4] = lblDataColheita5;
            labels2[5] = lblDataColheita6;
            labels2[6] = lblDataColheita7;
            labels2[7] = lblDataColheita8;
            labels2[8] = lblDataColheita9;
            labels2[9] = lblDataColheita10;
            labels2[10] = lblDataColheita11;

            string cmdDC;

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    SqlConnection con = new SqlConnection(StringConexao.connectionString);
                    con.Open();
                    i = i + 1; //Aqui eu somei 1 porque tem que ser respectivo ao talhão de 1 a 11, e não existe talhão 0.
                    cmdNS = "SELECT S.nome_sem FROM tbPlantio P INNER JOIN tbSemente S ON P.cod_semente = S.cod_semente WHERE cod_talhao = " + i + ";";
                    SqlCommand comNS = new SqlCommand(cmdNS, con);
                    SqlDataReader readerNS = comNS.ExecuteReader();

                    if (readerNS.Read()) //Se não colocasse aqui dava erro (se o reader ler algo, executa isso)
                    {
                        i = i - 1;
                        labels[i].Text = readerNS["nome_sem"].ToString();
                        readerNS.Close(); //Tem que fechar um reader para abrir outro

                        i = i + 1; //Como tinha subtraído na linha de cima, soma de novo (mesmo esquema do primeiro comentário)
                        cmdDC = "SELECT data_colheita FROM tbPlantio WHERE cod_talhao = " + i + ";";
                        SqlCommand comDC = new SqlCommand(cmdDC, con);
                        SqlDataReader readerDC = comDC.ExecuteReader();

                        if (readerDC.Read())
                        {
                            i = i - 1; //Subtrai por causa do vetor (A matriz 0 é relacionada com o talhão 1, e tava
                                       //somando 1 antes, então o talhão 2 iria na label[2], que é o lblDataColheita3)
                            labels2[i].Text = Convert.ToDateTime(readerDC["data_colheita"]).ToString("dd/MM/yyyy");
                            readerDC.Close();
                        }
                    }
                    else
                    {
                        i = i - 1; //Mesmo se não ler nada faz o loop voltar ao normal
                    }
                    readerNS.Close(); //Fechar um reader para abrir outro
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        void CalcularBarraProgresso()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    int i = 1;
                    con.Open();
                    string cmdDatas = "SELECT * FROM tbPlantio WHERE cod_talhao = " + i + ";";
                    SqlCommand comData = new SqlCommand(cmdDatas, con);
                    SqlDataReader reader = comData.ExecuteReader();

                    if (reader.Read())
                    {
                        string data_colheita = reader["data_colheita"].ToString();
                        string data_inicio = reader["data_inicio"].ToString();
                        DateTime hoje = DateTime.Today;

                        //agora - começo
                        TimeSpan agoracomeco = (hoje.Subtract(Convert.ToDateTime(data_inicio)));
                        int diasAgoracomeco = agoracomeco.Days;

                        //fim - começo
                        TimeSpan fimcomeco = (Convert.ToDateTime(data_colheita).Subtract(Convert.ToDateTime(data_inicio)));
                        int diasFimcomeco = fimcomeco.Days;

                        //progressBar.Value = (int)((now - start).TotalHours / (end - start).TotalHours);

                        pbTalhao1.Minimum = 0;
                        pbTalhao1.Maximum = diasFimcomeco;
                        pbTalhao1.Value = diasAgoracomeco;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        private void btnFazerColheita2_Click(object sender, EventArgs e)
        {
            string Prompt = "A senha é obrigatória.";

            string Titulo = "www.macoratti.net";

            string Resultado = Microsoft.VisualBasic.Interaction.InputBox(Prompt, Titulo, "", -1, -1);


            /* defina senha apenas para testar. */

            string password = "mac";


            /* verifica se o resultado é uma string vazia o que indica que foi cancelado. */

            if (Resultado != "")

            {

                Resultado = Resultado.TrimStart();

                /* Verifica se a senha confere. */

                if (Resultado != password)

                {

                    MessageBox.Show("Senha Incorreta.");

                }

                else

                {

                    MessageBox.Show("Senha válida.");

                }

            }
        }
    }
}
