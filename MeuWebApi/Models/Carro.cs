using System.ComponentModel.DataAnnotations;

namespace MeuWebApi.Models
{
    public class Carro
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Cor { get; set; }
    }
}