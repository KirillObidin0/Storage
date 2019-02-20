using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Reserve_copy
{
    public class StorageService
    {
        public List<Storage> Storages = new List<Storage>();
        /// <summary>
        /// ●	расчет общего количества памяти всех устройств
        /// </summary>
        /// <returns></returns>
        public double GetTotalCapacity()
        {
            double sum = 0;
            for (int i = 0; i < Storages.Count; i++)
            {
                Storages[i].GetCapacity();
            }
            return sum;
        }
        /// <summary>
        /// ●	расчет времени необходимого для копирования;
        /// </summary>
        /// <param name="flash"></param>
        /// <param name="vol"></param>
        /// <returns></returns>
        public TimeSpan getCopyTime(Flash flash, double vol)
        {
            TimeSpan time;
            if (flash.GetFreeCapacity()<vol)
            {
                time = new TimeSpan(0, 0, 0);
                return time;
            }
            else
            {
                double tmp = vol / flash.Speed;
                time = TimeSpan.FromSeconds(tmp);
                return time;

            }
        }
        /// <summary>
        /// ●	расчет необходимого количества носителей информации представленных типов для переноса информации
        /// </summary>
        /// <param name="vol"></param>
        public void GetCountStorage(double vol)
        {
            for (int i = 0; i < Storages.Count; i++)
            {
                string info = string.Format("{0}) {1} COUNT: {2}", i + 1, Storages[i].getInfo(), vol / Storages[i].GetCapacity());
                Console.WriteLine(info);
            }
        }
        public void T(Flash storage, double vol)
        {
            if (storage.GetFreeCapacity()<vol)
            {
                throw new Exception("no free space");
            }
            else
            {
                for (int i = 0; i < getCopyTime(storage,vol).Minutes; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                Console.WriteLine("Copying completed");
            }
        }
    }
}
