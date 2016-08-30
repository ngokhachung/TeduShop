using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        public int ID { set; get; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Code { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(250)]
        public string ValueString { set; get; }

        public int? ValueInt { set; get; }
    }
}