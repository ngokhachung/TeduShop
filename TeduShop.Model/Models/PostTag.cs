﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [Column(Order = 1)]
        public int? PostID { set; get; }

        [Key]
        [Column(TypeName = "varchar", Order = 2)]
        [StringLength(50)]
        [Required]
        public string TagID { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }

        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }
    }
}