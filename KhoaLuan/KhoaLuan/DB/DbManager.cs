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

        #region Login

        public static User Login(string userName, string passWord)
        {
            return dbManager.Users.FirstOrDefault(p => p.UserName == userName && p.PassWord == passWord);
        }

        public static User getUserByUserId(int userId)
        {
            return dbManager.Users.FirstOrDefault(p => p.UserId == userId);
        }

        #endregion

        #region Tree

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

        public static Tree GetTreeByName(string treeName)
        {
            try
            {
                return dbManager.Trees.FirstOrDefault(p => p.TreeName == treeName);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public static Tree GetTreeByNameNotId(int id, string treeName)
        {
            try
            {
                return dbManager.Trees.FirstOrDefault(p => p.TreeName == treeName && p.TreeId != id);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public static List<Tree> GetTreeByNameContentString(string treeName)
        {
            try
            {
                return dbManager.Trees.Where(p => p.TreeName.Contains(treeName)).ToList();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public static bool addTree(Tree tree)
        {
            try
            {
                dbManager.Trees.Add(tree);
                dbManager.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static bool updateTree(Tree tree, int treeId)
        {
            try
            {
                Tree updateTree = dbManager.Trees.FirstOrDefault(p => p.TreeId == treeId);
                updateTree.TreeName = tree.TreeName;
                updateTree.CatId = tree.CatId;
                updateTree.Quantity = tree.Quantity;
                updateTree.Cost = tree.Cost;
                updateTree.Description = tree.Description;
                dbManager.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static bool deleteTree(int treeId)
        {
            try
            {
                Tree delTree = dbManager.Trees.FirstOrDefault(p => p.TreeId == treeId);
                if (delTree != null)
                {
                    dbManager.Trees.Remove(delTree);
                    dbManager.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        #endregion

        #region Category

        public static Dictionary<int, Category> GetDicCategory()
        {
            return dbManager.Categories.ToDictionary(x => x.CatId, x => x);
        }

        public static List<Category> GetListCategory()
        {
            return dbManager.Categories.ToList();
        }

        public static Category GetCategoryByName(string catName)
        {
            return dbManager.Categories.FirstOrDefault(p => p.CatName == catName);
        }

        public static Category GetCategoryById(int catId)
        {
            return dbManager.Categories.FirstOrDefault(p => p.CatId == catId);
        }

        public static bool addCat(Category cat)
        {
            try
            {
                dbManager.Categories.Add(cat);
                dbManager.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static bool updateCat(Category cat, int catId)
        {
            try
            {
                Category updateCat = dbManager.Categories.FirstOrDefault(p => p.CatId == catId);
                updateCat.CatName = cat.CatName;
                dbManager.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static bool deleteCat(int catId)
        {
            try
            {
                Category delCat = dbManager.Categories.FirstOrDefault(p => p.CatId == catId);
                if (delCat != null)
                {
                    dbManager.Categories.Remove(delCat);
                    dbManager.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static int countTree(int catId)
        {
            try
            {
                return dbManager.Trees.Where(p => p.CatId == catId).ToList().Count;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }

        public static List<Category> GetCatByNameContentString(string catName)
        {
            try
            {
                return dbManager.Categories.Where(p => p.CatName.Contains(catName)).ToList();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public static Category GetCatByNameNotId(int id, string catName)
        {
            try
            {
                return dbManager.Categories.FirstOrDefault(p => p.CatName == catName && p.CatId != id);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        #endregion

        #region Bill

        public static Bill addBill(Bill newBill)
        {
            try
            {
                dbManager.Bills.Add(newBill);
                dbManager.SaveChanges();
                return newBill;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Bill> getListBillByDate(DateTime dateValue)
        {
            return dbManager.Bills.Where(x => ((DateTime)x.TimeChanged).Year == dateValue.Year
                && ((DateTime)x.TimeChanged).Month == dateValue.Month
                && ((DateTime)x.TimeChanged).Day == dateValue.Day).ToList();
        }

        public static List<Bill> getListBillByDateAndSearch(DateTime dateValue, string query)
        {
            return dbManager.Bills.Where(x => ((DateTime)x.TimeChanged).Year == dateValue.Year
                && ((DateTime)x.TimeChanged).Month == dateValue.Month
                && ((DateTime)x.TimeChanged).Day == dateValue.Day
                && (x.BillId.ToString().Contains(query) || x.CustomerName.Contains(query))).ToList();
        }

        #endregion

        #region Bill Detail

        public static void addListBillDetail(List<BillDetail> listBillDetail)
        {
            try
            {
                foreach (var item in listBillDetail)
                {
                    //  add bill detail
                    dbManager.BillDetails.Add(item);

                    //  update quantity tree
                    Tree currTree = dbManager.Trees.FirstOrDefault(p => p.TreeId == item.TreeId);
                    if (currTree != null)
                    {
                        currTree.Quantity -= item.Quantity;
                    }
                }
                dbManager.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Provider

        public static List<Provider> GetListProvider()
        {
            return dbManager.Providers.ToList();
        }

        public static List<Provider> GetListProviderByContainName(string name)
        {
            return dbManager.Providers.Where(p => p.ProviderName.Contains(name)).ToList();
        }

        public static Provider GetProviderByName(string name)
        {
            return dbManager.Providers.FirstOrDefault(p => p.ProviderName == name);
        }

        public static bool addProvider(Provider pro)
        {
            try
            {
                dbManager.Providers.Add(pro);
                dbManager.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static Provider GetProviderById(int proId)
        {
            return dbManager.Providers.FirstOrDefault(p => p.ProviderId == proId);
        }

        public static Provider GetProByNameNotId(int id, string proName)
        {
            try
            {
                return dbManager.Providers.FirstOrDefault(p => p.ProviderName == proName && p.ProviderId != id);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public static bool updateProvider(Provider pro, int proId)
        {
            try
            {
                Provider updatePro = dbManager.Providers.FirstOrDefault(p => p.ProviderId == proId);
                updatePro.ProviderName = pro.ProviderName;
                updatePro.Address = pro.Address;
                updatePro.Phone = pro.Phone;
                updatePro.Email = pro.Email;
                dbManager.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static bool deletePro(int proId)
        {
            try
            {
                Provider delPro = dbManager.Providers.FirstOrDefault(p => p.ProviderId == proId);
                if (delPro != null)
                {
                    dbManager.Providers.Remove(delPro);
                    dbManager.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        #endregion

    }
}
