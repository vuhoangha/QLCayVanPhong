using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoaLuan.DB
{
    public class DbManager
    {
        public static DbEntities dbManager = new DbEntities();

        public static bool Login(string userName,string passWord){
            return dbManager.Users.FirstOrDefault(p => p.UserName == userName && p.PassWord == passWord) == null ? false : true;
        }

    }
}
