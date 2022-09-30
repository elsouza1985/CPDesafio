using CPDesafio.Modelos.Entidades;
using CPDesafio.Modelos.Modelos;
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
        public async Task<List<Pessoa>> GetPessoas()
        {
            var pessoas = await _pessoaRepositorio.ObterPessoas();

            return pessoas;
        }
        public void AdicionarPessoa(Pessoa pessoa)
        {
         
             _pessoaRepositorio.Adicionar(pessoa);
             _pessoaRepositorio.Salvar();
            
        }
        public void AtualizarPessoa(Pessoa pessoa)
        {
            var pessoaexiste =  _pessoaRepositorio.ObterPessoaPorId(pessoa.Id).Result;
            if (pessoaexiste != null)
            {
                pessoaexiste.Nome = pessoa.Nome;
                pessoaexiste.Nivel = pessoa.Nivel;
                _pessoaRepositorio.Atualizar(pessoaexiste);
                
            }


        }
        public  void RemoverPessoa(int pessoaId)
        {
            var pessoaexiste =  _pessoaRepositorio.ObterPessoaPorId(pessoaId).Result;
            if (pessoaexiste != null)
            {
                _pessoaRepositorio.Remover(pessoaId);
                
            }


        }
    }
}
