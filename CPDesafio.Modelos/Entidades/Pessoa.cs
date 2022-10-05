using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CPDesafio.Modelos.Entidades
{
    [Table("CPDesafio.Pessoa")]
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Column]
        public string Nome { get; set; }

        [Column]
        public int Nivel { get; set; }
        
        [Column]
        public bool Ativa { get; set; }

        [Column]
        public DateTime DataCriacao { get; set; }

         
        public virtual ICollection<PessoaTecnologia> TecnologiaList { get; set; }
    
    }
}
