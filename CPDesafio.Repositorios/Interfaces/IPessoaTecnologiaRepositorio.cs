using CPDesafio.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CPDesafio.Repositorios.Interfaces
{
    public interface IPessoaTecnologiaRepositorio
    {
        Task<PessoaTecnologia> ObterPessoaTecnologiaPorId(int PessoaTecnologiaId);
        Task<List<PessoaTecnologia>> ObterPessoaTecnologias();

        void Adicionar(PessoaTecnologia PessoaTecnologia);

        void Remover(int PessoaTecnologiaId);

        void Atualizar(PessoaTecnologia PessoaTecnologia);

        void Salvar();

    }
}
