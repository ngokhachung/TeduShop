using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public int ID { set; get; }

        public DateTime VisitedDate { set; get; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string IPAddress { set; get; }
    }
}
