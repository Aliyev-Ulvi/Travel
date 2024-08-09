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
    public class BlogManager(IBlogDal blogDal) : IBlogService
    {
        private readonly IBlogDal _blogDal = blogDal;

        public IResult Add(Blog blog)
        {
            if (blog.Title.Length > 2)
            {
                _blogDal.Add(blog);
                return new SuccessResult("Blog added successfully");
            }
            else
                return new ErrorResult("Length of blog name is short");
        }

        public IResult Delete(int id)
        {
            Blog deletedBlog = _blogDal.GetAll(b => b.IsDeleted == false).SingleOrDefault(b => b.Id == id);

            if (deletedBlog != null)
            {
                deletedBlog.IsDeleted = true;
                _blogDal.Delete(deletedBlog);
                return new SuccessResult("Blog deleted succesfully");
            }
            else
                return new ErrorResult("Blog was not found");
        }

        public IDataResult<List<Blog>> GetAllBlogs()
        {
            var blogs = _blogDal.GetAll(b => b.IsDeleted == false);

            if (blogs.Count != 0)
                return new SuccessDataResult<List<Blog>>(blogs, "Blogs loaded");
            else
                return new ErrorDataResult<List<Blog>>(blogs, "List of blogs is empty");
        }

        public IDataResult<Blog> GetBlog(int id)
        {
            var getBlog = _blogDal.Get(b => b.Id == id);

            if (getBlog != null)
                return new SuccessDataResult<Blog>(getBlog, "Blog loaded");
            else
                return new ErrorDataResult<Blog>(getBlog, "Blog was not found");
        }

        public IResult Update(int id,Blog blog)
        {
            Blog updatedBlog = _blogDal.GetAll(b => b.IsDeleted == false).SingleOrDefault(b => b.Id == id);

            if (updatedBlog != null)
            {
                updatedBlog = blog;

                _blogDal.Update(updatedBlog);

                return new SuccessResult("Blog updated succesfully");
            }
            else
                return new ErrorResult("Blog was not found");
        }
    }
}
