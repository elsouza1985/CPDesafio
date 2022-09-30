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

        
        [ForeignKey("IdPessoa")]
        public virtual Pessoa pessoa { get; set; }

        [ForeignKey("IdTecnologia")]
        public virtual Tecnologia tecnologia { get; set; }

   





    }
}
