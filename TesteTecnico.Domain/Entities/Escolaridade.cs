using System.ComponentModel.DataAnnotations;

namespace TesteTecnico.Domain.Entities
{
    public partial class Escolaridade
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Descricao { get; set; }

    }
}
