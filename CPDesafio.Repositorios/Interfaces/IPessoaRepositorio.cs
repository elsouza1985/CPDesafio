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
    }
}
