using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(250)]
        [Required]
        public string Name { set; get; }

        [Column(TypeName = "varchar")]
        [StringLength(250)]
        [Required]
        public string Alias { set; get; }

        public int ParentID { set; get; }

        public int DisplayOrder { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(500)]
        public string Image { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Post> Post { set; get; }
    }
}