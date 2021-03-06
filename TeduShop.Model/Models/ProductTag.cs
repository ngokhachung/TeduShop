﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        public int? ProductID { set; get; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string TagID { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get;}

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }

    }
}
