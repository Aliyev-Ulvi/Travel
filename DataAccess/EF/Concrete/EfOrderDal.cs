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
    public class EfOrderDal : BaseRepository<Order, BaseProjectContext>, IOrderDal
    {
        public EfOrderDal(BaseProjectContext context) : base(context)
        {

        }
    }
}
