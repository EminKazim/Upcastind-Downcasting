using System;
using System.Collections.Generic;
using System.Text;

namespace GetSetEncapsul.Model
{
    class Encapsul
    {        
        private int studentAge;

        public int Age
        {

            get
            {
                return studentAge;
            }

            set
            {
                studentAge = value;
            }

        }
    }
}
