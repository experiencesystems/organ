using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organ
{
    public partial class solo : UserControl
    {
        Label[] labels = new Label[11];

        public solo()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            DispCor();

        }

            void DispCor()
            {
                labels[0] = lblSolo1;
                labels[1] = lblSolo2;
                labels[2] = lblSolo3;
                labels[3] = lblSolo4;
                labels[4] = lblSolo5;
                labels[5] = lblSolo6;
                labels[6] = lblSolo7;
                labels[7] = lblSolo8;
                labels[8] = lblSolo9;
                labels[9] = lblSolo10;
                labels[10] = lblSolo11;

                string cmdNS;

                try
                {

                    for (int i = 0; i <= 10; i++)
                    {
                        SqlConnection con = new SqlConnection(StringConexao.connectionString);
                        con.Open();

                        i = i + 1; //Aqui eu somei 1 porque tem que ser respectivo ao talhão de 1 a 11, e não existe talhão 0.
                        cmdNS = "select disponivel_tal from tbTalhao where cod_talhao = " + i + ";";
                        SqlCommand disptal = new SqlCommand(cmdNS, con);
                        SqlDataReader readerNS = disptal.ExecuteReader();
                        if (readerNS.Read())
                        {

                            int disp = Convert.ToInt16(readerNS["disponivel_tal"]);
                            if (disp == 1)
                            {
                                i = i - 1;
                                labels[i].BackColor = Color.FromArgb(39, 174, 96);
                            }
                            else
                            {
                                i = i - 1;
                                labels[i].BackColor = Color.FromArgb(192, 57, 43);
                            }
                        }

                    }
                }

                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }


            private void btnDetalhes_Click(object sender, EventArgs e)
            {
                using (detalhes_solo _detalhes_solo = new detalhes_solo())
                {
                    _detalhes_solo.ShowDialog(this);
                }
            }

            private void btnVoltar_Click(object sender, EventArgs e)
            {
                this.Hide();
            }

            private void btnAtualizar_Click(object sender, EventArgs e)
            {
                DispCor();
            }

    }
}
