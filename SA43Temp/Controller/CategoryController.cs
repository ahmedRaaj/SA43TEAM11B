using LibraryManagementSystem.Dao;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using LibraryManagementSystem.UI;
using System;

namespace LibraryManagementSystem.Controller
{
    public class CategoryController 
    {
        private List<Category> _categoryList;
        private CategoryDao catDao;
        public FormManageCategories fromManagerCategory { get; set; }
        public List<Category> CategoryList
        {
            get
            {
                if (_categoryList == null) _categoryList = catDao.Categories.ToList();
                return _categoryList;
            }
        }

        public CategoryController()
        {
            catDao = new CategoryDao();
            fromManagerCategory = new FormManageCategories(this);
            fromManagerCategory.cmbSearchType.DataSource = new string[]{"ID","CategoryName","Details" };

           
           // cat.Message

        }
        public void ShowManageCategoryForm()
        {
            fromManagerCategory.Show();
        }

        public void Filter(string searchType,string keywords)
        {
            if (keywords == null || keywords == "" || keywords == " ")
            {
                fromManagerCategory.ShowMessage("Please input the keyword");
                return;
            }
                
            if (searchType.Equals("ID"))
            {
              int ID =  Convert.ToInt32(keywords);
              _categoryList =   _categoryList.Where(c => c.CategoryID == ID).ToList();
            }
            else if (searchType.Equals("CategoryName"))
            {
                _categoryList = _categoryList.Where(c => c.CategoryName.Contains(keywords)).ToList();
            }
            
           
        }

        public void InitiateCrud(bool create)
        {
            FormCategoryCrud catCrudForm = new FormCategoryCrud(this,create);
            if (!create)
            {
                Category cat = fromManagerCategory.dgv.SelectedRows[0].DataBoundItem as Category;
                catCrudForm.UpdateFields(cat.CategoryID, cat.CategoryName, cat.Details);
            }
            
            catCrudForm.Show();

        }

        public void Reset()
        {
            this._categoryList = null;
            
        }

        public void Refresh()
        {
            this._categoryList = null;
            fromManagerCategory.dgv.DataSource = null;
            fromManagerCategory.dgv.DataSource = CategoryList;

        }
        public bool SaveCategory(string categoryName, string categoryDetail)
        {
            Category category = new Category();
            category.CategoryName = categoryName;
            category.Details = categoryDetail;
            catDao.Add(category);

            if (category.CategoryID != null)
                return true;
            else
                return false;
        }

        public bool UpdateCategory(int categoryID, string categoryName, string categoryDetail)
        {
            Category category = catDao.Categories.Where(cate => cate.CategoryID == categoryID).ToList().FirstOrDefault();
            if (category != null)
            {
                category.CategoryID = categoryID;
                category.CategoryName = categoryName;
                category.Details = categoryDetail;
                catDao.ct.SaveChanges();
                return true;
            }
            else return false;
        }

        public bool DeleteCategory(int categoryID)
        {
            Category category = catDao.Categories.Where(cate => cate.CategoryID == categoryID).ToList().FirstOrDefault();
            if (category != null)
            {
             //   catDao.Categories.Remove(category);
                catDao.ct.Categories.Remove(category);
                catDao.ct.SaveChanges();
                return true;
            }
            else return false;
        }
    }
}
