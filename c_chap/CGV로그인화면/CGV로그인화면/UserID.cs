using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGV로그인화면
{

    class UserID
    {

        List<string> Name = new List<string>();
        List<string> Id = new List<string>();
        List<string> Pw = new List<string>();

        public void IDInsert() 
        {
            string newname = NewUser.newuser.tbNewName.Text;
            string newid = NewUser.newuser.tbNewId.Text;
            string newpw = NewUser.newuser.tbNewPw.Text;
            Name.Add(newname);
            Id.Add(newid);
            Pw.Add(newpw);
           
        }
       
    }
}
