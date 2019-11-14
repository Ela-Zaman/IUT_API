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
        [Column("department")]
        public string Department { get; set; }
        [Column("courrseid")]
        public string Courseid { get; set; }


    }
}
