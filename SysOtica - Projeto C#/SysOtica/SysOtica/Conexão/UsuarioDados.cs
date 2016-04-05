using ClassLibrary1;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexão
{
    public class UsuarioDados : ConexaoBD, IUsuarioDados
    {

        public void Inserir(Usuario usuario)
        {
            try
            {
                //abrir a conexão
                this.Conectar();
                string sql = "INSERT INTO usuario (us_senha,us_endereco,us_telefone,us_tipo,us_usuario,us_nome) values (:us_senha,:us_endereco,:us_telefone,:us_tipo,:us_usuario,:us_nome)";
                //instrucao a ser executada
                NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);
                //executando a instrucao 

                cmd.Parameters.Add("@us_senha", NpgsqlTypes.NpgsqlDbType.Text).Value = usuario.Us_senha;
                cmd.Parameters.Add("@us_endereco", NpgsqlTypes.NpgsqlDbType.Text).Value = usuario.Us_endereco;
                cmd.Parameters.Add("@us_telefone", NpgsqlTypes.NpgsqlDbType.Text).Value = usuario.Us_telefone;
                cmd.Parameters.Add("@us_tipo", NpgsqlTypes.NpgsqlDbType.Text).Value = usuario.Us_tipo;
                cmd.Parameters.Add("@us_usuario", NpgsqlTypes.NpgsqlDbType.Text).Value = usuario.Us_usuario;
                cmd.Parameters.Add("@us_nome", NpgsqlTypes.NpgsqlDbType.Text).Value = usuario.Us_nome;

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


        public void Alterar(Usuario usuario)
        {

            try
            {
                this.Conectar();
                String sql = "UPDATE Usuario set us_senha = :us_senha, us_endereco = :us_endereco, us_telefone = :us_telefone, us_tipo = :us_tipo, us_usuario = :us_usuario, us_nome = :us_nome  where us_id = :us_id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);

                cmd.Parameters.Add("@us_senha", NpgsqlTypes.NpgsqlDbType.Text).Value = usuario.Us_senha;
                cmd.Parameters.Add("@us_endereco", NpgsqlTypes.NpgsqlDbType.Date).Value = usuario.Us_endereco;
                cmd.Parameters.Add("@us_telefone", NpgsqlTypes.NpgsqlDbType.Text).Value = usuario.Us_telefone;
                cmd.Parameters.Add("@us_tipo", NpgsqlTypes.NpgsqlDbType.Text).Value = usuario.Us_tipo;
                cmd.Parameters.Add("@us_usuario", NpgsqlTypes.NpgsqlDbType.Text).Value = usuario.Us_usuario;
                cmd.Parameters.Add("@us_nome", NpgsqlTypes.NpgsqlDbType.Text).Value = usuario.Us_nome;

                cmd.ExecuteNonQuery();

                cmd.Dispose();

                this.Desconectar();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Conectar ao BD e Alterar Dados " + ex.Message);
            }

        }

        public void Excluir(int id)
        {
            try
            {
                this.Conectar();
                String sql = "DELETE FROM Usuario WHERE us_id = " + id;
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

        public List<Usuario> listaUsuario()
        {
            this.Conectar();
            String sql = "SELECT us_id, us_senha, us_endereco, us_telefone, us_tipo, us_usuario, us_nome FROM Usuario ORDER BY us_id";
            List<Usuario> lista = new List<Usuario>();
            NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Us_id = Convert.ToInt32(dr["us_id"]);
                    usuario.Us_senha = dr["us_senha"].ToString();
                    usuario.Us_endereco = dr["us_endereco"].ToString();
                    usuario.Us_telefone = dr["us_telefone"].ToString();
                    usuario.Us_tipo = dr["us_tipo"].ToString();
                    usuario.Us_usuario = dr["us_usuario"].ToString();
                    usuario.Us_nome = dr["us_nome"].ToString();



                    lista.Add(usuario);
                }
            }
            this.Desconectar();
            return lista;
        }
        public Usuario RetornaUsuario(Usuario filtro)
        {
            Usuario retorno = new Usuario();
            try
            {
                this.Conectar();
                String sql = "select us_senha, us_endereco, us_telefone, us_tipo, us_usuario, us_nome FROM Usuario WHERE us_id = :id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, this.conexao);
                cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = filtro.Us_id;
                //Classe para absover uma resposta de um select
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    retorno.Us_senha = dr.GetString(dr.GetOrdinal("us_senha"));
                    retorno.Us_endereco = dr.GetString(dr.GetOrdinal("us_endereco"));
                    retorno.Us_telefone = dr.GetString(dr.GetOrdinal("us_telefone"));
                    retorno.Us_tipo = dr.GetString(dr.GetOrdinal("us_tipo"));
                    retorno.Us_usuario = dr.GetString(dr.GetOrdinal("us_usuario"));
                    retorno.Us_nome = dr.GetString(dr.GetOrdinal("us_nome"));


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
        }

    }
}

