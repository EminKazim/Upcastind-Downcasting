using System;
using System.Collections.Generic;
using System.Text;

namespace UpcastingDownCasting.Models
{
    class Iphone13: Apple
    {
        public int QualityRating { get; set; }

        public override void Quality()
        {
            Console.WriteLine("The quality of Iphone13 is the best");
        }
    }
}
