using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Assignment_3._4._1
{
    public class Coffee : Beverage
    {
        public enum Roast{ light, medium, dark}
        public bool IsDecaf {  get; set; }
        public string Variety { get; set; }
        public Roast Roasty { get; set; }
    }
}
