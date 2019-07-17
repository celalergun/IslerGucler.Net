using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslerGucler.Net
{
    public class IslerDetay
    {
        public int IslerDetayID { get; set; }

        // master ID
        public int IslerID { get; set; }

        // start date/time
        public DateTime Baslama { get; set; }

        // finish time
        public DateTime Bitis { get; set; }

        // description
        public string Aciklama { get; set; }
    }
}
