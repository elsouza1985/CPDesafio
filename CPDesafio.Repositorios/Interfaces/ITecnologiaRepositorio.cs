using CPDesafio.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CPDesafio.Repositorios.Interfaces
{
    public interface ITecnologiaRepositorio
    {
        Task<Tecnologia> ObterTecnologiaPorId(int tecnologiaId);
        Task<List<Tecnologia>> ObterTecnologias();

        void Adicionar(Tecnologia tecnologia);

        void Remover(int tecnologiaId);

        void Atualizar(Tecnologia tecnologia);

        void Salvar();

    }
}
