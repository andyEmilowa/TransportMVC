using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregledNaMVC.Views
{
   public class Display
    {
        public Display()
        {
            this.Kilometri = 0;
            this.DayOrNight = "";
            this.TotalPrice = 0;
            this.GetValues();
        }
        public int Kilometri { get; set; }
        public string DayOrNight { get; set; }
        public double TotalPrice { get; set; }
        public void GetValues()
        {
            Console.WriteLine("Enter kilometri:");
            this.Kilometri = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter time of day:");
            this.DayOrNight = Console.ReadLine();
        }

        public void ShowPrie()
        {
            Console.WriteLine($"The cheapest price is: {this.TotalPrice:f2}");
        }
    }
}
