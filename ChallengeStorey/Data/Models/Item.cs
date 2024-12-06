using System.ComponentModel.DataAnnotations;

namespace ChallengeStorey.Data.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Elemento { get; set; }
        public int Valor { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
