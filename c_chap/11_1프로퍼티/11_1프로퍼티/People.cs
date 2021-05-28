using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1프로퍼티
{
    class People
    {
        public string name { set; get; }
        public int age { set; get; }
        /*
        string name { set; get; }
        int age { set; get; }
       
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        */
    }
}
