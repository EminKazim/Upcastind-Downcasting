using System;
using System.Collections.Generic;
using System.Text;

namespace UpcastingDownCasting.Models
{
    abstract class Smartphone
    {
        public virtual void Quality()
        {
            Console.WriteLine("The quality of a smartphone");
        }
    }
}
