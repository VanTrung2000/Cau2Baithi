using System;
using System.Collections.Generic;
using System.Text;

namespace Cau2
{
    class Post:IPost
    {
        public int ID { set; get; }
        public string Title { set; get; }
        public string Content { set; get; }
        public string Author { set; get; }

        public float AverageRate { set; get; }

        public int[] Rates = new int[3];
        public void CalculatorRate()
        {
            AverageRate = (Rates[0] + Rates[1] + Rates[2]) / 3;
        }

        public void Display()
        {
            Console.WriteLine("ID : " + ID);
            Console.WriteLine("Title : " + Title);
            Console.WriteLine("Content :" + Content);
            Console.WriteLine("Author :" + Author);
            Console.WriteLine("AverageRate :" + AverageRate);
        }
    }
}
