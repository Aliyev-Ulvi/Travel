using Core.DataAccess.Concrete;
using DataAccess.EF.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EF.Concrete
{
    public class EfBlogDal : BaseRepository<Blog, BaseProjectContext>, IBlogDal
    {
        public EfBlogDal(BaseProjectContext context) : base(context)
        {

        }
    }
}
