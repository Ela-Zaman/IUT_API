using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IUTAPI.Models
{
    [Table("department")]
    public class Department
    {
        [Column("d_id")]
        [Key]
        public int d_id { get; set; }

        [Column("deptname")]
        public string DepartmentName { get; set; }
    }
}
