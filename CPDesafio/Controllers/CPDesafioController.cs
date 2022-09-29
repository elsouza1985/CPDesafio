using CPDesafio.Modelos.Entidades;
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
        public async Task<Pessoa> GetPessoas()
        {

            return await _pessoaServico.GetPessoa(1);
        }

        // GET api/<CPDesafioController>/5
        [HttpGet("{id}")]
        public string GetPessoa(int id)
        {

            return "value";
        }

        // POST api/<CPDesafioController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CPDesafioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CPDesafioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
