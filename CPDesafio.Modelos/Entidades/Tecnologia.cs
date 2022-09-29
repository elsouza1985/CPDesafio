using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CPDesafio.Modelos.Entidades
{
    [Table("CPDesafio.Tecnologia")]
    public class Tecnologia
    {
        [Key]
        public int Id { get; set; }

        [Column]
        public string Nome { get; set; }
    }
}
