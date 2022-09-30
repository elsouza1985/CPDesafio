using CPDesafio.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPDesafio.Modelos.Modelos
{
    public class PessoaResponseModel
    {
        public int IdPessoa { get; set; }
        public string NomePessoa { get; set; }
        public int NivelPessoa { get; set; }
        public List<Tecnologia> Tecnologias { get; set; }

    }
}
