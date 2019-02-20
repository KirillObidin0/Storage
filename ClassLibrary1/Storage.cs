using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserve_copy
{
    public abstract class Storage
    {
        public Storage(double capacity)
        {
            this.Capacity = capacity;

        }
        public double Memory { get; set; }
        protected string Name { get; set; }
        protected string Model { get; set; }
        private double Capacity { get; set; }
        public virtual double GetCapacity() { return Capacity; }
        public abstract void CopyInfo();
        public virtual double GetFreeCapacity()
        {
            return Capacity - Memory;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("{0} ({1}) - {2}gb",Name,Model,Capacity);
        }
        public string getInfo()
        {
            return "";
        }
    }
}
