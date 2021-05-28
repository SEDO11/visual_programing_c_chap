using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1사용자클래스
{
    class UserAcc
    {
        int Start, End, total = 0;
        public UserAcc(int S, int E) //public을 해줘야 오류가 안뜸
        {
            Start = S;
            End = E;
        }
        public int Accumulate() //public을 해줘야 오류가 안뜸
        {
            for (int i = Start; i <= End; i++)
            {
                total += i;
            }
            return total;
        }
    }
}
