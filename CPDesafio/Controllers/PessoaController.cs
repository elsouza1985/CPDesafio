using CPDesafio.Modelos.Entidades;
using CPDesafio.Modelos.Modelos;
using CPDesafio.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CPDesafio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaTecnologiaServico _pessoaServico;

        public PessoaController(IPessoaTecnologiaServico pessoaServico)
        {
            _pessoaServico = pessoaServico;
        }



        // GET: api/<CPDesafioController>
        [HttpGet]
        public async Task<List<PessoaResponseModel>> GetPessoas()
        {
            return await _pessoaServico.GetPessoaTecnologias();
           
        }

    }
}
