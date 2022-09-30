using CPDesafio.Modelos.Entidades;
using CPDesafio.Modelos.Modelos;
using CPDesafio.Repositorios.Interfaces;
using CPDesafio.Repositorios.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPDesafio.Servicos
{
    public class PessoaTecnologiaServico:IPessoaTecnologiaServico
    {
        private readonly IPessoaTecnologiaRepositorio _PessoaTecnologiaRepositorio;

        public PessoaTecnologiaServico(IPessoaTecnologiaRepositorio PessoaTecnologiaRepositorio)
        {
            this._PessoaTecnologiaRepositorio = PessoaTecnologiaRepositorio;
        }
        
        public async Task<PessoaTecnologia> GetPessoaTecnologia(int PessoaTecnologiaId)
        {
            var PessoaTecnologia = await _PessoaTecnologiaRepositorio.ObterPessoaTecnologiaPorId(PessoaTecnologiaId);

            if (PessoaTecnologia == null)
                throw new ApplicationException("PessoaTecnologia não encontrada");
            return PessoaTecnologia;
        }
        public async Task<List<PessoaResponseModel>> GetPessoaTecnologias()
        {
            var PessoaTecnologias = await _PessoaTecnologiaRepositorio.ObterPessoaTecnologias();
            List<PessoaResponseModel> pessoaTecnologias = new List<PessoaResponseModel>();
            List<Tecnologia> tecnologias = new List<Tecnologia>();
            //var tecnologia = PessoaTecnologias.GroupBy(a => a.pessoa).OrderBy(a => a.Key);
            //foreach (var item in PessoaTecnologias)
            //{
                
            //    tecnologias.Add(item);
            //    pessoaTecnologias.Add(new PessoaResponseModel() { IdPessoa = item.IdPessoa, NomePessoa = item.pessoa.Nome });
            //}

            return pessoaTecnologias;
        }
        public void AdicionarPessoaTecnologia(PessoaTecnologia PessoaTecnologia)
        {
         
             _PessoaTecnologiaRepositorio.Adicionar(PessoaTecnologia);
             _PessoaTecnologiaRepositorio.Salvar();
            
        }
        public void AtualizarPessoaTecnologia(PessoaTecnologia PessoaTecnologia)
        {
            var PessoaTecnologiaexiste =  _PessoaTecnologiaRepositorio.ObterPessoaTecnologiaPorId(PessoaTecnologia.Id).Result;
            if (PessoaTecnologiaexiste != null)
            {
                //PessoaTecnologiaexiste.Nome = PessoaTecnologia.IdTecnologia;
                //PessoaTecnologiaexiste.Nivel = PessoaTecnologia.Nivel;
                _PessoaTecnologiaRepositorio.Atualizar(PessoaTecnologiaexiste);
                
            }


        }
        public  void RemoverPessoaTecnologia(int PessoaTecnologiaId)
        {
            var PessoaTecnologiaexiste =  _PessoaTecnologiaRepositorio.ObterPessoaTecnologiaPorId(PessoaTecnologiaId).Result;
            if (PessoaTecnologiaexiste != null)
            {
                _PessoaTecnologiaRepositorio.Remover(PessoaTecnologiaId);
                
            }


        }
    }
}
