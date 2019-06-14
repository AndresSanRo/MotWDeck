using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MotWDeckAPI.Models
{
    [Table("GEAR")]
    public class GearItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID")]
        public int ID { get; set; }
        [Column("GEAR_NAME")]
        public String Name { get; set; }
        [Column("TAGS")]
        public String Tags { get; set; }
    }
}
