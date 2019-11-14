using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IUTAPI.Models
{
    [Table("staff")]
    public class Staff
    {

            [Column("st_serial")]
            
            public int St_id { get; set; }
            [Column("staffid")]
             [Key]
          public string StaffId { get; set; }
            [Column("name")]
            public string Name { get; set; }
            [Column("designation")]
            public string Designation { get; set; }
            [Column("mobilenumber")]
            public string MobileNumber { get; set; }
        [Column("workarea")]
        public string WorkArea { get; set; }

        [Column("gender")]
            public string Gender { get; set; }
        }
    }

