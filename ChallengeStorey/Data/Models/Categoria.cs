using System.ComponentModel.DataAnnotations;

namespace ChallengeStorey.Data.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Item> Items { get; set; }
    }
}
