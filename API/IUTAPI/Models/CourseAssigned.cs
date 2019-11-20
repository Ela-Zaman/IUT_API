using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IUTAPI.Models
{
    [Table("courseassigned")]
    public class CourseAssigned
    {
        [Column("ca_serial")]
        [Key]
        public int Ca_id { get; set; }

        [Column("courseid")]
        public string CourseId { get; set; }

        [Column("facultyid")]
        public int Facultyid { get; set; }
        
        [Column("semester")]
        public int Semester { get; set; }
        
        [Column("batch")]
        public int Batch { get; set; }
    }
}

