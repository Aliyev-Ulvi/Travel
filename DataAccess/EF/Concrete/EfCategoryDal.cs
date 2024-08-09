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
    public class EfCategoryDal : BaseRepository<Category, BaseProjectContext>, ICategoryDal
    {
        public EfCategoryDal(BaseProjectContext context) : base(context)
        {

        }
    }
}
