using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
