using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IUTAPI.Models
{

    [Table("student")]
    public class Student
    {
        [Column("s_serial")]
       
        public int S_id { get; set; }
        [Column("id")]

        [Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }


        [Column("department")]
        public string Department { get; set; }


        [Column("programme")]
        public string Programme { get; set; }


        [Column("batch")]
        public int Batch { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("email")]
        public string Email { get; set; }
       
        [Column("gender")]
        public string Gender { get; set; }
    }
}
