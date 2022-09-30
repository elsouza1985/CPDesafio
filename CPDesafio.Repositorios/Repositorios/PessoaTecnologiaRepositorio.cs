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
    public class PessoaTecnologiaRepositorio:IPessoaTecnologiaRepositorio
    {
        private readonly CPDesafioContexto _contexto = null;

        public PessoaTecnologiaRepositorio(CPDesafioContexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<PessoaTecnologia> ObterPessoaTecnologiaPorId(int PessoaTecnologiaId)
        {
            return await _contexto.pessoaTecnologias.FirstOrDefaultAsync(a => a.Id == PessoaTecnologiaId);
        }
        public async Task<List<PessoaTecnologia>> ObterPessoaTecnologias()
        {
            return await _contexto.pessoaTecnologias.ToListAsync();
        }
        public void Adicionar(PessoaTecnologia PessoaTecnologia)
        {
            _contexto.Add(PessoaTecnologia);
        }
        public void Remover(int PessoaTecnologiaId)
        {
            var PessoaTecnologia = _contexto.pessoaTecnologias.FirstOrDefault(a => a.Id == PessoaTecnologiaId);
           
            if (PessoaTecnologia != null)
            {
                
                _contexto.Entry(PessoaTecnologia).State = EntityState.Deleted;
                _contexto.SaveChanges();
            }
           
          
        }

        public void Atualizar(PessoaTecnologia PessoaTecnologia)
        {


            _contexto.Entry(PessoaTecnologia).State = EntityState.Modified;
                _contexto.SaveChanges();
         
            
        }
        public void Salvar()
        {
            _contexto.SaveChanges();
            _contexto.Dispose();
        }

    }
}
