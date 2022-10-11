using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ORDER_CENTER_API.Models
{
    public class Orders
    {
        [Key]
        [Required]
        public int IdOrder { get; set; }
        [Required]
        public string ClientName { get; set; }
        [JsonIgnore]
        public virtual List<Orders_Itens> Orders_Itens { get; set; }
    }
}
