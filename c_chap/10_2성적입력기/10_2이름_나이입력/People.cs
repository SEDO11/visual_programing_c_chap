using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2이름_나이입력
{
    class People
    {
        private string name;
        private int age;

        public People()
        {
            name = "";
            age = 0;
        }
        public void setName(string Name)
        {
            name = Name; //입력된 이름 저장
        }
        public string getName()
        {
            return name;
        }
        public void setAge(int Age)
        {
            age = Age; //입력된 나이 저장
        }
        public int getAge()
        {
            return age;
        }
    }
}
