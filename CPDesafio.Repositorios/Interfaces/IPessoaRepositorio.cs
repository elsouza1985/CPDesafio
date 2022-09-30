using CPDesafio.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CPDesafio.Repositorios.Interfaces
{
    public interface IPessoaRepositorio
    {
        Task<Pessoa> ObterPessoaPorId(int pessoaId);
        Task<List<Pessoa>> ObterPessoas();

        void Adicionar(Pessoa pessoa);

        void Remover(int pessoaId);

        void Atualizar(Pessoa pessoa);

        void Salvar();

    }
}
