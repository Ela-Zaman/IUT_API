using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IUTAPI.Models
{
    [Table("apikey")]
    public class Apikey
    {

        [Column("apikey")]
        [Key]

        public string apikey { get; set; }
        [Column("username")]
        public string UserName { get; set; }
        [Column("useremail")]
        public string UserEmail { get; set; }
        

    }
}
