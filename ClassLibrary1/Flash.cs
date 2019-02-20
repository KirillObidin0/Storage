using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve_copy
{
    public enum USBtype { USB20,USB30}
    public class Flash: Storage
    {
        public Flash(double capacity):base (capacity)
        {

        }
        public USBtype FlashType { get; set; }
        public int Speed { get; set; }
        public override void CopyInfo()
        {

        }

    }
}
