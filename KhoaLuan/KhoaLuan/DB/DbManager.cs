using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KhoaLuan.DB
{
    public class DbManager
    {
        public static DBEntities dbManager = new DBEntities();

        #region Login

        public static Account Login(string userName, string passWord)
        {
            return dbManager.Accounts.FirstOrDefault(p => p.UserName == userName && p.PassWord == passWord && p.Status == 1);
        }

        public static Account getUserByUserId(int userId)
        {
            return dbManager.Accounts.FirstOrDefault(p => p.UserId == userId);
        }

        #endregion

        #region Tree

        public static List<Tree> GetAllTree()
        {
            return dbManager.Trees.Where(p => p.Status == 1).ToList();
        }

        public static Tree GetTreeById(int treeId)
        {
            return dbManager.Trees.Where(p => p.TreeId == treeId && p.Status == 1).FirstOrDefault();
        }

        public static Tree GetTreeByName(string treeName)
        {
            try
            {
                return dbManager.Trees.FirstOrDefault(p => p.TreeName == treeName && p.Status == 1);
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
                return dbManager.Trees.FirstOrDefault(p => p.TreeName == treeName && p.TreeId != id && p.Status == 1);
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
                return dbManager.Trees.Where(p => p.TreeName.Contains(treeName) && p.Status == 1).ToList();
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
                tree.Status = 1;
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

        public static Dictionary<int, Tree> GetDicTree()
        {
            return dbManager.Trees.Where(p => p.Status == 1).ToDictionary(x => x.TreeId, x => x);
        }

        public static Dictionary<int, Tree> GetDicTreeAll()
        {
            return dbManager.Trees.ToDictionary(x => x.TreeId, x => x);
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

        public static bool updateListTree(List<Tree> listTree)
        {
            try
            {
                foreach (var tree in listTree)
                {
                    Tree updateTree = dbManager.Trees.FirstOrDefault(p => p.TreeId == tree.TreeId);
                    updateTree.Quantity = tree.Quantity;
                    dbManager.SaveChanges();
                }
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
                    delTree.Status = 0;
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
            return dbManager.Categories.Where(p => p.Status == 1).ToDictionary(x => x.CatId, x => x);
        }

        public static List<Category> GetListCategory()
        {
            return dbManager.Categories.Where(p => p.Status == 1).ToList();
        }

        public static Category GetCategoryByName(string catName)
        {
            return dbManager.Categories.FirstOrDefault(p => p.CatName == catName && p.Status == 1);
        }

        public static Category GetCategoryById(int catId)
        {
            return dbManager.Categories.FirstOrDefault(p => p.CatId == catId && p.Status == 1);
        }

        public static bool addCat(Category cat)
        {
            try
            {
                cat.Status = 1;
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
                    delCat.Status = 0;
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
                return dbManager.Trees.Where(p => p.CatId == catId && p.Status == 1).ToList().Count;
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
                return dbManager.Categories.Where(p => p.CatName.Contains(catName) && p.Status == 1).ToList();
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
                return dbManager.Categories.FirstOrDefault(p => p.CatName == catName && p.CatId != id && p.Status == 1);
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

        public static List<Bill> getListBillByDateAndSearch(string query)
        {
            return dbManager.Bills.Where(x => (x.BillId.ToString().Contains(query))).ToList();
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

        public static List<BillDetail> getBillDetailByBillId(int billId)
        {
            try
            {
                return dbManager.BillDetails.Where(p => p.BillId == billId).ToList();
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
            return dbManager.Providers.Where(p => p.Status == 1).ToList();
        }

        public static List<Provider> GetListProviderByContainName(string name)
        {
            return dbManager.Providers.Where(p => p.ProviderName.Contains(name) && p.Status == 1).ToList();
        }

        public static Provider GetProviderByName(string name)
        {
            return dbManager.Providers.FirstOrDefault(p => p.ProviderName == name && p.Status == 1);
        }

        public static bool addProvider(Provider pro)
        {
            try
            {
                pro.Status = 1;
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
            return dbManager.Providers.FirstOrDefault(p => p.ProviderId == proId && p.Status == 1);
        }

        public static Provider GetProByNameNotId(int id, string proName)
        {
            try
            {
                return dbManager.Providers.FirstOrDefault(p => p.ProviderName == proName && p.ProviderId != id && p.Status == 1);
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
                    delPro.Status = 0;
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

        #region Import

        public static Import addImport(Import newImport)
        {
            try
            {
                dbManager.Imports.Add(newImport);
                dbManager.SaveChanges();
                return newImport;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Import> getListImportByDate(DateTime dateValue)
        {
            return dbManager.Imports.Where(x => ((DateTime)x.TimeChanged).Year == dateValue.Year
                && ((DateTime)x.TimeChanged).Month == dateValue.Month
                && ((DateTime)x.TimeChanged).Day == dateValue.Day).ToList();
        }

        public static List<Import> getListImportByDateAndSearch(string query)
        {
            return dbManager.Imports.Where(x => x.ImportId.ToString().Contains(query)).ToList();
        }

        #endregion

        #region Bill Detail

        public static void addListImportDetail(List<ImportDetail> listImportDetail)
        {
            try
            {
                foreach (var item in listImportDetail)
                {
                    //  add bill detail
                    dbManager.ImportDetails.Add(item);

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

        public static List<ImportDetail> getImportDetailByBillId(int importId)
        {
            try
            {
                return dbManager.ImportDetails.Where(p => p.ImportId == importId).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Account

        public static List<Account> GetAllUser(string userName)
        {
            if (userName == "admin")
            {
                return dbManager.Accounts.Where(p => p.Status == 1).ToList();
            }
            return dbManager.Accounts.Where(p => p.UserName == userName && p.Status == 1).ToList();
        }

        public static Account GetUserById(int userId)
        {
            return dbManager.Accounts.FirstOrDefault(p => p.UserId == userId && p.Status == 1);
        }

        public static bool addUser(Account user)
        {
            try
            {
                #region Check validate

                Account valid = dbManager.Accounts.Where(p => p.UserName == user.UserName).FirstOrDefault();
                if (valid != null)
                {
                    return false;
                }

                #endregion
                user.Status = 1;
                dbManager.Accounts.Add(user);
                dbManager.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static bool updateUser(Account user)
        {
            try
            {

                #region Validate

                Account valid = dbManager.Accounts.FirstOrDefault(p => p.UserName == user.UserName && p.UserId != user.UserId);
                if (valid != null)
                {
                    return false;
                }

                #endregion

                Account updateUser = dbManager.Accounts.FirstOrDefault(p => p.UserId == user.UserId);
                updateUser.PassWord = user.PassWord;
                updateUser.FullName = user.FullName;
                updateUser.IDNumber = user.IDNumber;
                updateUser.BirthDay = user.BirthDay;
                updateUser.Address = user.Address;

                dbManager.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw;
            }
        }

        public static bool deleteUser(int userId)
        {
            try
            {
                Account delUser = dbManager.Accounts.FirstOrDefault(p => p.UserId == userId);
                if (delUser != null)
                {
                    delUser.Status = 0;
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

        public static List<Account> GetUserByContentString(string search)
        {
            try
            {
                return dbManager.Accounts.Where(p => p.UserName.Contains(search) && p.Status == 1).ToList();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        #endregion

        #region General

        public static string convertToMoney(string money)
        {
            return String.Format("{0:#,#.}", Int32.Parse(money));
        }

        public static int convertMoneyToInt(string money)
        {
            var replaced = Regex.Replace(money, @"[,\.]", "");
            return Int32.Parse(replaced);
        }

        #endregion

        #region Customer

        public static Customer getCustomerByID(string customerId)
        {
            return dbManager.Customers.Where(p => p.CustomerId == customerId).FirstOrDefault();
        }

        public static bool synchronizeCustomer(Customer customer, bool isUpdate)
        {
            try
            {
                if (isUpdate)
                {
                    Customer oldCustomer = dbManager.Customers.Where(p => p.CustomerId == customer.CustomerId).FirstOrDefault();
                    oldCustomer.CustomerName = customer.CustomerName;
                    oldCustomer.CustomerAddress = customer.CustomerAddress;
                    oldCustomer.CustomerPhone = customer.CustomerPhone;
                    dbManager.SaveChanges();
                    return true;
                }
                else
                {
                    dbManager.Customers.Add(customer);
                    dbManager.SaveChanges();
                    return true;
                }
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