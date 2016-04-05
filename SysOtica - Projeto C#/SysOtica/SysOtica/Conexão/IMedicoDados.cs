using System.Collections;
using System.Collections.Generic;

namespace SysOtica.Conexão
{
    public interface IMedicoDados
    {
        void Alterar(Medico medico);
        void Excluir(int id);
        void Inserir(Medico medico);
        void VerificaCopia(Medico medico);
        List <Medico> listarMedico();
        
        
    }
}