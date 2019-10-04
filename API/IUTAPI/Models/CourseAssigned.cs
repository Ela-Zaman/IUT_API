using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IUTAPI.Models
{
    [Table("courseassigned")]
    public class CourseAssigned
    {
        
       
            [Column("c_a_id")]
            [Key]

            public int CourseAssignedId { get; set; }
            [Column("employeeid")]
            public int EmployeeId { get; set; }
            [Column("semester")]
            public string Semester { get; set; }
            [Column("batch")]
            public int Batch { get; set; }
            [Column("courseid")]
            public string CourseId{ get; set; }
            



        }

    }

