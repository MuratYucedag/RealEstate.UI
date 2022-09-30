using RealEstate.EntityLayer.Entities;
using RealEstate.FacadeLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.BusinessLayer.Validation
{
    public class BLCategory
    {

        public static List<Category> BLCategoryList()
        {
            //yetkisi var mı
            return DALCategory.CategoryList();
        }
        public static void BLCategoryAdd(Category category)
        {
            if (category.CategoryName.Length <= 15 && category.CategoryName != "" && category.CategoryName.Length >= 4)
            {
                DALCategory.AddCategory(category);
            }
            else
            {
                //hata mesajları
            }
        }
        public static void BLCategoryDelete(int id)
        {
            if (id != 0)
            {
                DALCategory.DeleteCategory(id);
            }
            else
            {
                //hata mesajları
            }
        }
        public static void BLCategoryUpdate(Category category)
        {
            if (category.CategoryName != "" && category.CategoryName.Length >= 5)
            {
                DALCategory.UpdateCategory(category);
            }
            else
            {
                //hata mesajları
            }
        }
    }
}
