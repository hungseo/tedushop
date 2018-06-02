using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [MaxLength(256)]
        [Required]
        public string CustomerName { get; set; }

        [MaxLength(256)]
        [Required]
        public string CustomerAddress { get; set; }

        [MaxLength(256)]
        [Required]
        public string CustomerEmail { get; set; }

        [MaxLength(50)]
        [Required]
        public string CustomerMobile { get; set; }

        [MaxLength(256)]
        public string CustomerMessage { get; set; }

        [MaxLength(256)]
        public string PaymentMethod { get; set; }

        [MaxLength(256)]
        public string PaymentStatus { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool Status { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}