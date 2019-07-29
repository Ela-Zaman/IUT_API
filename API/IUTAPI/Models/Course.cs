using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IUTAPI.Models
{
    [Table("course")]
    public class Course
    {
        [Column("courseid")]
        [Key]

        public string CourseId { get; set; }
        [Column("coursetitle")]
        public string Title { get; set; }
        [Column("coursecredit")]
        public int Credit { get; set; }
        [Column("coursedept")]
        public string Deptartment { get; set; }
        [Column("coursesemester")]
        public int Semester { get; set; }
        [Column("coursetype")]
        public string Type { get; set; }
        [Column("prerequisitecourse")]
        public string PrerequisiteCourse { get; set; }
     
    }
}

