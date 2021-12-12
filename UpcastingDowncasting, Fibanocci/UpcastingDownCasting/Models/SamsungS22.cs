using System;
using System.Collections.Generic;
using System.Text;

namespace UpcastingDownCasting.Models
{
    class SamsungS22:Samsung
    {
        public int Performance { get; set; }

        public override void Quality()
        {
            Console.WriteLine("The quality of SamsungS22 is good");
        }
    }
}
