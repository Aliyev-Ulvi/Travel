using Business.Abstract;
using Core.Helpers.Result.Abstract;
using Core.Helpers.Result.Concrete;
using DataAccess.EF.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager(ICategoryDal categoryDal) : ICategoryService
    {
        private readonly ICategoryDal _categoryDal = categoryDal;

        public IResult Add(Category category)
        {
            if (category.CategoryName.Length > 2)
            {
                _categoryDal.Add(category);
                return new SuccessResult("Category added successfully");
            }
            else
                return new ErrorResult("Length of category name is short");
        }

        public IResult Delete(int id)
        {
            Category deletedCategory = _categoryDal.GetAll(c => c.IsDeleted == false).SingleOrDefault(c => c.Id == id);

            if (deletedCategory != null)
            {
                deletedCategory.IsDeleted = true;
                _categoryDal.Delete(deletedCategory);
                return new SuccessResult("Category deleted succesfully");
            }
            else
                return new ErrorResult("Category was not found");
        }

        public IDataResult<List<Category>> GetAllCategories()
        {
            var categories = _categoryDal.GetAll(c => c.IsDeleted == false);

            if (categories.Count != 0)
                return new SuccessDataResult<List<Category>>(categories, "Categories loaded");
            else
                return new ErrorDataResult<List<Category>>(categories, "List of categories is empty");
        }

        public IDataResult<Category> GetCategory(int id)
        {
            var getCategory = _categoryDal.Get(c => c.Id == id);

            if (getCategory != null)
                return new SuccessDataResult<Category>(getCategory, "Category loaded");
            else
                return new ErrorDataResult<Category>(getCategory, "Category was not found");
        }

        public IResult Update(Category category)
        {
            Category updatedCategory = _categoryDal.GetAll(c => c.IsDeleted == false).SingleOrDefault(c => c.Id == category.Id);

            if (updatedCategory != null)
            {
                updatedCategory = category;

                _categoryDal.Update(updatedCategory);

                return new SuccessResult("Category updated succesfully");
            }
            else
                return new ErrorResult("Category was not found");
        }
    }
}
