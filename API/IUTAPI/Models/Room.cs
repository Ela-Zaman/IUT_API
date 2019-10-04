using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IUTAPI.Models
{

    [Table("room")]
    public class Room
    {
        [Column("roomid")]
        [Key]

        public string RoomId { get; set; }
        [Column("roomno")]
        public int RoomNo { get; set; }
        [Column("roomname")]
        public string RoomName { get; set; }
        [Column("building")]
        public string Building { get; set; }
        [Column("roomtype")]
        public string RoomType { get; set; }


    }
}
