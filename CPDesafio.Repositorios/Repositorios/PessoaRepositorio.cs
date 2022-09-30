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
            return await _contexto.pessoas.FirstOrDefaultAsync(a => a.Id == pessoaId);
        }
        public async Task<List<Pessoa>> ObterPessoas()
        {
            return await _contexto.pessoas.ToListAsync();
        }
        public void Adicionar(Pessoa pessoa)
        {
            _contexto.Add(pessoa);
        }
        public void Remover(int pessoaId)
        {
            var pessoa = _contexto.pessoas.FirstOrDefault(a => a.Id == pessoaId);
           
            if (pessoa != null)
            {
                pessoa.Ativa = false;
                _contexto.Entry(pessoa).State = EntityState.Modified;
                _contexto.SaveChanges();
            }
           
          
        }

        public void Atualizar(Pessoa pessoa)
        {


            _contexto.Entry(pessoa).State = EntityState.Modified;
                _contexto.SaveChanges();
         
            
        }
        public void Salvar()
        {
            _contexto.SaveChanges();
            _contexto.Dispose();
        }

    }
}
