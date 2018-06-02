using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(64)]
        public string ID { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        [MaxLength(65)]
        public string Type { get; set; }
    }
}