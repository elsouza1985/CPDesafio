using CPDesafio.Modelos.Entidades;
using CPDesafio.Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CPDesafio.Servicos
{
    public interface ITecnologiaServico
    {
        Task<Tecnologia> GetTecnologia(int pessoaId);
        Task<List<Tecnologia>> GetTecnologias();
        void AdicionarTecnologia(Tecnologia tecnologia);

        void AtualizarTecnologia(Tecnologia tecnologia);

        void RemoverTecnologia(int tecnologiaId);
    }
}
