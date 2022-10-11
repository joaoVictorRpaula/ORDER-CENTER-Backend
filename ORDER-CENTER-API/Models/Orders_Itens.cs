using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ORDER_CENTER_API.Models
{
    public class Orders_Itens
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int FoodId { get; set; }
        [Required]
        public int Quantity { get; set; }
        public virtual Foods Food { get; set; }
        public virtual Orders Orders { get; set; }
        [JsonIgnore]
        public virtual List<TempOrders> TempOrders { get; set; }

    }
}
