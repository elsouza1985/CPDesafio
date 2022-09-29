using CPDesafio.Modelos.Entidades;
using CPDesafio.Repositorios.Interfaces;
using CPDesafio.Repositorios.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CPDesafio.Servicos
{
    public class PessoaServico:IPessoaServico
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;

        public PessoaServico(IPessoaRepositorio pessoaRepositorio)
        {
            this._pessoaRepositorio = pessoaRepositorio;
        }
        
        public async Task<Pessoa> GetPessoa(int pessoaId)
        {
            var pessoa = await _pessoaRepositorio.ObterPessoaPorId(pessoaId);

            if (pessoa == null)
                throw new ApplicationException("Pessoa não encontrada");
            return pessoa;
        }
    }
}
