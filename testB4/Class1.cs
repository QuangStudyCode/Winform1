using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testB4
{
    public class Class1
    {
        public static bool laSoNguyenTo(int nummber)
        {
           if(nummber <= 1)
            {
                return false;

            }if (nummber == 2)
            {
                return true;
            }
            if(nummber % 2==0)
            {
                return false;
            }
            for(int i=3; i<Math.Sqrt(nummber); i += 2)
            {
                if(nummber % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool laSoChinhPhuong(int nummber)
        {
            int sqr = (int)Math.Sqrt(nummber);

            if((sqr*sqr) == nummber)
            {
                return true;
            }return false;
            
        }

        public static bool laSoHoanChinh(int nummber)
        {
            int sum = 0;
            for(int i = 1; i < nummber; i++)
            {
                if (nummber % i == 0)
                {
                    sum += i;
                }
            }
            return sum == nummber;

        }
    }
}
