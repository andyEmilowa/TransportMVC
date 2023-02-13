using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregledNaMVC.Model
{
   public class Transport
    {
        private int kilometri;
        private string dayOrNight;

        public Transport(int kilometri, string dayOrNight)
        {
            this.Kilometri = kilometri;
            this.DayOrNight = dayOrNight;
        }
        public int Kilometri { get; set; }
        public string DayOrNight { get; set; }
        
        public double CalculatePrice()
        {
            double taksa = 0;
            double tarifa = 0;
            if (this.Kilometri < 20)
            {
                taksa = 0.70;
                if (this.dayOrNight == "day")
                {
                    tarifa = 0.79;
                }
                else
                {
                    tarifa = 0.9;
                }
            }
            else if (this.Kilometri < 100)
            {
                {
                    tarifa = 0.09;
                }
            }
            else
            {
                tarifa = 0.06;
            }
            return taksa + tarifa * this.Kilometri;
        }
            
        
    }
}
