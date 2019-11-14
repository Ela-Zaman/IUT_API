using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IUTAPI.Models
{
    [Table("facultymember")]
    public class FacultyMember
    {
        [Column("f_serial")]
        
        public int F_id { get; set; }
        [Column("employeeid")]
        [Key]
        public int EmployeeId { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("department")]
        public string Department { get; set; }
        [Column("mobilenumber")]
        public string MobileNumber { get; set; }
        [Column("designation")]
        public string Designation { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("roomnumber")]
        public string RoomNumber { get; set; }
        [Column("gender")]
        public string Gender { get; set; }
    }
}
