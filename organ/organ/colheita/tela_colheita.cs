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

namespace organ
{
    public partial class colheita : UserControl
    {
        Label[] labels = new Label[11];
        Label[] labels2 = new Label[11];
        string data_colheita1, data_colheita2, data_colheita3, data_colheita4, data_colheita5, data_colheita6, data_colheita7, data_colheita8, data_colheita9, data_colheita10, data_colheita11;
        string data_inicio1, data_inicio2, data_inicio3, data_inicio4, data_inicio5, data_inicio6, data_inicio7, data_inicio8, data_inicio9, data_inicio10, data_inicio11;

        public colheita()
        {
            InitializeComponent();
        }

        private void colheita_Load(object sender, EventArgs e)
        {
            CarregaTudo();
        }

        void CarregaTudo()
        {
            PreencherCamposSementeData();

            CalcularBarraProgresso1();
            CalcularBarraProgresso2();
            CalcularBarraProgresso3();
            CalcularBarraProgresso4();
            CalcularBarraProgresso5();
            CalcularBarraProgresso6();
            CalcularBarraProgresso7();
            CalcularBarraProgresso8();
            CalcularBarraProgresso9();
            CalcularBarraProgresso10();
            CalcularBarraProgresso11();
        }

        //
        //  ATUALIZAR PAINÉIS
        //

        private void lblProgressoPlantios_Click(object sender, EventArgs e)
        {
            CarregaTudo();
        }

        string qtdColhida;
        int numtalhao;

        //
        //  CLIQUE NOS BOTÕES INFERIORES QUE ABREM NOVO FORM
        //

        private void btnColheitasRealizadas_Click(object sender, EventArgs e)
        {
            using (consulta_colheita _consulta_colheita = new consulta_colheita())
            {
                _consulta_colheita.ShowDialog(this);
            }
        }

        private void btnDetalhesPlantios_Click(object sender, EventArgs e)
        {
            using (consulta_plantios _consulta_plantios = new consulta_plantios())
            {
                _consulta_plantios.ShowDialog(this);
            }
        }

        //
        //  INPUTBOX
        //

        public static string InputBox(string prompt, string title, string defaultValue)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = prompt;
            ib.FormCaption = title;
            ib.DefaultValue = defaultValue;
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();

            if (s == string.Empty)
                return "";
            else
                return s;
        }

        //
        //  MÉTODO QUE CHAMA O MÉTODO COLHEITA DA CLASSE
        //
        string cmd, dataColheita;
        SqlCommand com;
        SqlDataReader reader;

