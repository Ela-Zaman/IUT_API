using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IUTAPI.Models
{
    [Table("departmentalcourse")]
    public class DepartmentalCourse
    {
        [Column("dc_id")]
        [Key]
        public int DC_id { get; set; }
        [Column("d_id")]
        public int D_id { get; set; }
        [Column("c_id")]
        public int C_id { get; set; }


    }
}
