using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MotWDeckAPI.Models
{
    [Table("IMPROVEMENTS")]
    public class Improvement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID")]
        public int ID { get; set; }
        [Column("IMP_NAME")]
        public String Name { get; set; }
        [Column("ADVANCED")]
        public bool Advanced { get; set; }
    }
}