        void Colheita()
        {
            DialogResult result = MessageBox.Show("Você irá repetir essa mesma colheita futuramente?", "Colheita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {//PROC REPETIR COLHEITA
                qtdColhida = InputBox("Digite quantas sacas foram colhidas.", "Colheita", "");
                if (qtdColhida != "")
                {
                    dataColheita = InputBoxData("Digite uma data para o plantio futuro.", "Colheita");
                    using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
                    {
                        con.Open();
                        try
                        {
                            cmd = "SELECT * FROM tbPlantio WHERE cod_talhao = " + numtalhao; //pega o valor do talhão declarado em cada botão
                            com = new SqlCommand(cmd, con);
                            reader = com.ExecuteReader();

                            if (reader.Read())
                            {
                                int cod_plantio = Convert.ToInt16(reader["cod_plantio"]);
                                Colheita colheita = new Colheita(Convert.ToInt32(qtdColhida), cod_plantio, dataColheita);
                                colheita.RepetirColheita(colheita);
                                reader.Close();
                            }
                            else
                            {
                                cmd = "SELECT * FROM tbPlantio WHERE cod_talhao2 = " + numtalhao; //pega o valor do talhão declarado em cada botão
                                com = new SqlCommand(cmd, con);
                                reader = com.ExecuteReader();

                                if (reader.Read())
                                {
                                    int cod_plantio = Convert.ToInt16(reader["cod_plantio"]);

                                    Colheita colheita = new Colheita(Convert.ToInt32(qtdColhida), cod_plantio, dataColheita);
                                    colheita.RepetirColheita(colheita);
                                    reader.Close();
                                }
                                else
                                {
                                    cmd = "SELECT * FROM tbPlantio WHERE cod_talhao3 = " + numtalhao; //pega o valor do talhão declarado em cada botão
                                    com = new SqlCommand(cmd, con);
                                    reader = com.ExecuteReader();

                                    if (reader.Read())
                                    {
                                        int cod_plantio = Convert.ToInt16(reader["cod_plantio"]);

                                        Colheita colheita = new Colheita(Convert.ToInt32(qtdColhida), cod_plantio, dataColheita);
                                        colheita.RepetirColheita(colheita);
                                        reader.Close();
                                    }
                                }
                            }
                        }
                        catch (SqlException e)
                        {
                            MessageBox.Show(e.Message);
                        }
                        finally
                        {
                            con.Close();
                        }   
                    }
                }
            }
            else
            {//FINALIZA A COLHEITA E NAO COLHE DNV
                qtdColhida = InputBox("Digite quantas sacas foram colhidas.", "Colheita", "");
                if (qtdColhida != "")
                {
                    using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
                    {
                        con.Open();
                        try
                        {
                            cmd = "SELECT * FROM tbPlantio WHERE cod_talhao = " + numtalhao;
                            com = new SqlCommand(cmd, con);
                            reader = com.ExecuteReader();

                            if (reader.Read())
                            {
                                int cod_plantio = Convert.ToInt16(reader["cod_plantio"]);

                                Colheita colheita = new Colheita(Convert.ToInt32(qtdColhida), cod_plantio);
                                colheita.RealizarColheita(colheita);
                                reader.Close();
                            }
                            else
                            {
                                cmd = "SELECT * FROM tbPlantio WHERE cod_talhao2 = " + numtalhao;
                                com = new SqlCommand(cmd, con);
                                reader = com.ExecuteReader();

                                if (reader.Read())
                                {
                                    int cod_plantio = Convert.ToInt16(reader["cod_plantio"]);

                                    Colheita colheita = new Colheita(Convert.ToInt32(qtdColhida), cod_plantio);
                                    colheita.RealizarColheita(colheita);
                                    reader.Close();
                                }
                                else
                                {
                                    cmd = "SELECT * FROM tbPlantio WHERE cod_talha3 = " + numtalhao;
                                    com = new SqlCommand(cmd, con);
                                    reader = com.ExecuteReader();

                                    if (reader.Read())
                                    {
                                        int cod_plantio = Convert.ToInt16(reader["cod_plantio"]);

                                        Colheita colheita = new Colheita(Convert.ToInt32(qtdColhida), cod_plantio);
                                        colheita.RealizarColheita(colheita);
                                        reader.Close();
                                    }
                                }
                            }
                        }
                        catch (SqlException e)
                        {
                            MessageBox.Show(e.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }
        
        public static string InputBoxData(string prompt, string title)
        {
            InputBoxDialogData ib = new InputBoxDialogData();
            ib.FormPrompt = prompt;
            ib.FormCaption = title;
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }

        //
        //  DECLARA OS BOTÕES PARA CADA COLHEITA
        //

        private void btnFazerColheita1_Click(object sender, EventArgs e)
        {
            numtalhao = 1;
            if (lblDataColheita1.Text != "") //vê se existe colheita
            {
                if (pbTalhao1.Value < pbTalhao1.Maximum)
                {
                    DialogResult dialog = MessageBox.Show("Você realmente deseja fazer a colheita antes da data estimada?", "Colheita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialog == DialogResult.Yes)
                    {
                        Colheita();
                    }
                }
                else
                {
                    Colheita();
                }
            }
            else
            {
                MessageBox.Show("Não existe plantio!", "Colheita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnFazerColheita2_Click(object sender, EventArgs e)
        {
            numtalhao = 2;
            if (lblDataColheita2.Text != "") //vê se existe colheita
            {
                if (pbTalhao2.Value < pbTalhao2.Maximum)
                {
                    DialogResult dialog = MessageBox.Show("Você realmente deseja fazer a colheita antes da data estimada?", "Colheita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialog == DialogResult.Yes)
                    {
                        Colheita();
                    }
                }
                else
                {
                    Colheita();
                }
            }
            else
            {
                MessageBox.Show("Não existe plantio!", "Colheita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnFazerColheita3_Click(object sender, EventArgs e)
        {
            numtalhao = 3;
            if (lblDataColheita3.Text != "") //vê se existe colheita
            {
                if (pbTalhao3.Value < pbTalhao3.Maximum)
                {
                    DialogResult dialog = MessageBox.Show("Você realmente deseja fazer a colheita antes da data estimada?", "Colheita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialog == DialogResult.Yes)
                    {
                        Colheita();
                    }
                }
                else
                {
                    Colheita();
                }
            }
            else
            {
                MessageBox.Show("Não existe plantio!", "Colheita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnFazerColheita4_Click(object sender, EventArgs e)
        {
            numtalhao = 4;
            if (lblDataColheita4.Text != "") //vê se existe colheita
            {
                if (pbTalhao4.Value < pbTalhao4.Maximum)
                {
                    DialogResult dialog = MessageBox.Show("Você realmente deseja fazer a colheita antes da data estimada?", "Colheita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialog == DialogResult.Yes)
                    {
                        Colheita();
                    }
                }
                else
                {
                    Colheita();
                }
            }
            else
            {
                MessageBox.Show("Não existe plantio!", "Colheita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnFazerColheita5_Click(object sender, EventArgs e)
        {
            numtalhao = 5;
            if (lblDataColheita5.Text != "") //vê se existe colheita
            {
                if (pbTalhao5.Value < pbTalhao5.Maximum)
                {
                    DialogResult dialog = MessageBox.Show("Você realmente deseja fazer a colheita antes da data estimada?", "Colheita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialog == DialogResult.Yes)
                    {
                        Colheita();
                    }
                }
                else
                {
                    Colheita();
                }
            }
            else
            {
                MessageBox.Show("Não existe plantio!", "Colheita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnFazerColheita6_Click(object sender, EventArgs e)
        {
            numtalhao = 6;
            if (lblDataColheita6.Text != "") //vê se existe colheita
            {
                if (pbTalhao6.Value < pbTalhao6.Maximum)
                {
                    DialogResult dialog = MessageBox.Show("Você realmente deseja fazer a colheita antes da data estimada?", "Colheita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialog == DialogResult.Yes)
                    {
                        Colheita();
                    }
                }
                else
                {
                    Colheita();
                }
            }
            else
            {
                MessageBox.Show("Não existe plantio!", "Colheita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnFazerColheita7_Click(object sender, EventArgs e)
        {
            numtalhao = 7;
            if (lblDataColheita7.Text != "") //vê se existe colheita
            {
                if (pbTalhao7.Value < pbTalhao7.Maximum)
                {
                    DialogResult dialog = MessageBox.Show("Você realmente deseja fazer a colheita antes da data estimada?", "Colheita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialog == DialogResult.Yes)
                    {
                        Colheita();
                    }
                }
                else
                {
                    Colheita();
                }
            }
            else
            {
                MessageBox.Show("Não existe plantio!", "Colheita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnFazerColheita8_Click(object sender, EventArgs e)
        {
            numtalhao = 8;
            if (lblDataColheita8.Text != "") //vê se existe colheita
            {
                if (pbTalhao8.Value < pbTalhao8.Maximum)
                {
                    DialogResult dialog = MessageBox.Show("Você realmente deseja fazer a colheita antes da data estimada?", "Colheita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialog == DialogResult.Yes)
                    {
                        Colheita();
                    }
                }
                else
                {
                    Colheita();
                }
            }
            else
            {
                MessageBox.Show("Não existe plantio!", "Colheita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnFazerColheita9_Click(object sender, EventArgs e)
        {
            numtalhao = 9;
            if (lblDataColheita9.Text != "") //vê se existe colheita
            {
                if (pbTalhao9.Value < pbTalhao9.Maximum)
                {
                    DialogResult dialog = MessageBox.Show("Você realmente deseja fazer a colheita antes da data estimada?", "Colheita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialog == DialogResult.Yes)
                    {
                        Colheita();
                    }
                }
                else
                {
                    Colheita();
                }
            }
            else
            {
                MessageBox.Show("Não existe plantio!", "Colheita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnFazerColheita10_Click(object sender, EventArgs e)
        {
            numtalhao = 10;
            if (lblDataColheita10.Text != "") //vê se existe colheita
            {
                if (pbTalhao10.Value < pbTalhao10.Maximum)
                {
                    DialogResult dialog = MessageBox.Show("Você realmente deseja fazer a colheita antes da data estimada?", "Colheita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialog == DialogResult.Yes)
                    {
                        Colheita();
                    }
                }
                else
                {
                    Colheita();
                }
            }
            else
            {
                MessageBox.Show("Não existe plantio!", "Colheita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnFazerColheita11_Click(object sender, EventArgs e)
        {
            numtalhao = 11;
            if (lblDataColheita11.Text != "") //vê se existe colheita
            {
                if (pbTalhao11.Value < pbTalhao11.Maximum)
                {
                    DialogResult dialog = MessageBox.Show("Você realmente deseja fazer a colheita antes da data estimada?", "Colheita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialog == DialogResult.Yes)
                    {
                        Colheita();
                    }
                }
                else
                {
                    Colheita();
                }
            }
            else
            {
                MessageBox.Show("Não existe plantio!", "Colheita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //
        //  MÉTODO QUE PREENCHE OS DADOS DE PLANTIOS EM PAINÉIS
        //

        void PreencherCamposSementeData()
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
            SqlCommand comNS;
            SqlDataReader readerNS;
            SqlCommand comDC;
            SqlDataReader readerDC;

            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                con.Open();
                try
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        i = i + 1; //Aqui eu somei 1 porque tem que ser respectivo ao talhão de 1 a 11, e não existe talhão 0.
                        cmdNS = "SELECT S.nome_sem FROM tbPlantio P INNER JOIN tbSemente S ON P.cod_semente = S.cod_semente WHERE cod_talhao = " + i;
                        comNS = new SqlCommand(cmdNS, con);
                        readerNS = comNS.ExecuteReader();

                        if (readerNS.Read()) //Se não colocasse aqui dava erro (se o reader ler algo, executa isso)
                        {
                            i = i - 1;
                            labels[i].Text = readerNS["nome_sem"].ToString();
                            readerNS.Close(); //Tem que fechar um reader para abrir outro

                            i = i + 1; //Como tinha subtraído na linha de cima, soma de novo (mesmo esquema do primeiro comentário)
                            cmdDC = "SELECT data_colheita FROM tbPlantio WHERE cod_talhao = " + i + ";";
                            comDC = new SqlCommand(cmdDC, con);
                            readerDC = comDC.ExecuteReader();

                            if (readerDC.Read())
                            {
                                i = i - 1; //Subtrai por causa do vetor (A matriz 0 é relacionada com o talhão 1, e tava
                                           //somando 1 antes, então o talhão 2 iria na label[2], que é o lblDataColheita3)
                                           //loop já voltou ao normal
                                labels2[i].Text = Convert.ToDateTime(readerDC["data_colheita"]).ToString("dd/MM/yyyy");
                                readerDC.Close();
                            }
                            else
                            {
                                labels2[i].Text = "";
                            }
                        }
                        else //tenta no codtalhao2
                        {//ta somado 1 já
                            cmdNS = "SELECT S.nome_sem FROM tbPlantio P INNER JOIN tbSemente S ON P.cod_semente = S.cod_semente WHERE cod_talhao2 = " + i;
                            comNS = new SqlCommand(cmdNS, con);
                            readerNS.Close();
                            readerNS = comNS.ExecuteReader();

                            if (readerNS.Read())
                            {
                                i = i - 1;
                                labels[i].Text = readerNS["nome_sem"].ToString();
                                readerNS.Close();

                                i = i + 1;
                                cmdDC = "SELECT data_colheita FROM tbPlantio WHERE cod_talhao2 = " + i + ";";
                                comDC = new SqlCommand(cmdDC, con);
                                readerDC = comDC.ExecuteReader();

                                if (readerDC.Read())
                                {
                                    i = i - 1;
                                    labels2[i].Text = Convert.ToDateTime(readerDC["data_colheita"]).ToString("dd/MM/yyyy");
                                    readerDC.Close();
                                }
                                else
                                {
                                    labels2[i].Text = "";
                                }
                            }
                            else //tenta no codtalhao3
                            {//ta somado 1 também
                                cmdNS = "SELECT S.nome_sem FROM tbPlantio P INNER JOIN tbSemente S ON P.cod_semente = S.cod_semente WHERE cod_talhao3 = " + i;
                                comNS = new SqlCommand(cmdNS, con);
                                readerNS.Close();
                                readerNS = comNS.ExecuteReader();

                                if (readerNS.Read())
                                {
                                    i = i - 1;
                                    labels[i].Text = readerNS["nome_sem"].ToString();
                                    readerNS.Close();

                                    i = i + 1;
                                    cmdDC = "SELECT data_colheita FROM tbPlantio WHERE cod_talhao3 = " + i + ";";
                                    comDC = new SqlCommand(cmdDC, con);
                                    readerDC = comDC.ExecuteReader();

                                    if (readerDC.Read())
                                    {
                                        i = i - 1;
                                        labels2[i].Text = Convert.ToDateTime(readerDC["data_colheita"]).ToString("dd/MM/yyyy");
                                        readerDC.Close();
                                    }
                                    else
                                    {
                                        labels2[i].Text = "";
                                    }
                                }
                                else
                                {
                                    i = i - 1;
                                    readerNS.Close();
                                    labels[i].Text = "";
                                }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        //
        // Sim, eu também pensei em fazer um looping, PORÉM, não tem como definir vetor de ProgressBar igual eu tinha feito com as Labels :'(
        //

        //
        //  CALCULA BARRA DE PROGRESSO
        //

        void CalcularBarraProgresso1()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    con.Open();
                    string cmdDatas = "SELECT * FROM tbPlantio WHERE cod_talhao = 1";
                    SqlCommand comData = new SqlCommand(cmdDatas, con);
                    SqlDataReader reader = comData.ExecuteReader();

                    if (reader.Read())
                    {
                        data_colheita1 = reader["data_colheita"].ToString();
                        data_inicio1 = reader["data_inicio"].ToString();
                        DateTime hoje = DateTime.Today;

                        //agora - começo
                        TimeSpan agoracomeco = (hoje.Subtract(Convert.ToDateTime(data_inicio1)));
                        int diasAgoracomeco = agoracomeco.Days;

                        //fim - começo
                        TimeSpan fimcomeco = (Convert.ToDateTime(data_colheita1).Subtract(Convert.ToDateTime(data_inicio1)));
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
                finally
                {
                    con.Close();
                }
            }
        }

        void CalcularBarraProgresso2()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    con.Open();
                    string cmdDatas = "SELECT * FROM tbPlantio WHERE cod_talhao = 2";
                    SqlCommand comData = new SqlCommand(cmdDatas, con);
                    SqlDataReader reader = comData.ExecuteReader();

                    if (reader.Read())
                    {
                        data_colheita2 = reader["data_colheita"].ToString();
                        data_inicio2 = reader["data_inicio"].ToString();
                        DateTime hoje = DateTime.Today;

                        //agora - começo
                        TimeSpan agoracomeco = (hoje.Subtract(Convert.ToDateTime(data_inicio2)));
                        int diasAgoracomeco = agoracomeco.Days;

                        //fim - começo
                        TimeSpan fimcomeco = (Convert.ToDateTime(data_colheita2).Subtract(Convert.ToDateTime(data_inicio2)));
                        int diasFimcomeco = fimcomeco.Days;

                        //progressBar.Value = (int)((now - start).TotalHours / (end - start).TotalHours);

                        pbTalhao2.Minimum = 0;
                        pbTalhao2.Maximum = diasFimcomeco;
                        pbTalhao2.Value = diasAgoracomeco;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        void CalcularBarraProgresso3()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    con.Open();
                    string cmdDatas = "SELECT * FROM tbPlantio WHERE cod_talhao = 3";
                    SqlCommand comData = new SqlCommand(cmdDatas, con);
                    SqlDataReader reader = comData.ExecuteReader();

                    if (reader.Read())
                    {
                        data_colheita3 = reader["data_colheita"].ToString();
                        data_inicio3 = reader["data_inicio"].ToString();
                        DateTime hoje = DateTime.Today;

                        //agora - começo
                        TimeSpan agoracomeco = (hoje.Subtract(Convert.ToDateTime(data_inicio3)));
                        int diasAgoracomeco = agoracomeco.Days;

                        //fim - começo
                        TimeSpan fimcomeco = (Convert.ToDateTime(data_colheita3).Subtract(Convert.ToDateTime(data_inicio3)));
                        int diasFimcomeco = fimcomeco.Days;

                        //progressBar.Value = (int)((now - start).TotalHours / (end - start).TotalHours);

                        pbTalhao3.Minimum = 0;
                        pbTalhao3.Maximum = diasFimcomeco;
                        pbTalhao3.Value = diasAgoracomeco;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        void CalcularBarraProgresso4()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    con.Open();
                    string cmdDatas = "SELECT * FROM tbPlantio WHERE cod_talhao = 4";
                    SqlCommand comData = new SqlCommand(cmdDatas, con);
                    SqlDataReader reader = comData.ExecuteReader();

                    if (reader.Read())
                    {
                        data_colheita4 = reader["data_colheita"].ToString();
                        data_inicio4 = reader["data_inicio"].ToString();
                        DateTime hoje = DateTime.Today;

                        //agora - começo
                        TimeSpan agoracomeco = (hoje.Subtract(Convert.ToDateTime(data_inicio4)));
                        int diasAgoracomeco = agoracomeco.Days;

                        //fim - começo
                        TimeSpan fimcomeco = (Convert.ToDateTime(data_colheita4).Subtract(Convert.ToDateTime(data_inicio4)));
                        int diasFimcomeco = fimcomeco.Days;

                        //progressBar.Value = (int)((now - start).TotalHours / (end - start).TotalHours);

                        pbTalhao4.Minimum = 0;
                        pbTalhao4.Maximum = diasFimcomeco;
                        pbTalhao4.Value = diasAgoracomeco;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        void CalcularBarraProgresso5()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    con.Open();
                    string cmdDatas = "SELECT * FROM tbPlantio WHERE cod_talhao = 5";
                    SqlCommand cmd = new SqlCommand(cmdDatas, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        data_colheita5 = reader["data_colheita"].ToString();
                        data_inicio5 = reader["data_inicio"].ToString();
                        DateTime hoje = DateTime.Today;

                        //agora - começo
                        TimeSpan agoracomeco = (hoje.Subtract(Convert.ToDateTime(data_inicio5)));
                        int diasAgoracomeco = agoracomeco.Days;

                        //fim - começo
                        TimeSpan fimcomeco = (Convert.ToDateTime(data_colheita5).Subtract(Convert.ToDateTime(data_inicio5)));
                        int diasFimcomeco = fimcomeco.Days;

                        //progressBar.Value = (int)((now - start).TotalHours / (end - start).TotalHours);

                        pbTalhao5.Minimum = 0;
                        pbTalhao5.Maximum = diasFimcomeco;
                        pbTalhao5.Value = diasAgoracomeco;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        void CalcularBarraProgresso6()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    con.Open();
                    string cmdDatas = "SELECT * FROM tbPlantio WHERE cod_talhao = 6";
                    SqlCommand comData = new SqlCommand(cmdDatas, con);
                    SqlDataReader reader = comData.ExecuteReader();

                    if (reader.Read())
                    {
                        data_colheita6 = reader["data_colheita"].ToString();
                        data_inicio6 = reader["data_inicio"].ToString();
                        DateTime hoje = DateTime.Today;

                        //agora - começo
                        TimeSpan agoracomeco = (hoje.Subtract(Convert.ToDateTime(data_inicio6)));
                        int diasAgoracomeco = agoracomeco.Days;

                        //fim - começo
                        TimeSpan fimcomeco = (Convert.ToDateTime(data_colheita6).Subtract(Convert.ToDateTime(data_inicio6)));
                        int diasFimcomeco = fimcomeco.Days;

                        //progressBar.Value = (int)((now - start).TotalHours / (end - start).TotalHours);

                        pbTalhao6.Minimum = 0;
                        pbTalhao6.Maximum = diasFimcomeco;
                        pbTalhao6.Value = diasAgoracomeco;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        void CalcularBarraProgresso7()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    con.Open();
                    string cmdDatas = "SELECT * FROM tbPlantio WHERE cod_talhao = 7";
                    SqlCommand comData = new SqlCommand(cmdDatas, con);
                    SqlDataReader reader = comData.ExecuteReader();

                    if (reader.Read())
                    {
                        data_colheita7 = reader["data_colheita"].ToString();
                        data_inicio7 = reader["data_inicio"].ToString();
                        DateTime hoje = DateTime.Today;

                        //agora - começo
                        TimeSpan agoracomeco = (hoje.Subtract(Convert.ToDateTime(data_inicio7)));
                        int diasAgoracomeco = agoracomeco.Days;

                        //fim - começo
                        TimeSpan fimcomeco = (Convert.ToDateTime(data_colheita7).Subtract(Convert.ToDateTime(data_inicio7)));
                        int diasFimcomeco = fimcomeco.Days;

                        //progressBar.Value = (int)((now - start).TotalHours / (end - start).TotalHours);

                        pbTalhao7.Minimum = 0;
                        pbTalhao7.Maximum = diasFimcomeco;
                        pbTalhao7.Value = diasAgoracomeco;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        void CalcularBarraProgresso8()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    con.Open();
                    string cmdDatas = "SELECT * FROM tbPlantio WHERE cod_talhao = 8";
                    SqlCommand comData = new SqlCommand(cmdDatas, con);
                    SqlDataReader reader = comData.ExecuteReader();

                    if (reader.Read())
                    {
                        data_colheita8 = reader["data_colheita"].ToString();
                        data_inicio8 = reader["data_inicio"].ToString();
                        DateTime hoje = DateTime.Today;

                        //agora - começo
                        TimeSpan agoracomeco = (hoje.Subtract(Convert.ToDateTime(data_inicio8)));
                        int diasAgoracomeco = agoracomeco.Days;

                        //fim - começo
                        TimeSpan fimcomeco = (Convert.ToDateTime(data_colheita8).Subtract(Convert.ToDateTime(data_inicio8)));
                        int diasFimcomeco = fimcomeco.Days;

                        //progressBar.Value = (int)((now - start).TotalHours / (end - start).TotalHours);

                        pbTalhao8.Minimum = 0;
                        pbTalhao8.Maximum = diasFimcomeco;
                        pbTalhao8.Value = diasAgoracomeco;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        void CalcularBarraProgresso9()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    con.Open();
                    string cmdDatas = "SELECT * FROM tbPlantio WHERE cod_talhao = 9";
                    SqlCommand comData = new SqlCommand(cmdDatas, con);
                    SqlDataReader reader = comData.ExecuteReader();

                    if (reader.Read())
                    {
                        data_colheita9 = reader["data_colheita"].ToString();
                        data_inicio9 = reader["data_inicio"].ToString();
                        DateTime hoje = DateTime.Today;

                        //agora - começo
                        TimeSpan agoracomeco = (hoje.Subtract(Convert.ToDateTime(data_inicio9)));
                        int diasAgoracomeco = agoracomeco.Days;

                        //fim - começo
                        TimeSpan fimcomeco = (Convert.ToDateTime(data_colheita9).Subtract(Convert.ToDateTime(data_inicio9)));
                        int diasFimcomeco = fimcomeco.Days;

                        //progressBar.Value = (int)((now - start).TotalHours / (end - start).TotalHours);

                        pbTalhao9.Minimum = 0;
                        pbTalhao9.Maximum = diasFimcomeco;
                        pbTalhao9.Value = diasAgoracomeco;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        void CalcularBarraProgresso10()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    con.Open();
                    string cmdDatas = "SELECT * FROM tbPlantio WHERE cod_talhao = 10";
                    SqlCommand comData = new SqlCommand(cmdDatas, con);
                    SqlDataReader reader = comData.ExecuteReader();

                    if (reader.Read())
                    {
                        data_colheita10 = reader["data_colheita"].ToString();
                        data_inicio10 = reader["data_inicio"].ToString();
                        DateTime hoje = DateTime.Today;

                        //agora - começo
                        TimeSpan agoracomeco = (hoje.Subtract(Convert.ToDateTime(data_inicio10)));
                        int diasAgoracomeco = agoracomeco.Days;

                        //fim - começo
                        TimeSpan fimcomeco = (Convert.ToDateTime(data_colheita10).Subtract(Convert.ToDateTime(data_inicio10)));
                        int diasFimcomeco = fimcomeco.Days;

                        //progressBar.Value = (int)((now - start).TotalHours / (end - start).TotalHours);

                        pbTalhao10.Minimum = 0;
                        pbTalhao10.Maximum = diasFimcomeco;
                        pbTalhao10.Value = diasAgoracomeco;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        void CalcularBarraProgresso11()
        {
            using (SqlConnection con = new SqlConnection(StringConexao.connectionString))
            {
                try
                {
                    con.Open();
                    string cmdDatas = "SELECT * FROM tbPlantio WHERE cod_talhao = 11";
                    SqlCommand comData = new SqlCommand(cmdDatas, con);
                    SqlDataReader reader = comData.ExecuteReader();

                    if (reader.Read())
                    {
                        data_colheita11 = reader["data_colheita"].ToString();
                        data_inicio11 = reader["data_inicio"].ToString();
                        DateTime hoje = DateTime.Today;

                        //agora - começo
                        TimeSpan agoracomeco = (hoje.Subtract(Convert.ToDateTime(data_inicio11)));
                        int diasAgoracomeco = agoracomeco.Days;

                        //fim - começo
                        TimeSpan fimcomeco = (Convert.ToDateTime(data_colheita11).Subtract(Convert.ToDateTime(data_inicio11)));
                        int diasFimcomeco = fimcomeco.Days;

                        //progressBar.Value = (int)((now - start).TotalHours / (end - start).TotalHours);

                        pbTalhao11.Minimum = 0;
                        pbTalhao11.Maximum = diasFimcomeco;
                        pbTalhao11.Value = diasAgoracomeco;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
