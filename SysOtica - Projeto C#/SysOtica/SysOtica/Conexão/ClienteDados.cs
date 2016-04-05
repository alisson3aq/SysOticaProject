using ClassLibrary1;
using Npgsql;
using SysOtica;
using SysOtica.Negócio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexão
{
    public class ClienteDados : ConexaoBD, IClienteDados
    {
        private ConexaoBDInterface cbd;

        public ClienteDados()
        {
            cbd = new ConexaoBD();
        }
        //Inclui um novo registro no Banco de Dados

        public void Inserir(Cliente cliente)
        {
            try
            {
                //abrir a conexão
                this.Conectar();
                string sql = "INSERT INTO cliente (cl_nome, cl_datanascimento, cl_cpf, cl_rg, cl_telefone, cl_celular, cl_telefone2, cl_cep, cl_endereco, cl_numero, cl_bairro, cl_cidade, cl_email, cl_nomepai, cl_nomemae, cl_profissao, cl_observacoes, cl_uf ) values (:cl_nome, :cl_datanascimento, :cl_cpf, :cl_rg, :cl_telefone, :cl_celular, :cl_telefone2, :cl_cep, :cl_endereco, :cl_numero, :cl_bairro, :cl_cidade, :cl_email, :cl_nomepai, :cl_nomemae, :cl_profissao, :cl_observacoes, :cl_uf)";
                //instrucao a ser executada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);
                //executando a instrucao 
                //cmd.Parameters.Add();
                cmd.Parameters.Add("@cl_nome", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_nome;
                cmd.Parameters.Add("@cl_datanascimento", NpgsqlTypes.NpgsqlDbType.Date).Value = cliente.Cl_datanascimento;
                cmd.Parameters.Add("@cl_cpf", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_cpf;
                cmd.Parameters.Add("@cl_rg", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_rg;
                cmd.Parameters.Add("@cl_telefone", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_telefone;
                cmd.Parameters.Add("@cl_celular", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_celular;
                cmd.Parameters.Add("@cl_telefone2", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_telefone2;
                cmd.Parameters.Add("@cl_cep", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_cep;
                cmd.Parameters.Add("@cl_endereco", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_endereco;
                cmd.Parameters.Add("@cl_numero", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_numero;
                cmd.Parameters.Add("@cl_bairro", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_bairro;
                cmd.Parameters.Add("@cl_cidade", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_cidade;
                cmd.Parameters.Add("@cl_email", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_email;
                cmd.Parameters.Add("@cl_nomepai", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_nomepai;
                cmd.Parameters.Add("@cl_nomemae", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_nomemae;
                cmd.Parameters.Add("@cl_profissao", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_profissao;
                cmd.Parameters.Add("@cl_observacoes", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_observacoes;
                cmd.Parameters.Add("@cl_uf", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_uf;

                /*cmd.Parameters.Add("@matricula", NpgsqlTypes.NpgsqlDbType.Integer).Value = cliente.Cl_nome;
                cmd.Parameters.Add("@nome", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_datanascimento;*/
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Conectar ao BD e Inserir Dados " + ex.Message);
            }
        }


        //Altera um registro no Banco de Dados


        public void Alterar(Cliente cliente)
        {

            try
            {
                this.Conectar();
                String sql = "UPDATE Cliente set cl_nome = :cl_nome, cl_datanascimento=:cl_datanascimento,cl_cpf= :cl_cpf, cl_rg=:cl_rg, cl_telefone=:cl_telefone,cl_celular= :cl_celular, cl_telefone2=:cl_telefone2,cl_cep= :cl_cep, cl_endereco=:cl_endereco,cl_numero= :cl_numero, cl_bairro=:cl_bairro, cl_cidade=:cl_cidade, cl_email=:cl_email,cl_nomepai= :cl_nomepai, cl_nomemae=:cl_nomemae, cl_profissao=:cl_profissao, cl_observacoes=:cl_observacoes, cl_uf=:cl_uf  where cl_id = :cl_id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);

                cmd.Parameters.Add("@cl_nome", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_nome;
                cmd.Parameters.Add("@cl_datanascimento", NpgsqlTypes.NpgsqlDbType.Date).Value = cliente.Cl_datanascimento;
                cmd.Parameters.Add("@cl_cpf", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_cpf;
                cmd.Parameters.Add("@cl_rg", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_rg;
                cmd.Parameters.Add("@cl_telefone", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_telefone;
                cmd.Parameters.Add("@cl_celular", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_celular;
                cmd.Parameters.Add("@cl_telefone2", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_telefone2;
                cmd.Parameters.Add("@cl_cep", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_cep;
                cmd.Parameters.Add("@cl_endereco", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_endereco;
                cmd.Parameters.Add("@cl_numero", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_numero;
                cmd.Parameters.Add("@cl_bairro", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_bairro;
                cmd.Parameters.Add("@cl_cidade", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_cidade;
                cmd.Parameters.Add("@cl_email", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_email;
                cmd.Parameters.Add("@cl_nomepai", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_nomepai;
                cmd.Parameters.Add("@cl_nomemae", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_nomemae;
                cmd.Parameters.Add("@cl_profissao", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_profissao;
                cmd.Parameters.Add("@cl_observacoes", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_observacoes;
                cmd.Parameters.Add("@cl_uf", NpgsqlTypes.NpgsqlDbType.Text).Value = cliente.Cl_uf;
                cmd.Parameters.Add("@cl_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = cliente.Cl_id;


                cmd.ExecuteNonQuery();

                cmd.Dispose();

                this.Desconectar();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Conectar ao BD e Alterar Dados " + ex.Message);
            }

        }


        // Exclui um registro no Banco de Dados


        public void Excluir(int id)
        {
            try
            {
                this.Conectar();
                String sql = "DELETE FROM Cliente WHERE cl_id = " + id;
                NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);

                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Conectar ao BD e Excluir Dados " + ex.Message);
            }
        }


        //Realiza uma lista de Cliente do Banco de Dados


        public List<Cliente> listaCliente()
        {
            this.Conectar();
            String sql = "SELECT cl_id, cl_nome, cl_datanascimento, cl_cpf, cl_rg, cl_telefone, cl_celular, cl_telefone2, cl_cep, cl_endereco, cl_numero, cl_bairro, cl_cidade, cl_email, cl_nomepai, cl_nomemae, cl_profissao, cl_observacoes, cl_uf FROM Cliente ORDER BY cl_id";
            List<Cliente> lista = new List<Cliente>();
            NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Cl_id = Convert.ToInt32(dr["cl_id"]);
                    cliente.Cl_nome = dr["cl_nome"].ToString();
                    cliente.Cl_datanascimento = DateTime.Parse(dr["cl_datanascimento"].ToString());
                    cliente.Cl_cpf = dr["cl_cpf"].ToString();
                    cliente.Cl_rg = dr["cl_rg"].ToString();
                    cliente.Cl_telefone = dr["cl_telefone"].ToString();
                    cliente.Cl_celular = dr["cl_celular"].ToString();
                    cliente.Cl_telefone2 = dr["cl_telefone2"].ToString();
                    cliente.Cl_cep = dr["cl_cep"].ToString();
                    cliente.Cl_endereco = dr["cl_endereco"].ToString();
                    cliente.Cl_numero = dr["cl_numero"].ToString();
                    cliente.Cl_bairro = dr["cl_bairro"].ToString();
                    cliente.Cl_cidade = dr["cl_cidade"].ToString();
                    cliente.Cl_email = dr["cl_email"].ToString();
                    cliente.Cl_nomepai = dr["cl_nomepai"].ToString();
                    cliente.Cl_nomemae = dr["cl_nomemae"].ToString();
                    cliente.Cl_profissao = dr["cl_profissao"].ToString();
                    cliente.Cl_observacoes = dr["cl_observacoes"].ToString();
                    cliente.Cl_uf = dr["cl_uf"].ToString();

                    lista.Add(cliente);
                }
            }
            this.Desconectar();
            return lista;
        }

       /* public Cliente RetornaCliente(Cliente filtro)
        {
            Cliente retorno = new Cliente();
            try
            {
                this.Conectar();
                String sql = "select cl_id, cl_nome, cl_datanascimento, cl_cpf, cl_rg, cl_telefone, cl_celular, cl_telefone2, cl_cep, cl_endereco, cl_numero, cl_bairro, cl_cidade, cl_email, cl_nomepai, cl_nomemae, cl_profissao, cl_observacoes, cl_uf FROM Cliente WHERE cl_id = :id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);
                cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = filtro.Cl_id;
                //Classe para absover uma resposta de um select
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    retorno.Cl_id = dr.GetInt32(dr.GetOrdinal("cl_id"));
                    retorno.Cl_nome = dr.GetString(dr.GetOrdinal("cl_nome"));
                    retorno.Cl_datanascimento = dr.GetDateTime(dr.GetOrdinal("cl_datanascimento"));
                    retorno.Cl_cpf = dr.GetString(dr.GetOrdinal("cl_cpf"));
                    retorno.Cl_rg = dr.GetString(dr.GetOrdinal("cl_rg"));
                    retorno.Cl_telefone = dr.GetString(dr.GetOrdinal("cl_telefone"));
                    retorno.Cl_celular = dr.GetString(dr.GetOrdinal("cl_celular"));
                    retorno.Cl_telefone2 = dr.GetString(dr.GetOrdinal("cl_telefone2"));
                    retorno.Cl_cep = dr.GetString(dr.GetOrdinal("cl_cep"));
                    retorno.Cl_endereco = dr.GetString(dr.GetOrdinal("cl_endereco"));
                    retorno.Cl_numero = dr.GetString(dr.GetOrdinal("cl_numero"));
                    retorno.Cl_bairro = dr.GetString(dr.GetOrdinal("cl_bairro"));
                    retorno.Cl_cidade = dr.GetString(dr.GetOrdinal("cl_cidade"));
                    retorno.Cl_email = dr.GetString(dr.GetOrdinal("cl_email"));
                    retorno.Cl_nomepai = dr.GetString(dr.GetOrdinal("cl_nomepai"));
                    retorno.Cl_nomemae = dr.GetString(dr.GetOrdinal("cl_nomemae"));
                    retorno.Cl_profissao = dr.GetString(dr.GetOrdinal("cl_profissao"));
                    retorno.Cl_observacoes = dr.GetString(dr.GetOrdinal("cl_observacoes"));
                    retorno.Cl_uf = dr.GetString(dr.GetOrdinal("cl_uf"));
                }
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.Desconectar();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Conectar ao BD e Excluir Dados " + ex.Message);
            }

            return retorno;
        }*/

        public void Excluir(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void VerificaDuplicidade(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> Select(Cliente filtro)
        {
            throw new NotImplementedException();
        }

        public Cliente RetornaCliente(Cliente filtro)
        {
            throw new NotImplementedException();
        }
    }
}

