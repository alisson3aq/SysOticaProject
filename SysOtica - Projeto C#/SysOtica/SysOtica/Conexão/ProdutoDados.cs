using ClassLibrary1;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexão
{
    public class ProdutoDados : ConexaoBD, IProdutoDados
    {
        public void inserir(Produto produto)
        {
            try
            {
                this.Conectar();
                string sql = "INSERT INTO produto (pr_descricao, pr_unidade, pr_grupo, pr_grife, pr_valor, pr_qtd, pr_estoqueminimo, fr_id) values (:pr_descricao, :pr_unidade, :pr_grupo, :pr_grife, :pr_valor, :pr_qtd, :pr_estoqueminimo, :fr_id)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);
                cmd.Parameters.Add("@pr_descricao", NpgsqlTypes.NpgsqlDbType.Text).Value = produto.Pr_descricao;
                cmd.Parameters.Add("@pr_unidade", NpgsqlTypes.NpgsqlDbType.Text).Value = produto.Pr_unidade;
                cmd.Parameters.Add("@pr_grupo", NpgsqlTypes.NpgsqlDbType.Text).Value = produto.Pr_grupo;
                cmd.Parameters.Add("@pr_grife", NpgsqlTypes.NpgsqlDbType.Text).Value = produto.Pr_grife;
                cmd.Parameters.Add("@pr_valor", NpgsqlTypes.NpgsqlDbType.Integer).Value = produto.Pr_valor;
                cmd.Parameters.Add("@pr_qtd", NpgsqlTypes.NpgsqlDbType.Integer).Value = produto.Pr_qtd;
                cmd.Parameters.Add("@pr_estoqueminimo", NpgsqlTypes.NpgsqlDbType.Integer).Value = produto.Pr_estoqueminimo;
                cmd.Parameters.Add("@fr_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = produto.Fr_id.Fr_id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Conectar ao BD e Inserir Dados " + ex.Message);
            }
        }

        public void alterar(Produto produto)
        {
            try
            {
                this.Conectar();
                String sql = "UPDATE produto set pr_descricao = :pr_descricao, pr_unidade = :pr_unidade, pr_grupo = :pr_grupo, pr_grife = :pr_grife, pr_valor = :pr_valor, pr_qtd = :pr_qtd, pr_estoqueminimo = :pr_estoqueminimo where pr_id = :pr_id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);
                cmd.Parameters.Add("@pr_descricao", NpgsqlTypes.NpgsqlDbType.Text).Value = produto.Pr_descricao;
                cmd.Parameters.Add("@pr_unidade", NpgsqlTypes.NpgsqlDbType.Text).Value = produto.Pr_unidade;
                cmd.Parameters.Add("@pr_grupo", NpgsqlTypes.NpgsqlDbType.Text).Value = produto.Pr_grupo;
                cmd.Parameters.Add("@pr_grife", NpgsqlTypes.NpgsqlDbType.Text).Value = produto.Pr_grife;
                cmd.Parameters.Add("@pr_valor", NpgsqlTypes.NpgsqlDbType.Integer).Value = produto.Pr_valor;
                cmd.Parameters.Add("@pr_qtd", NpgsqlTypes.NpgsqlDbType.Integer).Value = produto.Pr_qtd;
                cmd.Parameters.Add("@pr_estoqueminimo", NpgsqlTypes.NpgsqlDbType.Integer).Value = produto.Pr_estoqueminimo;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Conectar ao BD e Alterar Dados " + ex.Message);
            }

        }
        public void excluir(int id)
        {
            try
            {
                this.Conectar();
                String sql = "DELETE FROM produto WHERE pr_id = " + id;
                NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Conectar ao BD e Excluir Dados " + ex.Message);
            }
        }

        public Produto retornarProduto(Produto filtro)
        {
            Produto retorno = new Produto();
            try
            {
                this.Conectar();
                String sql = "select pr_id, pr_descricao, pr_unidade, pr_grupo, pr_grife, pr_valor, pr_qtd, pr_estoqueminimo FROM produto WHERE pr_id = :id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);
                cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = filtro.Pr_id;
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    retorno.Pr_id = dr.GetInt32(dr.GetOrdinal("pr_id"));
                    retorno.Pr_descricao = dr.GetString(dr.GetOrdinal("pr_descricao"));
                    retorno.Pr_unidade = dr.GetString(dr.GetOrdinal("pr_unidade"));
                    retorno.Pr_grupo = dr.GetString(dr.GetOrdinal("pr_grupo"));
                    retorno.Pr_grife = dr.GetString(dr.GetOrdinal("pr_grife"));
                    retorno.Pr_valor = dr.GetInt32(dr.GetOrdinal("pr_valor"));
                    retorno.Pr_qtd = dr.GetInt32(dr.GetOrdinal("pr_qtd"));
                    retorno.Pr_estoqueminimo = dr.GetInt32(dr.GetOrdinal("pr_estoqueminimo"));

                }
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Conectar ao BD e Excluir Dados " + ex.Message);
            }

            return retorno;

        }

        public void inserirProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void alterarProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void excluirProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void verificarDuplicidade(Produto produto)
        {
            throw new NotImplementedException();
        }

        public List<Produto> listarProduto()
        {
            {
                this.Conectar();

                String sql = "SELECT pr_id, pr_descricao, pr_unidade,pr_grupo,pr_grife,pr_valor,pr_qtd,pr_estoqueminimo,fr_id FROM Produto ORDER BY pr_id";
                List<Produto> lista = new List<Produto>();
                NpgsqlCommand comando = new NpgsqlCommand(sql, this.conexao);
                NpgsqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows)

                {
                    while (dr.Read())
                    {
                        Produto prod = new Produto();
                        prod.Pr_id = Convert.ToInt32(dr["pr_id"]);
                        prod.Pr_descricao = dr["pr_descricao"].ToString();
                        prod.Pr_unidade = dr["pr_unidade"].ToString();
                        prod.Pr_grupo = dr["pr_grupo"].ToString();
                        prod.Pr_grife = dr["pr_grife"].ToString();
                        prod.Pr_valor = Convert.ToInt32(dr["pr_valor"].ToString());
                        prod.Pr_qtd = Convert.ToInt32(dr["pr_qtd"].ToString());
                        prod.Pr_estoqueminimo = Convert.ToInt32(dr["pr_estoqueminimo"].ToString());
                    
                        lista.Add(prod);
                    }

                }
                this.Desconectar();
                return lista;

            }
        }
    }
}
