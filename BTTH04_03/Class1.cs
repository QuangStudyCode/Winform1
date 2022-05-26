using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH04_03
{
    public class Class1
    {
        public static bool LaSoNguyenTo(int number)
        {
            if (number <= 1)
            {
                return false;
            }if(number == 2)
            {
                return true;
            }if(number %2 == 0)
            {
                return false;
            }

            for(int i = 3; i < Math.Sqrt(number); i+=2)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool laSoChinhPhuong(int number)
        {
            int sqr = (int)Math.Sqrt(number);
            if (sqr * sqr == number)
            {
                return true;
            }
            return false;
        }

        public static bool laSoHoanHao(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number;
        }
    }
}
