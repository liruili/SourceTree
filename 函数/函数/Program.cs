using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数
{

    class Program
    {
        static int Add(int var1,int var2)
        {
            int sum = var1 + var2;
            return sum;
        }

        static float Add(float var1, float var2)
        {
            float sum = var1 + var2;
            return sum;
        }

        struct Location
        {
            public string country;
            public string province;

            public string show()
            {
                return country + " " + province;
            }
        }

        static void Main(string[] args)
        {
            Location myLocation;
            myLocation.country = "中国";
            myLocation.province = "湖北";
            Console.WriteLine(myLocation.show());
            Console.ReadKey();
        }
    }
}
