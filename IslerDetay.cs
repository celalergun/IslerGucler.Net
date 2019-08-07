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
    [Table("IslerDetay")]
    public class IslerDetay
    {
        [Key]
        [Autoincrement]
        public int IslerDetayID { get; set; }

        // master ID
        //[ForeignKey("IslerDetayIsler")]
        public int IslerID { get; set; }

        // start date/time
        public DateTime Baslama { get; set; }

        // finish time
        public DateTime Bitis { get; set; }

        // description
        public string Aciklama { get; set; }
    }
}
