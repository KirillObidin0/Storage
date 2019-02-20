using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve_copy
{
    class HDD:Storage
    {
        public HDD(double Capacity):base(Capacity)
        {

        }
        public override void CopyInfo()
        {
            
        }
        public int CountSections { get; set; }
        public USBtype USBtype { get; set; }
        public double SectionVolume { get; set; }
    }
}
