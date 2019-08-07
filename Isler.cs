using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslerGucler.Net
{
    [Table("Isler")]
    public class Isler
    {
        [Key]
        [Autoincrement]
        public int IslerID { get; set; }
        
        // job name
        [Required]
        [MaxLength(100)]
        public string IsAdi { get; set; }
        
        // start time
        public DateTime Baslama { get; set; }
        
        // state
        public string Durum { get; set; }
        
        // is finished
        public bool BittiMi { get; set; }
    }
}
