using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteTecnico.Domain.Entities
{
    public partial class Usuario
    {
        [Key]   
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        [StringLength(50)]
        public string Sobrenome { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }
        public int EscolaridadeId { get; set; }

        [ForeignKey("EscolaridadeId")]
        public Escolaridade Escolaridade { get; set; }
        public int HistoricoEscolarId { get; set; }

    }
}
