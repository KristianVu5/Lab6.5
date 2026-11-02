using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6._4
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            // a) Чрез интерфейсна променлива
            Box box = new Box(30, 20);

            //interface variable
            Idimensions dimensions = box;
            Console.WriteLine("Size with interface variable:");
            Console.WriteLine("Length: {0} inches", dimensions.Length());
            Console.WriteLine("Width: {0} inches", dimensions.Width());

            // b) Чрез инстанция на класа Box
            Console.WriteLine("\nSize with Box instance:");
            Console.WriteLine("Length: {0} inches", box.Length());
            Console.WriteLine("Width: {0} inches", box.Width());

            // c) Чрез интерфейсна променлива за английски размери
            IEnglishDimensions englishDimensions = box;
            Console.WriteLine("\nSize with English dimensions interface variable:");
            Console.WriteLine("Length: {0} inches", englishDimensions.Length());
            Console.WriteLine("Width: {0} inches", englishDimensions.Width());

            // d) Чрез интерфейсна променлива за метрични размери
            IMetricDimensions metricDimensions = box;
            Console.WriteLine("\nSize with Metric dimensions interface variable:");
            Console.WriteLine("Length: {0} cm", metricDimensions.Length());
            Console.WriteLine("Width: {0} cm", metricDimensions.Width());
        }
    }
}
