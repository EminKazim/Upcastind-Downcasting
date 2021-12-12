using System;
using UpcastingDownCasting.Models;

namespace UpcastingDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Upcasting

            SamsungS22 samsungs22 = new SamsungS22();

            Smartphone samsungs223 = samsungs22;

            Smartphone iphone13 = new Iphone13();

            Smartphone[] smartphones = { samsungs22, samsungs223, iphone13 };

            foreach (var item in smartphones)
            {
                item.Quality();
            }

            #endregion

            #region Downcasting

            Smartphone iphone131 = new Iphone13();

            Iphone13 iphone132 = (Iphone13)iphone131;

            object[] objects = { 7, 9, "E", iphone131 };

            foreach (var item in objects)
            {
                if (item is Iphone13)
                {
                    ((Iphone13)item).Quality();
                }
                if (item is Iphone13 x)
                {
                    x.Quality();
                }
                Iphone13 M53 = item as Iphone13;
                if (iphone131 != null)
                {
                    ((Iphone13)item).Quality();
                }


            }

            #endregion

        }
    }
}
