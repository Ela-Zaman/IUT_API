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
            [Column("F_id")]
            
            public int F_id { get; set; }
            [Column("semester")]
            public string Semester { get; set; }
            [Column("batch")]
            public int Batch { get; set; }
            [Column("C_id")]
           
            public string CourseId{ get; set; }
            



        }

    }

