using System.ComponentModel.DataAnnotations;

namespace ORDER_CENTER_API.Models
{
    public class TempOrders
    {
        [Key]
        public int Id { get; set; }
        public int Orders_ItensId { get; set; }
        public virtual Orders_Itens Orders_Itens { get; set; }

    }
}
