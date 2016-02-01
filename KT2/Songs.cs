using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT2
{
    class Songs
    {
        //Put here song name, artist and lenght

        public string CDName { get; set; }
        public string TrackName { get; set; }
        public string Artist { get; set; }
        public int Lenght { get; set; }

        public override string ToString()
        {
            return CDName + " " + TrackName + " " + Artist + " " + Lenght;
        }

    }
}
