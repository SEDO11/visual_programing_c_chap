using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace _14_1DB입출력
{
    class StdInfo
    {
        private const string SERVER = "localhost";
        private const string DATABASE = "cs_student";
        private const string UID = "root";
        private const string PASSWORD = "root";
        private MySqlConnection conn;

        public int No { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string HP { get; set; }

        public void InitializeDB()
        {
            //Mysql 연동
            MySqlBaseConnectionStringBuilder builder = new MySqlBaseConnectionStringBuilder();
            builder.Server = SERVER;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            builder.Database = DATABASE;
            string connstr = builder.ToString();
            builder = null;
            conn = new MySqlConnection(connstr);
        }

        public List<StdInfo> GetInfo()
        {
            List<StdInfo> si = new List<StdInfo>();
            string query = "select * from profil";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                int id = (int)rd["학번"];
                string name = (string)rd["이름"];
                string gender = (string)rd["성별"];
                string hp = (string)rd["전화번호"];
                // 방금 읽은 레코드를 StdInfo에 옮교 담기
                StdInfo s = new StdInfo();
                s.No = id;
                s.Name = name;
                s.Gender = gender;
                s.HP = hp;
                si.Add(s); //리스트 자료구조에 추가
            }
            conn.Close();
            return si;
        }
    }
}
