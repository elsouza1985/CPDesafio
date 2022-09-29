using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CPDesafio.Modelos.Entidades
{
    [Table("CPDesafio.PessoaTecnologia")]
    public class PessoaTecnologia
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("IdPessoa")]
        public int IdPessoa { get; set; }
        
        [Column("IdTecnologia")]
        public int IdTecnologia { get; set; }


    }
}
