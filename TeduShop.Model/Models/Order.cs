using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(250)]
        [Required]
        public string CustomerName { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(250)]
        [Required]
        public string CustomerAddress { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(250)]
        [Required]
        public string CustomerEmail { set; get; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string CustomerMobile { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(250)]
        public string CustomerMessage { set; get; }

        public DateTime CreatedDate { set; get; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string CreatedBy { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(250)]
        public string PaymentMethod { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        [Required]
        public string PaymentStatus { set; get; }

        public bool Status { set; get; }

        public IEnumerable<OrderDetail> OrderDetails { set; get; }
        public IEnumerable<Product> Products { set; get; }
    }
}