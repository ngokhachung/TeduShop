using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string ID { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Name { set; get; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Type { set; get; }

        public virtual IEnumerable<PostTag> PostTags { set; get; }
        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
    }
}