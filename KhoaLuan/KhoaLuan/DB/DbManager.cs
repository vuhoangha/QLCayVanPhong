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

        public static List<Tree> GetAllTree()
        {
            return dbManager.Trees.ToList();
        }

        public static Tree GetTreeById(int treeId)
        {
            return dbManager.Trees.Where(p => p.TreeId == treeId).FirstOrDefault();
        }

        public static Dictionary<int, Tree> GetDicTree()
        {
            return dbManager.Trees.ToDictionary(x => x.TreeId, x => x);
        }

        public static Dictionary<int, Category> GetDicCategory()
        {
            return dbManager.Categories.ToDictionary(x => x.CatId, x => x);
        }

        public static List<Category> GetListCategory()
        {
            return dbManager.Categories.ToList();
        }

    }
}
