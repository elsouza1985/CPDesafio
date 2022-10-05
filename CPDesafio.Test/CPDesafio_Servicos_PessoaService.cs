using CPDesafio.Api.Controllers;
using CPDesafio.Modelos.Entidades;
using CPDesafio.Modelos.Modelos;
using CPDesafio.Repositorios.Interfaces;
using CPDesafio.Servicos;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CPDesafio.Test
{
    public class CPDesafio_Servicos_PessoaService
    {
        [Fact]
        public void PessoaService_Get_Pessoa()
        {
            //Arrange
            var listaPessoas = new List<PessoaResponseModel>();
            listaPessoas.Add(new PessoaResponseModel { IdPessoa = 1,NomePessoa = "teste", });
            var repo = new Mock<IPessoaTecnologiaServico>();
            repo.Setup(x => x.GetPessoaTecnologias().Result).Returns(listaPessoas);
            var sut = new PessoaController(repo.Object);

            //Act
            var response = new PessoaController(repo).GetPessoas();
        }
    }
}
