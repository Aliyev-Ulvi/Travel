using Core.DataAccess.Concrete;
using DataAccess.EF.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EF.Concrete
{
    public class EfOrderDetailDal : BaseRepository<OrderDetail, BaseProjectContext>, IOrderDetailDal
    {
        public EfOrderDetailDal(BaseProjectContext context) : base(context)
        {

        }

        public List<OrderDetailDto> GetAllOrderDetails()
        {
            var context = new BaseProjectContext();
            var result = from d in context.OrderDetails
                         where d.IsDeleted == false
                         join o in context.Orders
                         on d.OrderId equals o.Id
                         join t in context.Travels
                         on d.TravelId equals t.Id
                         select new OrderDetailDto()
                         {
                             OrderId = o.Id,
                             OrderDate = o.OrderDate,
                             IsDelivery = o.IsDelivery,
                             TravelName = t.TravelName,
                             TotalPrice = d.TotalPrice,
                             DiscountPriceRate = d.DiscountPriceRate,
                             IsDiscount = d.IsDiscount,
                             Count = d.Count,
                         };
                         return result.ToList();
        }
    }
}
