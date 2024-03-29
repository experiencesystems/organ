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
    public class Funcionario
    {
        private int codigo;
        private String nome_funcionario;
        private String cpf;
        private String rg;
        private String telefone;
        private String celular;
        private String email;
        private String cargo;
        private String salario;
        private String status;
        private String data_nasc;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public String Nome_funcionario
        {
            get { return nome_funcionario; }
            set { nome_funcionario = value; }
        }
        public String CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public String RG
        {
            get { return rg; }
            set { rg = value; }
        }
        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public String Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public String Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public String Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public String Status
        {
            get { return status; }
            set { status = value; }
        }
        public String Data_nasc
        {
            get { return data_nasc; }
            set { data_nasc = value; }
        }
        public Endereco endereco { get; set; }

        public Funcionario(int codigo)
        {
            this.Codigo = codigo;
        }

        public Funcionario(String nome_funcionario, String cpf, String rg, String telefone, String celular, String email, String cargo, String salario, String data_nasc, String CEP, int Numero, String Rua, String Bairro, String Complemento, String Cidade, String UF)
        {
            endereco = new Endereco();
            this.Nome_funcionario = nome_funcionario;
            this.CPF = cpf;
            this.RG = rg;
            this.Telefone = telefone;
            this.Celular = celular;
            this.Email = email;
            this.Cargo = cargo;
            this.Salario = salario;
            this.Data_nasc = data_nasc;
            endereco.CEP = CEP;
            endereco.Numero = Numero;
            endereco.Rua = Rua;
            endereco.Bairro = Bairro;
            endereco.Complemento = Complemento;
            endereco.Cidade = Cidade;
            endereco.UF = UF;
        }

        public void RegistrarFuncionario(Funcionario f)
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);

            SqlCommand cmd = new SqlCommand("SP_INSERT_FUNCIONARIO", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@CEP", SqlDbType.Int).Value = f.endereco.CEP;
            cmd.Parameters.Add("@NUMERO", SqlDbType.Int).Value = f.endereco.Numero;
            cmd.Parameters.Add("@RUA", SqlDbType.VarChar).Value = f.endereco.Rua;
            cmd.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value = f.endereco.Bairro;
            cmd.Parameters.Add("@COMPLEMENTO", SqlDbType.VarChar).Value = f.endereco.Complemento;
            cmd.Parameters.Add("@CIDADE", SqlDbType.VarChar).Value = f.endereco.Cidade;
            cmd.Parameters.Add("@UF", SqlDbType.Char).Value = f.endereco.UF;
            cmd.Parameters.Add("@NOME_FUNC", SqlDbType.VarChar).Value = f.Nome_funcionario;
            cmd.Parameters.Add("@CPF_FUNC", SqlDbType.Char).Value = f.CPF;
            cmd.Parameters.Add("@RG_FUNC", SqlDbType.Char).Value = f.RG;
            cmd.Parameters.Add("@DATA_NASC", SqlDbType.Date).Value = f.Data_nasc;
            if (f.Telefone == "")
            {
                cmd.Parameters.Add("@TEL_FUNC", SqlDbType.Char).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@TEL_FUNC", SqlDbType.Char).Value = f.Telefone;
            }
            if (f.Celular == "")
            {
                cmd.Parameters.Add("@CEL_FUNC", SqlDbType.Char).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@CEL_FUNC", SqlDbType.Char).Value = f.Celular;
            }
            cmd.Parameters.Add("@EMAIL_FUNC", SqlDbType.VarChar).Value = f.Email;
            cmd.Parameters.Add("@CARGO_FUNC", SqlDbType.VarChar).Value = f.Cargo;
            cmd.Parameters.Add("@SALARIO_FUNC", SqlDbType.VarChar).Value = f.Salario;

            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Funcionário registrado com sucesso!", "Cadastro finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void ExcluirFuncionario(Funcionario f)
        {
            using (SqlConnection sqlCon = new SqlConnection(StringConexao.connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SP_DELETE_FUNCIONARIO", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCmd.Parameters.AddWithValue("@COD_FUNCIONARIO", f.Codigo);
                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}
