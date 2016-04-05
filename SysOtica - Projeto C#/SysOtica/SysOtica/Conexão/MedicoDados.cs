using ClassLibrary1;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexão
{
    public class MedicoDados : ConexaoBD, IMedicoDados 
    {
       
        public void Inserir(Medico medico)
        {
            try
            {
                this.Conectar();
                string sql = " INSERT INTO medico (md_nome, md_crm, md_email, md_telefone) values (:md_nome, :md_crm, :md_email,:md_telefone)";
                NpgsqlCommand comando = new NpgsqlCommand(sql, this.conexao);

                comando.Parameters.Add("@md_nome", NpgsqlTypes.NpgsqlDbType.Text).Value = medico.Md_nome;
                comando.Parameters.Add("@md_crm", NpgsqlTypes.NpgsqlDbType.Text).Value = medico.Md_crm;
                comando.Parameters.Add("@md_email", NpgsqlTypes.NpgsqlDbType.Text).Value = medico.Md_email;
                comando.Parameters.Add("@md_telefone", NpgsqlTypes.NpgsqlDbType.Text).Value = medico.Md_telefone;

                comando.ExecuteNonQuery();
                comando.Dispose();
                this.Desconectar();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar com o banco de dados" + ex.Message);
            }


        }

        public void Alterar(Medico medico)
        {

            try
            {
                this.Conectar();
                string sql = "UPDATE medico set md_nome= :md_nome, md_crm= :md_crm, md_email= :md_email, md_telefone= :md_telefone where md_id = :md_id";
                NpgsqlCommand comando = new NpgsqlCommand(sql, this.conexao);

                comando.Parameters.Add("@md_nome", NpgsqlTypes.NpgsqlDbType.Text).Value = medico.Md_nome;
                comando.Parameters.Add("@md_crm", NpgsqlTypes.NpgsqlDbType.Text).Value = medico.Md_crm;
                comando.Parameters.Add("@md_email", NpgsqlTypes.NpgsqlDbType.Text).Value = medico.Md_email;
                comando.Parameters.Add("@md_telefone", NpgsqlTypes.NpgsqlDbType.Text).Value = medico.Md_telefone;
                comando.Parameters.Add("@md_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = medico.Md_id;

                comando.ExecuteNonQuery();
                comando.Dispose();
                this.Desconectar();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexão com o banco" + ex.Message);
            }
        }

        public void Excluir(int id)
        {
            try
            {
                this.Conectar();
                string sql = " DELETE FROM medico WHERE md_id = " + id;
                NpgsqlCommand comando = new NpgsqlCommand(sql, this.conexao);

                comando.ExecuteNonQuery();
                comando.Dispose();
                this.Desconectar();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro de conexao com o banco" + ex.Message);

            }


        }

         public List <Medico> listarMedico()
        
        {
            this.Conectar();
           
            String sql = "SELECT md_id, md_nome, md_crm, md_email, md_telefone FROM Medico ORDER BY md_id";
            List<Medico> lista = new List<Medico>();
            NpgsqlCommand comando = new NpgsqlCommand(sql, this.conexao);

            NpgsqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows)

            {
                while (dr.Read())
                {
                    Medico med = new Medico();
                    med.Md_id = Convert.ToInt32(dr["md_id"]);
                    med.Md_nome = dr["md_nome"].ToString();
                    med.Md_crm = dr["md_crm"].ToString();
                    med.Md_email = dr["md_email"].ToString();
                    med.Md_telefone = dr["md_telefone"].ToString();

                    lista.Add(med);      
                }

            }
            this.Desconectar();
            return lista;
            
        }







        public void VerificaCopia(Medico medico)
        {
            throw new NotImplementedException();
        }
    }
}
