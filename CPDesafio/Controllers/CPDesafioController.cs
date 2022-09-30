using CPDesafio.Modelos.Entidades;
using CPDesafio.Modelos.Modelos;
using CPDesafio.Servicos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CPDesafio.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CPDesafioController : ControllerBase
    {
        private readonly IPessoaServico _pessoaServico;

        public CPDesafioController(IPessoaServico pessoaServico)
        {
            _pessoaServico = pessoaServico;
        }



        // GET: api/<CPDesafioController>
        [HttpGet]
        public async Task<List<Pessoa>> GetPessoas()
        {

            return await _pessoaServico.GetPessoas();
        }

        // GET api/<CPDesafioController>/5
        [HttpGet("{id}")]
        public async Task<Pessoa> GetPessoa(int id)
        {
            return await _pessoaServico.GetPessoa(id);
        }

        // POST api/<CPDesafioController>
        [HttpPost]
        public ActionResult Post([FromBody] Pessoa pessoa)
        {
            _pessoaServico.AdicionarPessoa(pessoa);
            return Ok();
        }

        // PUT api/<CPDesafioController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Pessoa pessoa)
        {
            _pessoaServico.AtualizarPessoa(pessoa);
            return Ok();
        }

        // DELETE api/<CPDesafioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _pessoaServico.RemoverPessoa(id);
        }
    }
}
