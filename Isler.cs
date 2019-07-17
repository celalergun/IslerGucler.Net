using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslerGucler.Net
{
    public class Isler
    {
        public int IslerID { get; set; }
        
        // job name
        public string IsAdi { get; set; }
        
        // start time
        public DateTime Baslama { get; set; }
        
        // state
        public string Durum { get; set; }
        
        // is finished
        public bool BittiMi { get; set; }
    }
}
