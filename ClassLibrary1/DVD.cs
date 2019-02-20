using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve_copy
{
    public enum DVDtype { OneSided,TwoSided }
    class DVD:Storage
    {
        public DVD(double Capacity):base(Capacity)
        {

        }
        public double SpeedWrite { get; set; }
        public double SpeedRead { get; set; }
        public DVDtype DVDtype { get; set; }
        public override void CopyInfo()
        {
            
        }
    }
}
