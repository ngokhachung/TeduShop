using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Post")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(250)]
        [Required]
        public string Name { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(250)]
        [Required]
        public string Alias { set; get; }

        public int CategoryID { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(500)]
        public string Image { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(500)]
        public string Description { set; get; }

        [Column(TypeName = "nvarchar")]
        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { set; get; }

        public virtual IEnumerable<PostTag> PostTags { set; get; }
    }
}