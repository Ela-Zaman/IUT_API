using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IUTAPI.Models
{

    [Table("room")]
    public class Room
    {
        [Column("r_id")]
        [Key]
        public int R_id { get; set; }
        [Column("roomid")]
        public string RoomId { get; set; }
        [Column("roomno")]
        public int RoomNo { get; set; }
        [Column("level")]
        public int level { get; set; }

        [Column("roomname")]
        public string RoomName { get; set; }
        [Column("building")]
        public string Building { get; set; }
        [Column("roomtype")]
        public string RoomType { get; set; }


    }
}
