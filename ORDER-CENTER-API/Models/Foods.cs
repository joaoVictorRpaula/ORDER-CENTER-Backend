using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ORDER_CENTER_API.Models
{
    public class Foods
    {
        [Key]
        [Required]
        public int IdFood { get; set; }
        [Required]
        public string NameFood { get; set; }
        [JsonIgnore]
        public virtual List<Orders_Itens> Orders_Itens { get; set; }
    }
}
