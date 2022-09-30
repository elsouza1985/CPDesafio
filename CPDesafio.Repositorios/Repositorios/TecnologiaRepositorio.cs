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
    public class TecnologiaRepositorio:ITecnologiaRepositorio
    {
        private readonly CPDesafioContexto _contexto = null;

        public TecnologiaRepositorio(CPDesafioContexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<Tecnologia> ObterTecnologiaPorId(int TecnologiaId)
        {
            return await _contexto.tecnologia.FirstOrDefaultAsync(a => a.Id == TecnologiaId);
        }
        public async Task<List<Tecnologia>> ObterTecnologias()
        {
            return await _contexto.tecnologia.ToListAsync();
        }
        public void Adicionar(Tecnologia Tecnologia)
        {
            _contexto.Add(Tecnologia);
        }
        public void Remover(int TecnologiaId)
        {
            var Tecnologia = _contexto.tecnologia.FirstOrDefault(a => a.Id == TecnologiaId);
           
            if (Tecnologia != null)
            {
//                Tecnologia.Ativa = false;
                _contexto.Entry(Tecnologia).State = EntityState.Modified;
                _contexto.SaveChanges();
            }
           
          
        }

        public void Atualizar(Tecnologia Tecnologia)
        {


            _contexto.Entry(Tecnologia).State = EntityState.Modified;
                _contexto.SaveChanges();
         
            
        }
        public void Salvar()
        {
            _contexto.SaveChanges();
            _contexto.Dispose();
        }

    }
}
