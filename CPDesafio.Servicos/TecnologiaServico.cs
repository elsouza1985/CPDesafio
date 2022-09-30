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
    public class TecnologiaServico:ITecnologiaServico
    {
        private readonly ITecnologiaRepositorio _TecnologiaRepositorio;

        public TecnologiaServico(ITecnologiaRepositorio TecnologiaRepositorio)
        {
            this._TecnologiaRepositorio = TecnologiaRepositorio;
        }
        
        public async Task<Tecnologia> GetTecnologia(int TecnologiaId)
        {
            var Tecnologia = await _TecnologiaRepositorio.ObterTecnologiaPorId(TecnologiaId);

            if (Tecnologia == null)
                throw new ApplicationException("Tecnologia não encontrada");
            return Tecnologia;
        }
        public async Task<List<Tecnologia>> GetTecnologias()
        {
            var Tecnologias = await _TecnologiaRepositorio.ObterTecnologias();

            return Tecnologias;
        }
        public void AdicionarTecnologia(Tecnologia Tecnologia)
        {
         
             _TecnologiaRepositorio.Adicionar(Tecnologia);
             _TecnologiaRepositorio.Salvar();
            
        }
        public void AtualizarTecnologia(Tecnologia Tecnologia)
        {
            var Tecnologiaexiste =  _TecnologiaRepositorio.ObterTecnologiaPorId(Tecnologia.Id).Result;
            if (Tecnologiaexiste != null)
            {
                Tecnologiaexiste.Nome = Tecnologia.Nome;
            
                _TecnologiaRepositorio.Atualizar(Tecnologiaexiste);
                
            }


        }
        public  void RemoverTecnologia(int TecnologiaId)
        {
            var Tecnologiaexiste =  _TecnologiaRepositorio.ObterTecnologiaPorId(TecnologiaId).Result;
            if (Tecnologiaexiste != null)
            {
                _TecnologiaRepositorio.Remover(TecnologiaId);
                
            }


        }
    }
}
