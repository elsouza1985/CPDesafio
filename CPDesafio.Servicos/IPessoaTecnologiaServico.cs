using CPDesafio.Modelos.Entidades;
using CPDesafio.Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CPDesafio.Servicos
{
    public interface IPessoaTecnologiaServico
    {
        Task<PessoaTecnologia> GetPessoaTecnologia(int PessoaTecnologiaId);
        Task<List<PessoaResponseModel>> GetPessoaTecnologias();
        void AdicionarPessoaTecnologia(PessoaTecnologia PessoaTecnologia);

        void AtualizarPessoaTecnologia(PessoaTecnologia PessoaTecnologia);

        void RemoverPessoaTecnologia(int PessoaTecnologiaId);
    }
}
