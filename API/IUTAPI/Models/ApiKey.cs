using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IUTAPI.Models
{
    [Table("apikey")]
    public class ApiKey
    {
        [Column("apikey")]
        [Key]

        public string Apikey { get; set; }
        [Column("username")]
        public string User { get; set; }
        [Column("projectname")]
        public string ProjectName { get; set; }
    }
}
