﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organ
{
    public class Plantio
    {
        private int cod_plantio;
        private String nome_plantio;
        private String data_inicio;
        private String data_colheita;
        private int cod_funcionario;
        private int cod_funcionario2;
        private int cod_funcionario3;
        private int cod_semente;
        private int qtd_semente;
        private int cod_fertilizante;
        private String qtd_fertilizante;
        private int cod_defensivo;
        private String qtd_defensivo;
        private int cod_talhao;
        private int cod_talhao2;
        private int cod_talhao3;

        public Plantio(int cod_plantio)
        {
            this.Cod_plantio = cod_plantio;
        }

        public Plantio()
        {

        }

        public Plantio(String nome_plantio, String data_colheita, int cod_funcionario, int cod_funcionario2, int cod_funcionario3, int cod_semente, int qtd_semente, int cod_fertilizante, String qtd_fertilizante, int cod_defensivo, String qtd_defensivo, int cod_talhao, int cod_talhao2, int cod_talhao3)
        {
            this.Nome_plantio = nome_plantio;
            this.Data_colheita = data_colheita;
            this.Cod_funcionario = cod_funcionario;
            this.Cod_funcionario2 = cod_funcionario2;
            this.Cod_funcionario3 = cod_funcionario3;
            this.Cod_semente = cod_semente;
            this.Qtd_semente = qtd_semente;
            this.Cod_fertilizante = cod_fertilizante;
            this.Qtd_fertilizante = qtd_fertilizante;
            this.Cod_defensivo = cod_defensivo;
            this.Qtd_defensivo = qtd_defensivo;
            this.Cod_talhao = cod_talhao;
            this.Cod_talhao2 = cod_talhao2;
            this.Cod_talhao3 = cod_talhao3;
        }

        public int Cod_plantio
        {
            get { return cod_plantio; }
            set { cod_plantio = value; }
        }
        public String Nome_plantio
        {
            get { return nome_plantio; }
            set { nome_plantio = value; }
        }
        public String Data_inicio
        {
            get { return data_inicio; }
            set { data_inicio = value; }
        }
        public String Data_colheita
        {
            get { return data_colheita; }
            set { data_colheita = value; }
        }
        public int Cod_funcionario
        {
            get { return cod_funcionario; }
            set { cod_funcionario = value; }
        }
        public int Cod_funcionario2
        {
            get { return cod_funcionario2; }
            set { cod_funcionario2 = value; }
        }
        public int Cod_funcionario3
        {
            get { return cod_funcionario3; }
            set { cod_funcionario3 = value; }
        }
        public int Cod_semente
        {
            get { return cod_semente; }
            set { cod_semente = value; }
        }
        public int Qtd_semente
        {
            get { return qtd_semente; }
            set { qtd_semente = value; }
        }
        public int Cod_fertilizante
        {
            get { return cod_fertilizante; }
            set { cod_fertilizante = value; }
        }
        public String Qtd_fertilizante
        {
            get { return qtd_fertilizante; }
            set { qtd_fertilizante = value; }
        }
        public int Cod_defensivo
        {
            get { return cod_defensivo; }
            set { cod_defensivo = value; }
        }
        public String Qtd_defensivo
        {
            get { return qtd_defensivo; }
            set { qtd_defensivo = value; }
        }
        public int Cod_talhao
        {
            get { return cod_talhao; }
            set { cod_talhao = value; }
        }
        public int Cod_talhao2
        {
            get { return cod_talhao2; }
            set { cod_talhao2 = value; }
        }
        public int Cod_talhao3
        {
            get { return cod_talhao3; }
            set { cod_talhao3 = value; }
        }

        public void NovoPlantio(Plantio p)
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);

            SqlCommand cmd = new SqlCommand("SP_INSERT_PLANTIO", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@NOME_PLANTIO", SqlDbType.VarChar).Value = p.Nome_plantio;
            cmd.Parameters.Add("@DATA_COLHEITA", SqlDbType.VarChar).Value = p.Data_colheita;
            cmd.Parameters.Add("@COD_FUNCIONARIO", SqlDbType.Int).Value = p.Cod_funcionario;

            if (p.Cod_funcionario2 == -1)
            {
                cmd.Parameters.Add("@COD_FUNCIONARIO2", SqlDbType.Int).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@COD_FUNCIONARIO2", SqlDbType.Int).Value = p.Cod_funcionario2;
            }

            if (p.Cod_funcionario3 == -1)
            {
                cmd.Parameters.Add("@COD_FUNCIONARIO3", SqlDbType.Int).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@COD_FUNCIONARIO3", SqlDbType.Int).Value = p.Cod_funcionario3;
            }

            cmd.Parameters.Add("@COD_SEMENTE", SqlDbType.Int).Value = p.Cod_semente;
            cmd.Parameters.Add("@QTD_SEMENTE", SqlDbType.Int).Value = p.Qtd_semente;

            if (p.Cod_fertilizante == -1)
            {
                cmd.Parameters.Add("@COD_FERTILIZANTE", SqlDbType.Int).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@COD_FERTILIZANTE", SqlDbType.Int).Value = p.Cod_fertilizante;
            }

            if (p.Qtd_fertilizante == "")
            {
                cmd.Parameters.Add("@QTD_FERTILIZANTE", SqlDbType.Int).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@QTD_FERTILIZANTE", SqlDbType.Int).Value = Convert.ToInt32(p.Qtd_fertilizante);
            }

            if (p.Cod_defensivo == -1)
            {
                cmd.Parameters.Add("@COD_DEFENSIVO", SqlDbType.Int).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@COD_DEFENSIVO", SqlDbType.Int).Value = p.Cod_defensivo;
            }

            if (p.Qtd_defensivo == "")
            {
                cmd.Parameters.Add("@QTD_DEFENSIVO", SqlDbType.Int).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@QTD_DEFENSIVO", SqlDbType.Int).Value = Convert.ToInt32(p.Qtd_defensivo);
            }
            
            cmd.Parameters.Add("@COD_TALHAO", SqlDbType.Int).Value = p.Cod_talhao;

            if (p.Cod_talhao2 == -1)
            {
                cmd.Parameters.Add("@COD_TALHAO2", SqlDbType.Int).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@COD_TALHAO2", SqlDbType.Int).Value = p.Cod_talhao2;
            }

            if (p.Cod_talhao3 == -1)
            {
                cmd.Parameters.Add("@COD_TALHAO3", SqlDbType.Int).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@COD_TALHAO3", SqlDbType.Int).Value = p.Cod_talhao3;
            }

            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Plantio registrado com sucesso! Clique no texto 'Progresso dos plantios' na tela de colheita para acompanhar seu plantio!", "Cadastro finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Verifique se as quantidades inseridas não ultrapassam as do estoque.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
