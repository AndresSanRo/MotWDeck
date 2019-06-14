using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MotWDeckAPI.Models
{   
    [Table("MOVES")]
    public class Move
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID")]
        public int ID { get; set; }
        [Column("PLB_ID")]
        public int PlaybookId { get; set; }
        [Column("MOVE_TYPE")]
        public String Type { get; set; }
        [Column("MOVE_NAME")]
        public String Name { get; set; }
        [Column("MOVE_DESCRIPTION")]
        public String Description { get; set; }
    }
}
