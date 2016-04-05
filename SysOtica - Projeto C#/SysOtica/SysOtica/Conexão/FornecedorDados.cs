using ClassLibrary1;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexão
{
    public class FornecedorDados : ConexaoBD, IFornecedorDados
    {
        public void Inserir(Fornecedor fornecedor)
        {
            try
            {
                //Abrir a conexão
                this.Conectar();
                string sql = "INSERT INTO fornecedor (fr_razaosocial, fr_inscricaoestadual ,fr_fantasia	,fr_endereco ,fr_cidade	 ,fr_uf	,fr_bairro	,fr_cep	,fr_contato	,fr_telefone ,fr_fax ,fr_email ,fr_nomerepresentante ,fr_telefonerepresentante, fr_celularrepresentante ,fr_observacoes ,fr_cnpj ) values ( :fr_razaosocial, :fr_inscricaoestadual, :fr_fantasia, :fr_endereco, :fr_cidade, :fr_uf, :fr_bairro, :fr_cep, :fr_contato, :fr_telefone, :fr_fax, :fr_email, :fr_nomerepresentante, :fr_telefonerepresentante, :fr_celularrepresentante, :fr_observacoes, :fr_cnpj)";
                //Instrução a ser executada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);
                //Executando a instrução
                //cmd.Parameters.Add();
                cmd.Parameters.Add("@fr_razaosocial", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_razaosocial;
                cmd.Parameters.Add("@fr_inscricaoestadual", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_inscricaoestadual;
                cmd.Parameters.Add("@fr_fantasia", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_fantasia;
                cmd.Parameters.Add("@fr_endereco", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_endereco;
                cmd.Parameters.Add("@fr_cidade", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_cidade;
                cmd.Parameters.Add("@fr_uf", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_uf;
                cmd.Parameters.Add("@fr_bairro", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_bairro;
                cmd.Parameters.Add("@fr_cep", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_cep;
                cmd.Parameters.Add("@fr_contato", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_contato;
                cmd.Parameters.Add("@fr_telefone", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_telefone;
                cmd.Parameters.Add("@fr_fax", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_fax;
                cmd.Parameters.Add("@fr_email", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_email;
                cmd.Parameters.Add("@fr_nomerepresentante", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_nomerepresentante;
                cmd.Parameters.Add("@fr_telefonerepresentante", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_telefonerepresentante;
                cmd.Parameters.Add("@fr_celularrepresentante", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_celularrepresentante;
                cmd.Parameters.Add("@fr_observacoes", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_observacoes;
                cmd.Parameters.Add("@fr_cnpj", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_cnpj;

                cmd.ExecuteNonQuery();
                //Liberando a memória
                cmd.Dispose();
                //Fechando a conexão
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ao BD e inserir Dados" + ex.Message);
            }
        }
        public void Alterar(Fornecedor fornecedor)
        {
            try
            {
                this.Conectar();
                String sql = "UPDATE Fornecedor set fr_razaosocial = :fr_razaosocial, fr_inscricaoestadual = :fr_inscricaoestadual ,fr_fantasia = :fr_fantasia	,fr_endereco = :fr_endereco ,fr_cidade = :fr_cidade	 ,fr_uf = :fr_uf	,fr_bairro = :fr_bairro	,fr_cep	= :fr_cep,fr_contato = :fr_contato	,fr_telefone = :fr_telefone ,fr_fax = :fr_fax ,fr_email = :fr_email ,fr_nomerepresentante = :fr_nomerepresentante ,fr_telefonerepresentante = :fr_telefonerepresentante, fr_celularrepresentante = :fr_celularrepresentante ,fr_observacoes = :fr_observacoes ,fr_cnpj = :fr_cnpj  WHERE fr_id = :fr_id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);

                cmd.Parameters.Add("@fr_razaosocial", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_razaosocial;
                cmd.Parameters.Add("@fr_inscricaoestadual", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_inscricaoestadual;
                cmd.Parameters.Add("@fr_fantasia", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_fantasia;
                cmd.Parameters.Add("@fr_endereco", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_endereco;
                cmd.Parameters.Add("@fr_cidade", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_cidade;
                cmd.Parameters.Add("@fr_uf", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_uf;
                cmd.Parameters.Add("@fr_bairro", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_bairro;
                cmd.Parameters.Add("@fr_cep", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_cep;
                cmd.Parameters.Add("@fr_contato", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_contato;
                cmd.Parameters.Add("@fr_telefone", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_telefone;
                cmd.Parameters.Add("@fr_fax", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_fax;
                cmd.Parameters.Add("@fr_email", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_email;
                cmd.Parameters.Add("@fr_nomerepresentante", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_nomerepresentante;
                cmd.Parameters.Add("@fr_telefonerepresentante", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_telefonerepresentante;
                cmd.Parameters.Add("@fr_celularrepresentante", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_celularrepresentante;
                cmd.Parameters.Add("@fr_observacoes", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_observacoes;
                cmd.Parameters.Add("@fr_cnpj", NpgsqlTypes.NpgsqlDbType.Text).Value = fornecedor.Fr_cnpj;
                cmd.Parameters.Add("@fr_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = fornecedor.Fr_id;

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                this.Desconectar();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ao BD e Alterar Dados" + ex.Message);
            }
        }
        public void Excluir(int id)
        {
            try
            {
                this.Conectar();
                String sql = "DELETE FROM Fornecedor WHERE fr_id =" + id;
                NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);

                cmd.ExecuteNonQuery();
                //Liberando a memória
                cmd.Dispose();
                //Fechando a conexão
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ao BD e Excluir Dados" + ex.Message);
            }
        }
        public void VerificaDuplicidade(Fornecedor fornecedor)
        {

        }
        public List<Fornecedor> listaFornecedor()
        {
            this.Conectar();
            String sql = "SELECT fr_id, fr_razaosocial, fr_inscricaoestadual ,fr_fantasia	,fr_endereco ,fr_cidade	 ,fr_uf	,fr_bairro	,fr_cep	,fr_contato	,fr_telefone ,fr_fax ,fr_email ,fr_nomerepresentante ,fr_telefonerepresentante, fr_celularrepresentante ,fr_observacoes ,fr_cnpj FROM Fornecedor ORDER BY fr_id";
            List<Fornecedor> lista = new List<Fornecedor>();
            NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    Fornecedor fornecedor = new Fornecedor();
                    fornecedor.Fr_id = Convert.ToInt32(dr["fr_id"]);
                    fornecedor.Fr_razaosocial = dr["fr_razaosocial"].ToString();
                    fornecedor.Fr_inscricaoestadual = dr["fr_inscricaoestadual"].ToString();
                    fornecedor.Fr_fantasia = dr["fr_fantasia"].ToString();
                    fornecedor.Fr_endereco = dr["fr_endereco"].ToString();
                    fornecedor.Fr_cidade = dr["fr_cidade"].ToString();
                    fornecedor.Fr_uf = dr["fr_uf"].ToString();
                    fornecedor.Fr_bairro = dr["fr_bairro"].ToString();
                    fornecedor.Fr_cep = dr["fr_cep"].ToString();
                    fornecedor.Fr_contato = dr["fr_contato"].ToString();
                    fornecedor.Fr_telefone = dr["fr_telefone"].ToString();
                    fornecedor.Fr_fax = dr["fr_fax"].ToString();
                    fornecedor.Fr_email = dr["fr_email"].ToString();
                    fornecedor.Fr_nomerepresentante = dr["fr_nomerepresentante"].ToString();
                    fornecedor.Fr_telefonerepresentante = dr["fr_telefonerepresentante"].ToString();
                    fornecedor.Fr_celularrepresentante = dr["fr_celularrepresentante"].ToString();
                    fornecedor.Fr_observacoes = dr["fr_observacoes"].ToString();
                    fornecedor.Fr_cnpj = dr["fr_cnpj"].ToString();


                    lista.Add(fornecedor);
                }
            }
            this.Desconectar();
            return lista;
        }
        public Fornecedor RetornaFornecedor(Fornecedor filtro)
        {
            Fornecedor retorno = new Fornecedor();
            try
            {
                this.Conectar();
                String sql = "SELECT fr_id, fr_razaosocial, fr_inscricaoestadual ,fr_fantasia	,fr_endereco ,fr_cidade	 ,fr_uf	,fr_bairro	,fr_cep	,fr_contato	,fr_telefone ,fr_fax ,fr_email ,fr_nomerepresentante ,fr_telefonerepresentante, fr_celularrepresentante ,fr_observacoes ,fr_cnpj FROM Fornecedor WHERE fr_id = :id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);
                cmd.Parameters.Add("@fr_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = filtro.Fr_id;
                //Classe para absorver uma resposta de um select
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    retorno.Fr_id = dr.GetInt32(dr.GetOrdinal("fr_id"));
                    retorno.Fr_razaosocial = dr.GetString(dr.GetOrdinal("fr_razaosocial"));
                    retorno.Fr_inscricaoestadual = dr.GetString(dr.GetOrdinal("fr_inscricaosocial"));
                    retorno.Fr_fantasia = dr.GetString(dr.GetOrdinal("fr_fantasia"));
                    retorno.Fr_endereco = dr.GetString(dr.GetOrdinal("fr_endereco"));
                    retorno.Fr_cidade = dr.GetString(dr.GetOrdinal("fr_cidade"));
                    retorno.Fr_uf = dr.GetString(dr.GetOrdinal("fr_uf"));
                    retorno.Fr_bairro = dr.GetString(dr.GetOrdinal("fr_bairro"));
                    retorno.Fr_telefone = dr.GetString(dr.GetOrdinal("fr_cep"));
                    retorno.Fr_fax = dr.GetString(dr.GetOrdinal("fr_fax"));
                    retorno.Fr_email = dr.GetString(dr.GetOrdinal("fr_email"));
                    retorno.Fr_nomerepresentante = dr.GetString(dr.GetOrdinal("fr_nomerepresentante"));
                    retorno.Fr_telefonerepresentante = dr.GetString(dr.GetOrdinal("fr_telefonerepresentante"));
                    retorno.Fr_celularrepresentante = dr.GetString(dr.GetOrdinal(",fr_celularrepresentante "));
                    retorno.Fr_observacoes = dr.GetString(dr.GetOrdinal("fr_observacoes"));
                    retorno.Fr_cnpj = dr.GetString(dr.GetOrdinal("fr_cnpj"));
                }
                //Libeando memória
                cmd.Dispose();
                //Fechando a conexão
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ao BD e Excluir Dados" + ex.Message);
            }
            return retorno;
        }
        public Fornecedor GetFornecedor(int fr_id)
        {
            Fornecedor retorno = new Fornecedor();
            try
            {
                this.Conectar();
                String sql = "SELECT fr_id, fr_razaosocial, fr_inscricaoestadual ,fr_fantasia	,fr_endereco ,fr_cidade	 ,fr_uf	,fr_bairro	,fr_cep	,fr_contato	,fr_telefone ,fr_fax ,fr_email ,fr_nomerepresentante ,fr_telefonerepresentante, fr_celularrepresentante ,fr_observacoes ,fr_cnpj FROM Fornecedor WHERE fr_id = :fr_id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);
                cmd.Parameters.Add("@fr_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = fr_id;
                //Classe para absorver uma resposta de um select
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    retorno.Fr_id = dr.GetInt32(dr.GetOrdinal("fr_id"));
                    retorno.Fr_razaosocial = dr.GetString(dr.GetOrdinal("fr_razaosocial"));
                    retorno.Fr_inscricaoestadual = dr.GetString(dr.GetOrdinal("fr_inscricaoestadual"));
                    retorno.Fr_fantasia = dr.GetString(dr.GetOrdinal("fr_fantasia"));
                    retorno.Fr_endereco = dr.GetString(dr.GetOrdinal("fr_endereco"));
                    retorno.Fr_cidade = dr.GetString(dr.GetOrdinal("fr_cidade"));
                    retorno.Fr_uf = dr.GetString(dr.GetOrdinal("fr_uf"));
                    retorno.Fr_bairro = dr.GetString(dr.GetOrdinal("fr_bairro"));
                    retorno.Fr_telefone = dr.GetString(dr.GetOrdinal("fr_cep"));
                    retorno.Fr_fax = dr.GetString(dr.GetOrdinal("fr_fax"));
                    retorno.Fr_email = dr.GetString(dr.GetOrdinal("fr_email"));
                    retorno.Fr_nomerepresentante = dr.GetString(dr.GetOrdinal("fr_nomerepresentante"));
                    retorno.Fr_telefonerepresentante = dr.GetString(dr.GetOrdinal("fr_telefonerepresentante"));
                    retorno.Fr_celularrepresentante = dr.GetString(dr.GetOrdinal("fr_celularrepresentante"));
                    retorno.Fr_observacoes = dr.GetString(dr.GetOrdinal("fr_observacoes"));
                    retorno.Fr_cnpj = dr.GetString(dr.GetOrdinal("fr_cnpj"));
                }
                //Libeando memória
                cmd.Dispose();
                //Fechando a conexão
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ao BD e Excluir Dados" + ex.Message);
            }
            return retorno;
        }
        /*    public Fornecedor ConsultarPorCNPJ(string cnpj)
             {
                 Fornecedor fornecedor = new Fornecedor();

             }*/



    }
}
