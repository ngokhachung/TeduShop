using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        [Required]
        public string Name { set; get; }


        [Column(TypeName = "nvarchar")]
        [StringLength(250)]
        public string Description { set; get; }


        [Column(TypeName = "nvarchar")]
        [StringLength(500)]
        [Required]
        public string Image { set; get;}

        [Column(TypeName = "nvarchar")]
        [StringLength(500)]
        [Required]
        public string URL { set; get; }

        public bool? DisplayOrder { set; get; }
        public bool Status { set; get; }
    }
}
