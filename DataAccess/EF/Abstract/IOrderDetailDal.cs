using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EF.Abstract
{
    public interface IOrderDetailDal : IBaseRepository<OrderDetail>
    {
        List<OrderDetailDto> GetAllOrderDetails();
    }
}
