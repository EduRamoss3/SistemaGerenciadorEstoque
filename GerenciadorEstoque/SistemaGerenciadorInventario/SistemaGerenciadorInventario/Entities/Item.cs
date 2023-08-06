using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using Type = SistemaGerenciadorInventario.Entities.Enum.Type;

namespace SistemaGerenciadorInventario.Entities
{
    internal class Item
    {
        public int Id { get; set; }
        [Required]
        [MinLength(5)]
        public string Name { get; set; }
        [Required]
        public SqlMoney Price { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "O valor mínimo é 1.")]
        public int Quantity { get; set; }
        public DateTime DataEnter { get; set; }
        [Required]
        [Range(1, 8, ErrorMessage = "Escolha um tipo.")]
        public Type type { get; set; }
        public SqlMoney Total { get; set; }
       public Item()
        {

        }
        public Item(int id, string name, SqlMoney price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
