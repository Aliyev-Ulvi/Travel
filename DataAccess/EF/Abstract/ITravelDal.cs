using Core.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.EF.Abstract
{
    public interface ITravelDal : IBaseRepository<Travel>
    {
    }
}
