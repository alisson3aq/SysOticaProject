using ClassLibrary1;
using Npgsql;
using SysOtica.Negócio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexão
{
    public class LocalDados : ConexaoBD, ILocalDados
    {

        private ConexaoBDInterface cbd;

        public LocalDados()
        {
            cbd = new ConexaoBD();
        }

        //Inclui um novo registro no Banco de Dados

        public void Inserir(Local local)
        {
            try
            {
                //abrir conexão com o banco de dados
                this.Conectar();
                string sql = "INSERT INTO local (lc_nomeclinica, lc_endereco, lc_numero, lc_bairro, lc_cidade, lc_uf, lc_cep, lc_telefone, lc_email) values (:lc_nomeclinica, :lc_endereco, :lc_numero, :lc_bairro, :lc_cidade, :lc_uf, :lc_cep, :lc_telefone, :lc_email )";
                //instrucao a ser executada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);
                //executando a instrucao 
                //cmd.Parameters.Add();
                cmd.Parameters.Add("@lc_nomeclinica", NpgsqlTypes.NpgsqlDbType.Text).Value = local.Lc_nomeclinica;
                cmd.Parameters.Add("@lc_endereco", NpgsqlTypes.NpgsqlDbType.Text).Value = local.Lc_endereco;
                cmd.Parameters.Add("@lc_numero", NpgsqlTypes.NpgsqlDbType.Text).Value = local.Lc_numero;
                cmd.Parameters.Add("@lc_bairro", NpgsqlTypes.NpgsqlDbType.Text).Value = local.Lc_bairro;
                cmd.Parameters.Add("@lc_cidade", NpgsqlTypes.NpgsqlDbType.Text).Value = local.Lc_cidade;
                cmd.Parameters.Add("@lc_uf", NpgsqlTypes.NpgsqlDbType.Text).Value = local.Lc_uf;
                cmd.Parameters.Add("@lc_cep", NpgsqlTypes.NpgsqlDbType.Text).Value = local.Lc_cep;
                cmd.Parameters.Add("@lc_telefone", NpgsqlTypes.NpgsqlDbType.Text).Value = local .Lc_telefone;
                cmd.Parameters.Add("@lc_email", NpgsqlTypes.NpgsqlDbType.Text).Value = local.Lc_email;

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

        public void Alterar(Local local)
        {
            try
            {
                this.Conectar();
                string sql = "UPDATE Local set lc_nomeclinica = :lc_nomeclinica, lc_endereco = :lc_endereco, lc_numero = :lc_numero, lc_bairro = :lc_bairro, lc_cidade = :lc_cidade, lc_uf = :lc_uf, lc_cep = :lc_cep, lc_telefone = :lc_telefone, lc_email = :lc_email WHERE lc_id = :lc_id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);

                cmd.Parameters.Add("@lc_nomeclinica", NpgsqlTypes.NpgsqlDbType.Text).Value = local.Lc_nomeclinica;
                cmd.Parameters.Add("@lc_endereco", NpgsqlTypes.NpgsqlDbType.Text).Value = local.Lc_endereco;
                cmd.Parameters.Add("@lc_numero", NpgsqlTypes.NpgsqlDbType.Text).Value = local.Lc_numero;
                cmd.Parameters.Add("@lc_bairro", NpgsqlTypes.NpgsqlDbType.Text).Value = local.Lc_bairro;
                cmd.Parameters.Add("@lc_cidade", NpgsqlTypes.NpgsqlDbType.Text).Value = local.Lc_cidade;
                cmd.Parameters.Add("@lc_uf", NpgsqlTypes.NpgsqlDbType.Text).Value = local.Lc_uf;
                cmd.Parameters.Add("@lc_cep", NpgsqlTypes.NpgsqlDbType.Text).Value = local.Lc_cep;
                cmd.Parameters.Add("@lc_telefone", NpgsqlTypes.NpgsqlDbType.Text).Value = local.Lc_telefone;
                cmd.Parameters.Add("@lc_email", NpgsqlTypes.NpgsqlDbType.Text).Value = local.Lc_email;

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
                String sql = "DELETE FROM Local WHERE lc_id = " + id;
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

        //Realiza uma lista de Local do Banco de Dados


        public List<Local> listaLocal()
        {
            this.Conectar();
            String sql = "SELECT lc_id, lc_nomeclinica, lc_endereco, lc_numero, lc_bairro, lc_cidade, lc_uf, lc_cep, lc_telefone, lc_email FROM Local ORDER BY lc_id";
            List<Local> lista = new List<Local>();
            NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Local local = new Local();
                    local.Lc_id = Convert.ToInt32(dr["lc_id"]);
                    local.Lc_nomeclinica = dr["lc_nomeclinica"].ToString();
                    local.Lc_endereco = dr["lc_endereco"].ToString();
                    local.Lc_numero = dr["lc_numero"].ToString();
                    local.Lc_bairro = dr["lc_bairro"].ToString();
                    local.Lc_cidade = dr["lc_cidade"].ToString();
                    local.Lc_uf = dr["lc_uf"].ToString();
                    local.Lc_cep = dr["lc_cep"].ToString();
                    local.Lc_telefone = dr["lc_telefone"].ToString();
                    local.Lc_email = dr["lc_email"].ToString();
                  
                    lista.Add(local);
                }
            }
            this.Desconectar();
            return lista;
        }

        public void Excluir(Local local)
        {
            throw new NotImplementedException();
        }
    }
}
