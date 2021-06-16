using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace _14_1DB입출력
{
    class StdScore
    {
        private const string SERVER = "localhost";
        private const string DATABASE = "";
        public int Number { get; set; }
        public string Name { get; set; }
        public int Sc { get; set; }

        public void InitializeDB() {
            //MySql 연동
            MySqlBaseConnectionStringBuilder builder = new MySqlBaseConnectionStringBuilder();
            builder.Server = 
        
        }
    }
}
