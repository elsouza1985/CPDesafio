using CPDesafio.Modelos.Entidades;
using CPDesafio.Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CPDesafio.Servicos
{
    public interface IPessoaServico
    {
        Task<Pessoa> GetPessoa(int pessoaId);
        Task<List<Pessoa>> GetPessoas();
        void AdicionarPessoa(Pessoa pessoa);

        void AtualizarPessoa(Pessoa pessoa);

        void RemoverPessoa(int pessoaId);
    }
}
