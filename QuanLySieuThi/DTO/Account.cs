using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLySieuThi.DTO
{
    class Account
    {
        private string userName;
        private string passWord;
        private string displayName;
        private string type;

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string Type { get => type; set => type = value; }

        public Account()
        {

        }
        public Account(string userName, string displayName, string passWord, string type)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.displayName = displayName;
            this.type = type;
        }
        public Account(DataRow dataRow)
        {
            this.userName = dataRow["UserName"].ToString();
            this.passWord = dataRow["PassWord"].ToString();
            this.displayName = dataRow["DisplayName"].ToString();
            this.type = dataRow["TYPE"].ToString();
        }
    }
}
