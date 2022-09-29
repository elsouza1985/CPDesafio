using CPDesafio.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CPDesafio.Servicos
{
    public interface IPessoaServico
    {
        Task<Pessoa> GetPessoa(int pessoaId);
    }
}
