using CPDesafio.Modelos.Entidades;
using CPDesafio.Repositorios.Contexto;
using CPDesafio.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CPDesafio.Repositorios.Repositorios
{
    public class PessoaRepositorio:IPessoaRepositorio
    {
        private readonly CPDesafioContexto _contexto = null;

        public PessoaRepositorio(CPDesafioContexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<Pessoa> ObterPessoaPorId(int pessoaId)
        {
            return await _contexto.pessoas.SingleAsync(a => a.Id == pessoaId);
        }
        public List<Pessoa> ObterPessoas()
        {
            return _contexto.pessoas.ToList();
        }
        public void Adicionar(Pessoa pessoa)
        {
            _contexto.Add(pessoa);
        }
        public void Remover(Pessoa pessoa)
        {
            _contexto.Remove(pessoa);
        }

        public void Atualizar(Pessoa pessoa)
        {
            _contexto.Update(pessoa);
        }
        public void Salvar()
        {
            _contexto.SaveChanges();
        }



    }
}
